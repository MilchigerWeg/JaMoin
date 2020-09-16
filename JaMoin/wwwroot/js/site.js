// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var saveTransaction = function () {   

    if (!isValidValues()) {
        return;
    }

    var request = $.ajax({
        type: "POST",
        url: "/Interaction/CreateNewTransaction",
        data: getNewCreateModel(),
        contentType: "application/json",
        //Funktion bei technischem Erfolg (200er Rückmeldung)
        success: function (data) {
            window.location.replace("Uebersicht");
        },
        //Bei technischem Fehler -> billige Meldung
        error: function (data) {
            alert("Error: " + data);
        },
    });
}

var getNewCreateModel = function () {
    var kommentar = $("#Kommentar").val();
    var gesamtBetrag = $("#Gesamtbetrag").val();
    var geldleiher = $("#Geldleiher").val();
    var geliehenAn = $("#GeliehenAn").val();

    var response = {
        Kommentar: kommentar,
        GesamterBetrag: gesamtBetrag,
        GeldLeiher: geldleiher,
        GeldEmpfaenger: geliehenAn
    }

    return JSON.stringify(response);
}

var isValidValues = function () {

    console.log("isValid called");

    //Betrag muss positiv sein
    var gesamtBetrag = $("#Gesamtbetrag").val();
    if (isNaN(gesamtBetrag) || gesamtBetrag <= 0) {
        alert("Gesamtbetrag muss über 0 liegen");
        return false;
    }

    //Empfänger darf nicht sender sein
    if ($("#Geldleiher").val() == $("#GeliehenAn").val()) {
        alert("Geld muss man an andere verleihen");
        return false;
    }

    return true;
}

$('#SaveButton').click(saveTransaction);