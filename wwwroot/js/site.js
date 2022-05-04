
console.log("hello world")

function LoadMap() {
    map = new Microsoft.Maps.Map('#myMap', {
        credentials: "Ah0VTO6Cigsj3Itp0qiR2CetTpqMCwXSptiyuvTabfb0fTLf67WpibgawKVKpgg3"
    });
}

var url = "/Home/GetLocations";

$('#btnShowLocations').click(function () {
    console.log("Debug 1.")
    var url = "/Home/GetLocations";
    $.getJSON(url, null, function (data) {
        var pins = [];
        Loctions = JSON.parse(data)

        $.each(Loctions.locations, function (index, locationData) { 
            console.log(locationData)
            var pushpin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(
                locationData.lat,
                locationData.long), {title:locationData.title});

            pins.push(pushpin);
        });

        map.entities.push(pins);

        map.setView({
            zoom: 4
        });

    });
});