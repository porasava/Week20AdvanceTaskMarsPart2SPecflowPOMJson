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
    createTable($("#apdexTable"), {"supportsControllersDiscrimination": true, "overall": {"data": [0.9750909090909091, 500, 1500, "Total"], "isController": false}, "titles": ["Apdex", "T (Toleration threshold)", "F (Frustration threshold)", "Label"], "items": [{"data": [1.0, 500, 1500, "Edit Language "], "isController": false}, {"data": [0.998, 500, 1500, "Share Skill Add New"], "isController": false}, {"data": [1.0, 500, 1500, "Add Education"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Education"], "isController": false}, {"data": [0.998, 500, 1500, "Add Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Add Certification-0"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Skills"], "isController": false}, {"data": [0.999, 500, 1500, "Manage Listings Enable "], "isController": false}, {"data": [1.0, 500, 1500, "Profile Description"], "isController": false}, {"data": [0.981, 500, 1500, "Edit Education"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Delete"], "isController": false}, {"data": [0.483, 500, 1500, "Search Skill by Categories"], "isController": false}, {"data": [1.0, 500, 1500, "Add Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Edit Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Add Language "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification-0"], "isController": false}, {"data": [0.993, 500, 1500, "SignIn"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Sign Out"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Disable"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings View "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Language "], "isController": false}]}, function(index, item){
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
    createTable($("#statisticsTable"), {"supportsControllersDiscrimination": true, "overall": {"data": ["Total", 11000, 0, 0.0, 147.23063636363693, 0, 2038, 106.0, 298.0, 477.9499999999989, 968.9499999999989, 107.49640864271126, 451.1788893697046, 64.9272200451485], "isController": false}, "titles": ["Label", "#Samples", "FAIL", "Error %", "Average", "Min", "Max", "Median", "90th pct", "95th pct", "99th pct", "Transactions/s", "Received", "Sent"], "items": [{"data": ["Edit Language ", 500, 0, 0.0, 158.7339999999999, 136, 416, 155.0, 175.90000000000003, 188.89999999999998, 229.85000000000014, 5.067088248408934, 1.0638905990311727, 3.270845050974908], "isController": false}, {"data": ["Share Skill Add New", 500, 0, 0.0, 96.85399999999996, 70, 589, 84.0, 131.0, 160.89999999999998, 325.4500000000005, 5.069554284787282, 1.1089649997972177, 8.75290231982804], "isController": false}, {"data": ["Add Education", 500, 0, 0.0, 241.80400000000003, 103, 474, 234.5, 330.90000000000003, 365.0, 427.94000000000005, 5.0687833906105855, 1.024646642437882, 3.4847885810447776], "isController": false}, {"data": ["Delete Education", 500, 0, 0.0, 41.34600000000001, 34, 287, 40.0, 46.0, 49.0, 61.91000000000008, 5.0726402077753425, 1.0799175442334226, 2.9375738703230256], "isController": false}, {"data": ["Add Certification", 500, 0, 0.0, 236.402, 94, 539, 228.0, 332.0, 359.9, 418.0, 5.066472114137484, 110.92803203023671, 3.408983678360084], "isController": false}, {"data": ["Add Certification-0", 500, 0, 0.0, 0.6100000000000004, 0, 10, 1.0, 1.0, 1.0, 2.0, 5.071919823091436, 110.02202639680672, 0.0], "isController": false}, {"data": ["Delete Skills", 500, 0, 0.0, 40.804, 34, 93, 40.0, 47.0, 51.94999999999999, 62.98000000000002, 5.076296740002233, 1.0955679487700134, 3.3511490197670994], "isController": false}, {"data": ["Manage Listings Enable ", 500, 0, 0.0, 129.43999999999988, 100, 547, 116.0, 167.60000000000014, 205.95, 370.98, 5.070993914807302, 0.9409070740365112, 2.8623383620689657], "isController": false}, {"data": ["Profile Description", 500, 0, 0.0, 119.52600000000008, 103, 356, 118.0, 131.90000000000003, 136.0, 155.0, 5.066882853668424, 1.0885881130928252, 3.067839227807053], "isController": false}, {"data": ["Edit Education", 500, 0, 0.0, 347.98400000000004, 167, 874, 332.5, 455.0, 491.0, 635.8200000000002, 5.060575083752517, 1.076528625775533, 3.681766052144166], "isController": false}, {"data": ["Manage Listings Delete", 500, 0, 0.0, 165.72000000000008, 141, 454, 158.0, 193.0, 218.0, 321.98, 5.070788203318323, 1.0250519121942314, 2.8919338972049817], "isController": false}, {"data": ["Search Skill by Categories", 500, 0, 0.0, 865.254000000001, 596, 2038, 795.0, 1190.0000000000007, 1445.3999999999999, 1822.0900000000008, 5.048465266558966, 2.2481446890145396, 3.7271872475767363], "isController": false}, {"data": ["Add Skills", 500, 0, 0.0, 45.836000000000034, 37, 288, 43.0, 51.0, 55.94999999999999, 75.98000000000002, 5.076451357443093, 1.0261967099518752, 3.2620165949194875], "isController": false}, {"data": ["Edit Skills", 500, 0, 0.0, 157.92999999999984, 137, 442, 155.0, 172.0, 182.0, 245.6600000000003, 5.071456826688034, 1.0251870733636945, 3.4172902445456486], "isController": false}, {"data": ["Add Language ", 500, 0, 0.0, 46.538, 39, 211, 45.0, 52.0, 57.0, 70.98000000000002, 5.075060139462653, 1.0259154774109074, 3.057921978562946], "isController": false}, {"data": ["Delete Certification-0", 500, 0, 0.0, 0.6019999999999995, 0, 22, 1.0, 1.0, 1.0, 1.990000000000009, 5.072588744940092, 109.63036323222818, 0.0], "isController": false}, {"data": ["SignIn", 500, 0, 0.0, 208.62800000000007, 152, 1156, 184.0, 248.90000000000003, 281.0, 912.930000000001, 5.024166239612536, 2.413954872938836, 1.7358101844873843], "isController": false}, {"data": ["Delete Certification", 500, 0, 0.0, 42.178000000000004, 35, 286, 40.0, 48.900000000000034, 52.94999999999999, 67.99000000000001, 5.070325413485038, 110.67572662516605, 2.9857482659487085], "isController": false}, {"data": ["Sign Out", 500, 0, 0.0, 40.403999999999996, 34, 131, 39.0, 47.0, 52.0, 60.99000000000001, 5.0925831618830335, 1.0332274341274368, 2.6656489987981504], "isController": false}, {"data": ["Manage Listings Disable", 500, 0, 0.0, 126.30600000000001, 100, 410, 116.0, 152.0, 183.0, 361.97, 5.071559707472436, 0.9360593600705961, 2.8626577255069026], "isController": false}, {"data": ["Manage Listings View ", 500, 0, 0.0, 84.86200000000005, 68, 323, 78.5, 104.60000000000014, 131.69999999999993, 189.94000000000005, 5.071714036475767, 6.591554185558802, 2.753782230742702], "isController": false}, {"data": ["Delete Language ", 500, 0, 0.0, 41.31199999999995, 34, 280, 39.0, 46.0, 50.0, 68.99000000000001, 5.074133084362536, 1.0951009879337115, 3.176288385816783], "isController": false}]}, function(index, item){
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
    createTable($("#top5ErrorsBySamplerTable"), {"supportsControllersDiscrimination": false, "overall": {"data": ["Total", 11000, 0, "", "", "", "", "", "", "", "", "", ""], "isController": false}, "titles": ["Sample", "#Samples", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors"], "items": [{"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}]}, function(index, item){
        return item;
    }, [[0, 0]], 0);

});
