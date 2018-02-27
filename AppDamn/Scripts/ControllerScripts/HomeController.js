$(document).ready(function () {
    alert("dd");
    $("#btnRegister").click(function () {
        alert("ddd");
        $.ajax({
            type: "GET",
            url: "/Home/ValidateUser",
        data:'{}',
        contenttype: "",
        datatype: "",
        success: function (response) {
            //alert("About");
            if (response = false) {
                $('yourSpanSelector').text(message); // display the error message in the span tag
            } else {
                window.location.href = '/Home/RegisteredUser' // redirect to another page
            }
        },
        failure: function (response) { },
        error: function (response) { }

        });

    });
});