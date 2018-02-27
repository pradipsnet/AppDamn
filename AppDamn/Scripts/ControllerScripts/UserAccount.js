$(document).ready(function () {
    alert("hello");
        $.ajax({
            type: "GET",
            url: "/UserAccount/GetProfessionDetails",
            data: '{}',
            contenttype: "",
            datatype: "",
            success: function (response) {
                ////alert("About");
                //if (response = false) {
                //    $('yourSpanSelector').text(message); // display the error message in the span tag
                //} else {
                //    window.location.href = '/Home/RegisteredUser' // redirect to another page
                //}
            },
            failure: function (response) { },
            error: function (response) { }

        });

        $("#btnRegisterUser").click(function () {
            alert("bro");
        $.ajax({
            type: "POST",
            url: "/UserAccount/RegisterNewUser",
            data: '{}',
            contenttype: "",
            datatype: "",
            success: function (response) {
                ////alert("About");
                //if (response = false) {
                //    $('yourSpanSelector').text(message); // display the error message in the span tag
                //} else {
                //    window.location.href = '/Home/RegisteredUser' // redirect to another page
                //}
            },
            failure: function (response) { },
            error: function (response) { }

        });

    });

});