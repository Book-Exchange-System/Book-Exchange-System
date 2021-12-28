$(".wrapper-menu").click(function () {
    $("#sidebar").toggleClass("clicked");
    return false;
});
//Slider Cars
$num = $('.slider-card').length;
$even = $num / 2;
$odd = ($num + 1) / 2;
$slide = $('.active').width();
if ($num % 2 == 0) {
    $('.slider-card:nth-child(' + $even + ')').addClass('active');
    $('.slider-card:nth-child(' + $even + ')').prev().addClass('prev');
    $('.slider-card:nth-child(' + $even + ')').prev().prev().addClass('tempprev');
    $('.slider-card:nth-child(' + $even + ')').prev().prev().prev().addClass('tempprev-2');
    $('.slider-card:nth-child(' + $even + ')').next().addClass('next');
    $('.slider-card:nth-child(' + $even + ')').next().next().addClass('tempnext');
    $('.slider-card:nth-child(' + $even + ')').next().next().next().addClass('tempnext-2');
} else {
    $('.slider-card:nth-child(' + $odd + ')').addClass('active');
    $('.slider-card:nth-child(' + $odd + ')').prev().addClass('prev');
    $('.slider-card:nth-child(' + $odd + ')').prev().prev().addClass('tempprev');
    $('.slider-card:nth-child(' + $odd + ')').prev().prev().prev().addClass('tempprev-2');
    $('.slider-card:nth-child(' + $odd + ')').next().addClass('next');
    $('.slider-card:nth-child(' + $odd + ')').next().next().addClass('tempnext');
    $('.slider-card:nth-child(' + $odd + ')').next().next().next().addClass('tempnext-2');
}
$('.slider-card').click(function () {
    $slide = $('.active').width();
    if ($(this).hasClass('next')) {
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide) });
    } else if ($(this).hasClass('prev')) {
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
    } else if ($(this).hasClass('tempprev')) {
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
    } else if ($(this).hasClass('tempnext')) {
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide) });
    }
    else if ($(this).hasClass('tempnext-2')) {
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide ) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide ) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '-=' + ($slide) });
    } else if ($(this).hasClass('tempprev-2')) {
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
        $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
        $(this).siblings().removeClass('prev tempprev tempnext tempnext-2 tempprev-2 active next');

        $(this).addClass('active');
        $(this).prev().addClass('prev');
        $(this).prev().prev().addClass('tempprev');
        $(this).prev().prev().prev().addClass('tempprev-2');
        $(this).next().addClass('next');
        $(this).next().next().addClass('tempnext');
        $(this).next().next().next().addClass('tempnext-2');
        $('.card-carousel').stop(false, true).animate({ left: '+=' + ($slide) });
    }

    $(this).removeClass('prev next tempnext tempprev tempnext-2 tempprev-2');
    $(this).siblings().removeClass('prev tempprev tempprev-2 tempnext tempnext-2 active next');

    $(this).addClass('active');
    $(this).prev().addClass('prev');
    $(this).prev().prev().addClass('tempprev');
    $(this).prev().prev().prev().addClass('tempprev-2');
    $(this).next().addClass('next');
    $(this).next().next().addClass('tempnext');
    $(this).next().next().next().addClass('tempnext-2');
});
$('.slick-track').slick({
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 1000,
    responsive: [
        {
            breakpoint: 1200,
            settings: {
                slidesToShow: 2,
            }
        },
        {
            breakpoint: 800,
            settings: {
                slidesToShow: 1,
            }
        }
    ]
});
$('.similar-slider').slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 1200,
    responsive: [
        {
            breakpoint: 1200,
            settings: {
                slidesToShow: 3,
            }
        },
        {
            breakpoint: 900,
            settings: {
                slidesToShow: 2,
            }
        }
        ,
        {
            breakpoint: 700,
            settings: {
                slidesToShow: 1,
            }
        }
    ]
});
$("#sub-menu-1").click(function () {
    $("#sub-menu-items-1").toggleClass("clicked");
    return false;
});
$('.phoneNumber').mask('(000) 000 00 00');