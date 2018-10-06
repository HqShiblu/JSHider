$(document).ready(function () {
    var down = true;

    $(".clickButton").click(function () {
        if (down) {
            $(".myDiv").slideUp();
            down = false;
            return;
        }
        $(".myDiv").slideDown();
        down = true;
    });

});
