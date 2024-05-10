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
    createTable($("#apdexTable"), {"supportsControllersDiscrimination": true, "overall": {"data": [0.9770454545454546, 500, 1500, "Total"], "isController": false}, "titles": ["Apdex", "T (Toleration threshold)", "F (Frustration threshold)", "Label"], "items": [{"data": [1.0, 500, 1500, "Edit Language "], "isController": false}, {"data": [1.0, 500, 1500, "Share Skill Add New"], "isController": false}, {"data": [1.0, 500, 1500, "Add Education"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Education"], "isController": false}, {"data": [1.0, 500, 1500, "Add Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Add Certification-0"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Enable "], "isController": false}, {"data": [1.0, 500, 1500, "Profile Description"], "isController": false}, {"data": [1.0, 500, 1500, "Edit Education"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Delete"], "isController": false}, {"data": [0.5, 500, 1500, "Search Skill by Categories"], "isController": false}, {"data": [1.0, 500, 1500, "Add Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Edit Skills"], "isController": false}, {"data": [1.0, 500, 1500, "Add Language "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification-0"], "isController": false}, {"data": [0.995, 500, 1500, "SignIn"], "isController": false}, {"data": [1.0, 500, 1500, "Delete Certification"], "isController": false}, {"data": [1.0, 500, 1500, "Sign Out"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings Disable"], "isController": false}, {"data": [1.0, 500, 1500, "Manage Listings View "], "isController": false}, {"data": [1.0, 500, 1500, "Delete Language "], "isController": false}]}, function(index, item){
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
    createTable($("#statisticsTable"), {"supportsControllersDiscrimination": true, "overall": {"data": ["Total", 2200, 0, 0.0, 117.639090909091, 0, 709, 96.0, 193.0, 387.7999999999993, 595.0, 42.25974375228107, 177.33940922198852, 25.523024356979583], "isController": false}, "titles": ["Label", "#Samples", "FAIL", "Error %", "Average", "Min", "Max", "Median", "90th pct", "95th pct", "99th pct", "Transactions/s", "Received", "Sent"], "items": [{"data": ["Edit Language ", 100, 0, 0.0, 153.77999999999994, 137, 404, 146.5, 162.9, 167.95, 403.8599999999999, 2.0636853292609945, 0.43329330643663455, 1.3321250025796065], "isController": false}, {"data": ["Share Skill Add New", 100, 0, 0.0, 98.24000000000001, 72, 423, 83.0, 96.9, 330.74999999999767, 423.0, 2.0721094073767095, 0.4532739328636552, 3.57762639867385], "isController": false}, {"data": ["Add Education", 100, 0, 0.0, 134.64999999999995, 79, 241, 132.0, 165.0, 168.89999999999998, 240.4199999999997, 2.0701790704895973, 0.4184834644446745, 1.4232481109615982], "isController": false}, {"data": ["Delete Education", 100, 0, 0.0, 40.18, 35, 83, 38.0, 47.0, 52.0, 82.84999999999992, 2.0752485110091934, 0.4418009525390666, 1.2017796553012223], "isController": false}, {"data": ["Add Certification", 100, 0, 0.0, 138.05, 83, 217, 132.0, 169.8, 195.24999999999983, 216.99, 2.069879119059447, 45.312119983130486, 1.3927213994452725], "isController": false}, {"data": ["Add Certification-0", 100, 0, 0.0, 0.8, 0, 11, 1.0, 1.0, 2.0, 10.949999999999974, 2.0752054453390887, 45.00922007294347, 0.0], "isController": false}, {"data": ["Delete Skills", 100, 0, 0.0, 39.81999999999998, 34, 78, 38.0, 44.0, 47.89999999999998, 77.90999999999995, 2.0752054453390887, 0.44787148771478374, 1.3699598447746326], "isController": false}, {"data": ["Manage Listings Enable ", 100, 0, 0.0, 118.99999999999996, 103, 193, 117.0, 130.9, 135.0, 192.76999999999987, 2.0843320757863144, 0.3867413031244138, 1.176507753715322], "isController": false}, {"data": ["Profile Description", 100, 0, 0.0, 117.36999999999999, 101, 165, 115.0, 133.0, 137.84999999999997, 164.85999999999993, 2.06996481059822, 0.44471900227696126, 1.253299006416891], "isController": false}, {"data": ["Edit Education", 100, 0, 0.0, 225.65000000000003, 120, 316, 231.0, 275.9, 284.84999999999997, 315.81999999999994, 2.066969822240595, 0.4395944217651922, 1.5038012866887143], "isController": false}, {"data": ["Manage Listings Delete", 100, 0, 0.0, 159.29000000000008, 141, 208, 159.0, 172.0, 178.74999999999994, 208.0, 2.0823355475501324, 0.42094087728796614, 1.1875819919621846], "isController": false}, {"data": ["Search Skill by Categories", 100, 0, 0.0, 590.5300000000002, 572, 697, 588.0, 599.9, 610.95, 696.3899999999996, 2.0666708000082665, 0.9203143406286812, 1.5257843015686032], "isController": false}, {"data": ["Add Skills", 100, 0, 0.0, 47.18999999999999, 38, 286, 43.0, 53.0, 61.0, 283.95999999999896, 2.074344507135745, 0.41932550095419846, 1.3329284039993363], "isController": false}, {"data": ["Edit Skills", 100, 0, 0.0, 155.0300000000001, 136, 429, 147.0, 172.9, 193.34999999999985, 426.8899999999989, 2.070221927790659, 0.41849212798111957, 1.3949737599370653], "isController": false}, {"data": ["Add Language ", 100, 0, 0.0, 55.43, 40, 388, 45.0, 51.0, 59.69999999999993, 388.0, 2.054062936488374, 0.41522561313778655, 1.237653156067702], "isController": false}, {"data": ["Delete Certification-0", 100, 0, 0.0, 0.7700000000000001, 0, 9, 1.0, 1.0, 1.0, 8.929999999999964, 2.074516637623434, 44.82615145397685, 0.0], "isController": false}, {"data": ["SignIn", 100, 0, 0.0, 188.10000000000002, 155, 709, 173.0, 208.8, 241.24999999999983, 706.869999999999, 2.026055068176753, 0.9734561460380493, 0.6982767135360739], "isController": false}, {"data": ["Delete Certification", 100, 0, 0.0, 45.91000000000001, 35, 384, 40.0, 47.900000000000006, 59.89999999999998, 381.2299999999986, 2.072796617195921, 45.23633686961073, 1.220601914227676], "isController": false}, {"data": ["Sign Out", 100, 0, 0.0, 38.93999999999998, 34, 52, 38.0, 44.0, 48.849999999999966, 51.989999999999995, 2.090694319583534, 0.4222018343229286, 1.094347807907006], "isController": false}, {"data": ["Manage Listings Disable", 100, 0, 0.0, 120.78000000000006, 100, 463, 117.0, 127.9, 132.95, 460.0899999999985, 2.0842886322897995, 0.3846978042019259, 1.1764832318979532], "isController": false}, {"data": ["Manage Listings View ", 100, 0, 0.0, 79.22999999999995, 69, 102, 80.0, 84.9, 90.94999999999999, 101.94999999999997, 2.085810232985003, 2.710982964144922, 1.1325297749410759], "isController": false}, {"data": ["Delete Language ", 100, 0, 0.0, 39.32000000000001, 35, 56, 38.5, 43.0, 45.94999999999999, 55.969999999999985, 2.073355310899629, 0.44747219112189257, 1.2978718303580685], "isController": false}]}, function(index, item){
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
    createTable($("#top5ErrorsBySamplerTable"), {"supportsControllersDiscrimination": false, "overall": {"data": ["Total", 2200, 0, "", "", "", "", "", "", "", "", "", ""], "isController": false}, "titles": ["Sample", "#Samples", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors", "Error", "#Errors"], "items": [{"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}, {"data": [], "isController": false}]}, function(index, item){
        return item;
    }, [[0, 0]], 0);

});
