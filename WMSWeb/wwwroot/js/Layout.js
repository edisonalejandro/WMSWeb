$(document).ready(function () {
    $('.submenu li:has(ul)').click(function (e) {
        e.preventDefault();

        if ($(this).hasClass('activado')) {
            $('.container-menu .submenu').css({ 'display': 'block' });
            $(this).removeClass('activado')
            $(this).children('ul').slideUp();
        } else {
            $('.submenu li ul').slideUp();
            $('.submenu li').removeClass('activado');
            $(this).addClass('activado');
            $(this).children('ul').slideDown();
            $('.container-menu .submenu').css({ 'display': 'block' });
            $('.container-menu .submenu ul li a').css({ 'display': 'block' });
        }
    });

    $('.btn-menu').click(function () {
        $('.container-menu .submenu').slideToggle();
    });

    $(window).resize(function () {
        if ($(document).width() > 450) {
            $('.container-menu .submenu').css({ 'display': 'block' });
        }

        if ($(document).width() < 450) {
            $('.container-menu .submenu').css({ 'display': 'block' });
            $('.menu li ul').slideUp();
            $('.menu li').removeClasss('activado');
        }
    });

    $('.submenu li ul li a').click(function () {
        window.location.href = $(this).attr("href");
    });
});