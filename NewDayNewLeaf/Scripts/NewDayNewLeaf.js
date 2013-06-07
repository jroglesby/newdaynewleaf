function getDateTicks(date) {
    var epochTicks = 621355968000000000;
    var ticksPerMillisecond = 10000;
    var ticks = epochTicks + (date.getTime() * ticksPerMillisecond);
    return ticks;
}

function buildLocationString(FishTimes) {
    var location = "";

    $.each(FishTimes, function (i, time) {
        if (i == 0) {
            location = time.LocationName;
        }
        else {
            location = location + ", " + time.LocationName;
        }
    });

    return location;
}

function formatPrice(price) {
    var formattedPrice = $.format.number(price, '#,###');
    return formattedPrice;
}

var buildFishTable = function (fishList) {
    var boxCount = 0;
    var fishCount = 0;

    var allFish = document.createElement("div");
    allFish.id = "allFish";
    $('#fishSection').append(allFish);

    $.each(fishList, function (i, fish) {

        if (fishCount % 12 == 0) {
            boxCount++;
            var foundFishBox = document.createElement("div");
            foundFishBox.id = "foundFishBox" + boxCount;
            foundFishBox.className = "foundFishBox";
            $('#allFish').append(foundFishBox);

            var foundFishTable = document.createElement("table");
            foundFishTable.id = "foundFishTable" + boxCount;
            foundFishTable.className = "foundFishTable";
            foundFishBox.appendChild(foundFishTable);
        }

        if (fishCount % 4 == 0) {
            var fishRow = document.createElement("tr");
            fishRow.className = "fishRow";
            $('#foundFishTable' + boxCount).append(fishRow);
        }

        var fishTd = document.createElement("td");
        fishTd.className = "fishTd";
        $('#foundFishTable' + boxCount + " tr:last").append(fishTd);

        var fishBoxLink = document.createElement("a");
        fishBoxLink.className = "fishBoxLink";
        fishBoxLink.href = "/FishInfo/" + fish.FishName;

        var fishBox = document.createElement("div");
        fishBox.className = "fishBox";
        fishBoxLink.appendChild(fishBox);

        var fishName = document.createElement("span");
        fishName.className = "fishNameSpan";
        fishName.appendChild(document.createTextNode(fish.FishName));

        var fishLocation = document.createElement("span");
        fishLocation.className = "fishLocationSpan";
        var location = buildLocationString(fish.FishTimes.$values);
        fishLocation.appendChild(document.createTextNode(location));

        var fishPrice = document.createElement("span");
        fishPrice.className = "fishPriceSpan";
        price = formatPrice(fish.Price);
        fishPrice.appendChild(document.createTextNode(price));

        var fishRarity = document.createElement("span");
        fishRarity.className = "fishRaritySpan";
        fishRarity.appendChild(document.createTextNode(fish.Rarity));

        var shadowSize = document.createElement("span");
        shadowSize.className = "fishSizeSpan";
        shadowSize.appendChild(document.createTextNode(fish.ShadowSize));

        fishBox.appendChild(fishName);
        fishBox.appendChild(document.createElement("br"));
        fishBox.appendChild(fishLocation);
        fishBox.appendChild(document.createElement("br"));
        fishBox.appendChild(fishPrice);
        fishBox.appendChild(document.createElement("br"));
        fishBox.appendChild(fishRarity);
        fishBox.appendChild(document.createElement("br"));
        fishBox.appendChild(shadowSize);

        fishTd.appendChild(fishBoxLink);
        fishCount++;
    });
};


function loadFishTable(GetFishURL) {
    $.ajax({
        cache: false,
        type: "GET",
        async: false,
        url: GetFishURL,
        dataType: "json",
        success: function (fish) {
            buildFishTable(fish.$values);
            $('#allFish').jshowoff({ autoPlay: false, links: false, effect: 'slideLeft', cssClass: 'fishTable', changeSpeed: 1000 });
        }
    });

}