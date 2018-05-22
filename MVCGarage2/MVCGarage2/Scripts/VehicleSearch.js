$(document).ready(function () {
    $("input[type='submit']").on("click", OnClick);

    $("input[type='text']").on("keyup", OnKeyUp);
    $("input[type='text']").on("keyup", OnChange);
    $("input[type='text']").on("change", OnChange);
    $("select").on("change", OnChange);
});

function OnClick(e) {
    e.preventDefault();

    var url = "/Vehicles/Overview?";
    var first = true;

    if ($("#regnrBox").is(":checked")) {
        url += "Regnr=" + encodeURIComponent($("#Regnr").val())
        first = false;
    }

    if ($("#typeBox").is(":checked")) {
        if (!first) {
            url += "&";
        }
        url += "VehicleOfType=" + encodeURIComponent($("#VehicleOfType").val())
        first = false;
    }

    if ($("#colorBox").is(":checked")) {
        if (!first) {
            url += "&";
        }
        url += "Color=" + encodeURIComponent($("#Color").val())
        first = false;
    }

    if ($("#brandBox").is(":checked")) {
        if (!first) {
            url += "&";
        }
        url += "Brand=" + encodeURIComponent($("#Brand").val())
        first = false;
    }

    if ($("#fuelBox").is(":checked")) {
        if (!first) {
            url += "&";
        }
        url += "FuelType=" + encodeURIComponent($("#FuelType").val())
        first = false;
    }

    window.location.href = url;
}

function OnChange(e) {
    if ($(this).val().trim().length > 0)
        $(this).next().prop('checked', true);
    else
        $(this).next().prop('checked', false);
}

function OnKeyUp() {



    $.ajax(
        {
            url: "/Vehicles/Autocomplete",
            type: "post",
            data:
                {
                    DataName: $(this).id, 
                    text: $(this).val()
                },
            context: this,
            success: function () {
            },
            error: function () {
            }
        });
}