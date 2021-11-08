$(".wrapper-menu").click(function () {
    $("#sidebar").toggleClass("clicked");
    $("#content-page").toggleClass("clicked");
    return false;
});