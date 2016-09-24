$(document).ready(function () {
    $(".KlickEvent").click(function () {
        $(this).siblings(".AttToggla").slideToggle("fast");
    });

});