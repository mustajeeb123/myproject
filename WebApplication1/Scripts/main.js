$(document).ready(function()
{

    $("#btn").click(function()
    {
       
        var city = {
            "CityName": $("#txtName").val()
            
        }

        $.ajax(
            {
                type: "POST",
                url: "savedata",
                data: JSON.stringify(city),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
              
            });


    });
});