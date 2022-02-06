navigator.geolocation.watchPosition(function(pos){
        initMap(pos.coords.latitude,pos.coords.longitude);
    })
    
    let map;
    
    function initMap(mylat,mylng) {
      map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: mylat, lng: mylng },
        zoom: 5,
      });
      const marker = new google.maps.Marker({
        position: { lat: mylat, lng: mylng },
        map: map, 
      });
    }