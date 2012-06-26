$(function() {
    $("#clickme").click(function(e) {
        e.preventDefault();
        $.get(routes.version_url, function(result) {
            alert("Version = " + result.version);
        });
    });
});