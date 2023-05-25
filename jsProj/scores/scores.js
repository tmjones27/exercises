
//Tiani Jones, 15 DEC 2022
"use strict";
var $ = function (id) {
    return document.getElementById(id);
};

var scores = [];
var entries = [];
var x = 0;
var sum = 0;

var calculateScore = function () {
    if (isNaN($("score").value) || $("score").value < 0) {
        alert("Please enter a valid number");
    }
    if ($("first_name").value == "" || $("last_name").value == "") {
        alert("Please enter a valid name ");
    }
    if (!isNaN($("score").value) && $("score").value >= 0 && $("first_name").value != "" && $("last_name").value != "") {
        parseFloat(scores.push($("score").value));
        entries.push(($("last_name").value) + ", " + ($("first_name").value) + " : " + ($("score").value));
        displayScores();
    }

    $("first_name").value = "";
    $("last_name").value = "";
    $("score").value = "";
    $("first_name").focus();
};

var displayScores = function () {
    while (x < entries.length) {
        $("scores").value += entries[x] + "\n";
        sum += parseFloat(scores[x]);
        x++;
    }

    var avg = sum / entries.length;
    $("average_score").value = avg;
};

var sortSurname = function () {
    $("scores").value = "";
    var sort = entries.sort();
    for (x = 0; x < entries.length; x++) {
        $("scores").value += sort[x] + "\n";
    }
};

var clearScores = function () {
    scores = [];
    entries = [];

    $("average_score").value = "";
    $("first_name").value = "";
    $("last_name").value = "";
    $("scores").value = "";
    $("score").value = "";

    $("first_name").focus();
};

window.onload = function () {
    $("add_button").onclick = calculateScore;
    $("clear_button").onclick = clearScores;
    $("sort_button").onclick = sortSurname;
    $("first_name").focus();
};
