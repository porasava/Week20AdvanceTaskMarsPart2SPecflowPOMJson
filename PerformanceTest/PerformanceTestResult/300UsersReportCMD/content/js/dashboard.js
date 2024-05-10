/*
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
var showControllersOnly = false;
var seriesFilter = "";
var filtersOnlySampleSeries = true;

/*
 * Add header in statistics table to group metrics by category
 * format
 *
 */
function summaryTableHeader(header) {
    var newRow = header.insertRow(-1);
    newRow.className = "tablesorter-no-sort";
    var cell = document.createElement('th');
    cell.setAttribute("data-sorter", false);
    cell.colSpan = 1;
    cell.innerHTML = "Requests";
    newRow.appendChild(cell);

    cell = document.createElement('th');
    cell.setAttribute("data-sorter", false);
    cell.colSpan = 3;
    cell.innerHTML = "Executions";
    newRow.appendChild(cell);

    cell = document.createElement('th');
    cell.setAttribute("data-sorter", false);
    cell.colSpan = 7;
    cell.innerHTML = "Response Times (ms)";
    newRow.appendChild(cell);

    cell = document.createElement('th');
    cell.setAttribute("data-sorter", false);
    cell.colSpan = 1;
    cell.innerHTML = "Throughput";
    newRow.appendChild(cell);

    cell = document.createElement('th');
    cell.setAttribute("data-sorter", false);
    cell.colSpan = 2;
    cell.innerHTML = "Network (KB/sec)";
    newRow.appendChild(cell);
}

/*
 * Populates the table identified by id parameter with the specified data and
 * format
 *
 */
function createTable(table, info, formatter, defaultSorts, seriesIndex, headerCreator) {
    var tableRef = table[0];

    // Create header and populate it with data.titles array
    var header = tableRef.createTHead();

    // Call callback is available
    if(headerCreator) {
        headerCreator(header);
    }

    var newRow = header.insertRow(-1);
    for (var index = 0; index < info.titles.length; index++) {
        var cell = document.createElement('th');
        cell.innerHTML = info.titles[index];
        newRow.appendChild(cell);
    }

    var tBody;

    // Create overall body if defined
    if(info.overall){
        tBody = document.createElement('tbody');
        tBody.className = "tablesorter-no-sort";
        tableRef.appendChild(tBody);
        var newRow = tBody.insertRow(-1);
        var data = info.overall.data;
        for(var index=0;index < data.length; index++){
            var cell = newRow.insertCell(-1);
            cell.innerHTML = formatter ? formatter(index, data[index]): data[index];
        }
    }

    // Create regular body
    tBody = document.createElement('tbody');
    tableRef.appendChild(tBody);

    var regexp;
    if(seriesFilter) {
        regexp = new RegExp(seriesFilter, 'i');
    }
    // Populate body with data.items array
    for(var index=0; index < info.items.length; index++){
        var item = info.items[index];
        if((!regexp || filtersOnlySampleSeries && !info.supportsControllersDiscrimination || regexp.test(item.data[seriesIndex]))
                &&
                (!showControllersOnly || !info.supportsControllersDiscrimination || item.isController)){
            if(item.data.length > 0) {
                var newRow = tBody.insertRow(-1);
                for(var col=0; col < item.data.length; col++){
                    var cell = newRow.insertCell(-1);
                    cell.innerHTML = formatter ? formatter(col, item.data[col]) : item.data[col];
                }
            }
        }
    }

    // Add support of columns sort
    table.tablesorter({sortList : defaultSorts});
}

$(document).ready(function() {

    // Customize table sorter default options
    $.extend( $.tablesorter.defaults, {
        theme: 'blue',
        cssInfoBlock: "tablesorter-no-sort",
        widthFixed: true,
        widgets: ['zebra']
    });

    var data = {"OkPercent": 100.0, "KoPercent": 0.0};
    var dataset = [
        {
            "label" : "FAIL",
            "data" : data.KoPercent,
            "color" : "#FF6347"
        },
        {
            "label" : "PASS",
            "data" : data.OkPercent,
            "color" : "#9ACD32"
        }];
    $.plot($("#flot-requests-summary"), dataset, {
        series : {
            pie : {
                show : true,
                radius : 1,
                label : {
                    show : true,
                    radius : 3 / 4,
                    formatter : function(label, series) {
                        return '<div style="font-size:8pt;text-align:center;padding:2px;color:white;">'
                            + label
                            + '<br/>'
                            + Math.round10(series.percent, -2)
                            + '%</div>';
                    },
                    background : {
                        opacity : 0.5,
                        color : '#000'
                    }
                }
            }
        },
        legend : {
            show : true
        }
    });

    // Creates APDEX table
    createTable($("#apdexTable"), {"supportsControllersDiscrimination": true, "overall": {"data": [0.9768939393939394, 500, 1500, "Total"], "isController": false}, "titles": ["Apdex", "T (Toleration threshold)", "F (Frustration threshold)", "Label"], "items": [{"data": [1.0, 500, 1500, "Edit Language "], "isController": false}, {"data": [1.0, 500, 1500, "Share Skill Add New"], "isController": false}, {"data": [1.0, 500, 1500, "Add Education"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Education"], "isController": false}, {"data": [1.0, 500, 1500, "Add Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Add Certification-0"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Enable "], "isController": false}, {"data": [1.0, 500, 1500, "Profile Description"], "isController": false}, {"data": [1.0, 500, 1500, "Edit Education"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Delete"], "isController": false}, {"data": [0.5, 500, 1500, "Search Skill by Categories"], "isController": false}, {"data": [1.0, 500, 1500, "Add Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Edit Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Add Language "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification-0"], "isController": false}, {"data": [0.9916666666666667, 500, 1500, "SignIn"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Sign Out"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Disable"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings View "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Language "], "isController": false}]}, function(index, item){
        switch(index){
            case 0:
                item = item.toFixed(3);
                break;
            case 1:
            case 2:
                item = formatDuration(item);
                break;
        }
        return item;
    }, [[0, 0]], 3);

    // Create statistics table
    createTable($("#statisticsTable"), {"supportsControllersDiscrimination": true, "overall": {"data": ["Total", 6600, 0, 0.0, 119.58, 0, 1113, 101.0, 209.90000000000055, 308.89999999999964, 612.0, 64.61845738119015, 271.2067462495594, 39.028768063796036], "isController": false}, "titles": ["Label", "#Samples", "FAIL", "Error %", "Average", "Min", "Max", "Median", "90th pct", "95th pct", "99th pct", "Transactions/s", "Received", "Sent"], "items": [{"data": ["Edit Language ", 300, 0, 0.0, 153.14000000000007, 136, 269, 151.0, 169.0, 173.95, 203.82000000000016, 3.0467988300292492, 0.6397087387268443, 1.96673244789974], "isController": false}, {"data": ["Share Skill Add New", 300, 0, 0.0, 84.21999999999998, 70, 437, 81.0, 93.0, 101.0, 130.0, 3.0489354133848265, 0.6669546216779308, 5.264177549672239], "isController": false}, {"data": ["Add Education", 300, 0, 0.0, 145.93666666666664, 82, 239, 141.0, 175.90000000000003, 189.89999999999998, 219.96000000000004, 3.0496172730322346, 0.6164753667164771, 2.096611875209661], "isController": false}, {"data": ["Delete Education", 300, 0, 0.0, 40.979999999999976, 34, 99, 40.0, 47.0, 50.94999999999999, 69.94000000000005, 3.049958317236331, 0.6493075323803909, 1.7662356270714301], "isController": false}, {"data": ["Add Certification", 300, 0, 0.0, 144.50000000000017, 85, 228, 137.0, 173.0, 182.0, 213.8800000000001, 3.047170194612603, 66.7147462246831, 2.050293226648519], "isController": false}, {"data": ["Add Certification-0", 300, 0, 0.0, 0.6433333333333326, 0, 14, 1.0, 1.0, 1.0, 9.970000000000027, 3.051137057076604, 66.18481412536613, 0.0], "isController": false}, {"data": ["Delete Skills", 300, 0, 0.0, 40.38333333333333, 34, 128, 39.0, 44.900000000000034, 47.0, 98.76000000000022, 3.053031151094512, 0.6589061371014522, 2.015477595839736], "isController": false}, {"data": ["Manage Listings Enable ", 300, 0, 0.0, 115.24333333333328, 100, 347, 112.0, 126.90000000000003, 136.95, 181.76000000000022, 3.048160942897785, 0.5655767374517374, 1.7205439697216012], "isController": false}, {"data": ["Profile Description", 300, 0, 0.0, 119.8533333333333, 104, 240, 117.0, 131.90000000000003, 148.0, 195.99, 3.0476964494336363, 0.6547785340580078, 1.845284959618022], "isController": false}, {"data": ["Edit Education", 300, 0, 0.0, 246.23333333333312, 156, 498, 247.0, 295.0, 305.95, 383.7600000000002, 3.0443562708665253, 0.6477085986574388, 2.2148881072222277], "isController": false}, {"data": ["Manage Listings Delete", 300, 0, 0.0, 157.64999999999998, 138, 500, 154.0, 172.0, 182.84999999999997, 246.94000000000005, 3.047417821299419, 0.6160307509853318, 1.7379804762098248], "isController": false}, {"data": ["Search Skill by Categories", 300, 0, 0.0, 603.1899999999996, 580, 699, 600.0, 624.0, 632.95, 673.8700000000001, 3.033551074888264, 1.35087821303618, 2.2396138795073512], "isController": false}, {"data": ["Add Skills", 300, 0, 0.0, 47.950000000000024, 37, 344, 44.0, 56.0, 66.94999999999999, 104.88000000000011, 3.0519751365758876, 0.6169520051476648, 1.9611324608075527], "isController": false}, {"data": ["Edit Skills", 300, 0, 0.0, 155.0233333333333, 135, 248, 153.0, 168.0, 184.89999999999998, 225.99, 3.0489044270092283, 0.6163312660067483, 2.0544375533558275], "isController": false}, {"data": ["Add Language ", 300, 0, 0.0, 46.47333333333335, 39, 102, 45.0, 52.0, 56.0, 72.95000000000005, 3.0489664003902677, 0.6163437938288919, 1.8371213564851514], "isController": false}, {"data": ["Delete Certification-0", 300, 0, 0.0, 0.5766666666666669, 0, 2, 1.0, 1.0, 1.0, 2.0, 3.0510129362948497, 65.93765334518143, 0.0], "isController": false}, {"data": ["SignIn", 300, 0, 0.0, 208.72000000000003, 156, 1113, 187.0, 248.90000000000003, 286.74999999999994, 1047.8500000000038, 3.017592564651921, 1.4498589275476026, 1.0421303071909231], "isController": false}, {"data": ["Delete Certification", 300, 0, 0.0, 42.59666666666667, 34, 326, 40.0, 47.0, 52.0, 107.76000000000022, 3.049803287687944, 66.56972025043967, 1.795929084449053], "isController": false}, {"data": ["Sign Out", 300, 0, 0.0, 40.81333333333334, 33, 101, 39.0, 47.0, 50.94999999999999, 86.98000000000002, 3.050578593073153, 0.6184472141862073, 1.5967872323117285], "isController": false}, {"data": ["Manage Listings Disable", 300, 0, 0.0, 114.23333333333333, 100, 340, 111.0, 126.0, 134.95, 156.96000000000004, 3.048377754971396, 0.562640034853119, 1.7206663499740888], "isController": false}, {"data": ["Manage Listings View ", 300, 0, 0.0, 79.76999999999998, 68, 357, 76.0, 88.90000000000003, 96.94999999999999, 134.82000000000016, 3.049338293590291, 3.963256347070602, 1.6556954015978531], "isController": false}, {"data": ["Delete Language ", 300, 0, 0.0, 42.63000000000002, 34, 133, 40.0, 51.0, 58.94999999999999, 86.96000000000004, 3.050640634533252, 0.6583902150701647, 1.9096295378279438], "isController": false}]}, function(index, item){
        switch(index){
            // Errors pct
            case 3:
                item = item.toFixed(2) + '%';
                break;
            // Mean
            case 4:
            // Mean
            case 7:
            // Median
            case 8:
            // Percentile 1
            case 9:
            // Percentile 2
            case 10:
            // Percentile 3
            case 11:
            // Throughput
            case 12:
            // Kbytes/s
            case 13:
            // Sent Kbytes/s
                item = item.toFixed(2);
                break;
        }
        return item;
    }, [[0, 0]], 0, summaryTableHeader);

    // Create error table
    createTable($("#errorsTable"), {"supportsControllersDiscrimination": false, "titles": ["Type of error", "Number of errors", "% in errors", "% in all samples"], "items": []}, function(index, item){
        switch(index){
            case 2:
            case 3:
                item = item.toFixed(2) + '%';
                break;
        }
        return item;
    }, [[1, 1]]);

        // Create top5 errors by sampler
    createTable($("#top5ErrorsBySamplerTable"), {"supportsControllersDiscrimination": false, "overall": {"data": ["Total", 6600, 0, "", "", "", "", "", "", "", "", "", ""], "isController": false}, "titles": ["Sample", "#Samples", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors"], "items": [{"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}]}, function(index, item){
        return item;
    }, [[0, 0]], 0);

});
