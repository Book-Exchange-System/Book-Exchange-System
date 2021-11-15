$(".wrapper-menu").click(function () {
    $("#sidebar").toggleClass("clicked");
    return false;
});
//Slider Cars
$num = $('.slider-card').length;
$even = $num / 2;
$odd = ($num + 1) / 2;

if ($num % 2 == 0) {
    $('.slider-card:nth-child(' + $even + ')').addClass('active');
    $('.slider-card:nth-child(' + $even + ')').prev().addClass('prev');
    $('.slider-card:nth-child(' + $even + ')').prev().prev().addClass('tempprev');
    $('.slider-card:nth-child(' + $even + ')').next().addClass('next');
    $('.slider-card:nth-child(' + $even + ')').next().next().addClass('tempnext');
} else {
    $('.slider-card:nth-child(' + $odd + ')').addClass('active');
    $('.slider-card:nth-child(' + $odd + ')').prev().addClass('prev');
    $('.slider-card:nth-child(' + $odd + ')').prev().prev().addClass('tempprev');
    $('.slider-card:nth-child(' + $odd + ')').next().addClass('next');
    $('.slider-card:nth-child(' + $odd + ')').next().next().addClass('tempnext');
}
$('.slider-card').click(function () {
    $slide = $('.active').width();
    console.log($('.active').position().left);

    if ($(this).hasClass('next')) {
        $('.card-carousel').stop(false, true).animate({ left: '-=' + $slide });
    } else if ($(this).hasClass('prev')) {
        $('.card-carousel').stop(false, true).animate({ left: '+=' + $slide });
    } else if ($(this).hasClass('tempprev')) {
        $('.card-carousel').stop(false, true).animate({ left: '+=' + $slide });
        $(this).removeClass('prev next tempnext tempprev');
        $(this).siblings().removeClass('prev tempprev tempnext active next');
        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $('.card-carousel').stop(false, true).animate({ left: '+=' + $slide });
    } else if ($(this).hasClass('tempnext')) {
        $('.card-carousel').stop(false, true).animate({ left: '-=' + $slide });
        $(this).removeClass('prev next tempnext tempprev');
        $(this).siblings().removeClass('prev tempprev tempnext active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $('.card-carousel').stop(false, true).animate({ left: '-=' + $slide });
    }

    $(this).removeClass('prev next tempnext tempprev');
    $(this).siblings().removeClass('prev tempprev tempnext active next');

    $(this).addClass('active');
    $(this).prev().addClass('prev');
    $(this).prev().prev().addClass('tempprev');
    $(this).next().addClass('next');
    $(this).next().next().addClass('tempnext');
});
