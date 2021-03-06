
function initGoogleMaps()
{
    mapMarker();
    mapStreetView();
    mapShapesDraw();


    //google.maps.event.addDomListener(window, "load", function () {
        new google.maps.Map(document.getElementById("gmap01"), { zoom: 3, center: new google.maps.LatLng(40.74, -74.18) })
    //})

    //google.maps.event.addDomListener(window, "load", mapMarker)
    //google.maps.event.addDomListener(window, "load", mapStreetView)
    //google.maps.event.addDomListener(window, "load", mapShapesDraw)


}
     

function mapMarker() { { var gmap02 = new google.maps.Map(document.getElementById("gmap02"), { zoom: 4, center: new google.maps.LatLng(-33, 151) }); new google.maps.Marker({ map: gmap02, icon: "https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png", animation: google.maps.Animation.DROP, title: "You are here", position: new google.maps.LatLng(-33.890542, 151.274856) }) } }
function mapStreetView() { new google.maps.StreetViewPanorama(document.querySelector("#street-view"), { position: new google.maps.LatLng(40.688738, -74.043871) }) }
function mapShapesDraw() { var gmap04 = new google.maps.Map(document.getElementById("gmap04"), { zoom: 11, center: new google.maps.LatLng(40.74, -74.18) }), polyline = new google.maps.Polyline({ path: [new google.maps.LatLng(40.74, -74.18), new google.maps.LatLng(40.64, -74.1), new google.maps.LatLng(40.54, -74.05), new google.maps.LatLng(40.44, -74)], geodesic: !0, strokeColor: "#FF0000", strokeOpacity: 1, strokeWeight: 2 }); polyline.setMap(gmap04); var polygon = new google.maps.Polygon({ path: [new google.maps.LatLng(40.74, -74.18), new google.maps.LatLng(40.64, -74.18), new google.maps.LatLng(40.84, -74.08), new google.maps.LatLng(40.74, -74.18)], geodesic: !0, strokeColor: "#FF0000", strokeOpacity: 1, strokeWeight: 2 }); polygon.setMap(gmap04); var circle = new google.maps.Circle({ strokeColor: "#FF0000", strokeOpacity: .8, strokeWeight: 2, center: new google.maps.LatLng(40.7, -74.14), radius: 4e3, editable: !0 }); circle.setMap(gmap04) }

if (window['google'] != undefined)
{
    initGoogleMaps();
}