"use strict";
$(document).ready(function () {
    // card js start
    $(".card-header-right .close-card").on('click', function () {
        var $this = $(this);
        $this.parents('.card').animate({
            'opacity': '0',
            '-webkit-transform': 'scale3d(.3, .3, .3)',
            'transform': 'scale3d(.3, .3, .3)'
        });

        setTimeout(function () {
            $this.parents('.card').remove();
        }, 800);
    });
    $(".card-header-right .reload-card").on('click', function () {
        var $this = $(this);
        $this.parents('.card').addClass("card-load");
        $this.parents('.card').append('<div class="card-loader"><i class="fa fa-spinner rotate-refresh"></div>');
        setTimeout(function () {
            $this.parents('.card').children(".card-loader").remove();
            $this.parents('.card').removeClass("card-load");
        }, 3000);
    });
    $(".card-header-right .card-option .fa-chevron-left").on('click', function () {
        var $this = $(this);
        if ($this.hasClass('fa-chevron-right')) {
            $this.parents('.card-option').animate({
                'width': '35px',
            });
        } else {
            $this.parents('.card-option').animate({
                'width': '180px',
            });
        }
        $(this).toggleClass("fa-chevron-right").fadeIn('slow');
    });
    $(".card-header-right .minimize-card").on('click', function () {
        var $this = $(this);
        var port = $($this.parents('.card'));
        var card = $(port).children('.card-block').slideToggle();
        $(this).toggleClass("fa-minus").fadeIn('slow');
        $(this).toggleClass("fa-plus").fadeIn('slow');
    });
    $(".card-header-right .full-card").on('click', function () {
        var $this = $(this);
        var port = $($this.parents('.card'));
        port.toggleClass("full-card");
        $(this).toggleClass("fa-window-restore");
    });

    $(".card-header-right .icofont-spinner-alt-5").on('mouseenter mouseleave', function () {
        $(this).toggleClass("rotate-refresh").fadeIn('slow');
    });
    $("#more-details").on('click', function () {
        $(".more-details").slideToggle(500);
    });
    $(".mobile-options").on('click', function () {
        $(".navbar-container .nav-right").slideToggle('slow');
    });
    $(".search-btn").on('click', function () {
        $(".main-search").addClass('open');_
        $('.form-control').animate({
            'width': '200px',
        });
    });
    $(".search-close").on('click', function () {
        $('.main-search .form-control').animate({
            'width': '0',
        });
        setTimeout(function () {
            $(".main-search").removeClass('open');
        }, 300);
    });
    $(".header-notification").on('click', function () {
        $(this).children('.show-notification').slideToggle(500);
        $(this).toggleClass('active');

    });
    // card js end
    $(".main-menu").mCustomScrollbar({
        setTop: "1px",
        setHeight: "calc(100% - 90px)",
    });

    /*chatbar js start*/
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })

//});

//$(document).ready(function () {
    $(".theme-loader").animate({
        opacity: "0"
    }, 1000);

    setTimeout(function () {
        $(".theme-loader").remove();
    }, 800);


});


function _loader(f) {
    if (f) {
        $(".loader").addClass("is-active");
    } else {
        $(".loader").removeClass("is-active");
    }
    //setTimeout(function () {
    //    _loader();
    //}, 10000);
}

function _loaderT(f) {
    if (f) {
        $('.tb-card').addClass("card-load");
        $('.tb-card').append('<div class="card-loader"><i class="fa fa-spinner rotate-refresh"></div>');
    } else {
        setTimeout(function () {
            $('.tb-card').children(".card-loader").remove();
            $('.tb-card').removeClass("card-load");
        }, 200);
    }
}

function _colStatus(s) {
    var st = '<span class="label label-danger">Disabled</span>';
    if (s == 1) {
        st = '<span class="label label-success">Active</span>';
    } else if (s == 2) {
        st = '<span class="label label-warning">Wait Approve</span>';
    } else if (s == 3) {
        st = '<span class="label label-danger">Rejected</span>';
    }
    return st;
}


function _colStatusV(s) {
    var st = '<span class="label label-danger">Cancel</span>';
    if (s == 1) {
        st = '<span class="label label-success">Approve</span>';
    } else if (s == 2) {
        st = '<span class="label label-warning">Wait Approve</span>';
    } else if (s == 3) {
        st = '<span class="label label-inverse">Rejected</span>';
    }
    return st;
}



function _colStatusP(s) {
    var st = '<span class="label label-danger">Cancel</span>';
    if (s == 1) {
        st = '<span class="label label-info">Active</span>';
    } else if (s == 2) {
        st = '<span class="label label-success">Release</span>';
    } else if (s == 3) {
        st = '<span class="label label-inverse">Rejected</span>';
    }
    return st;
}

function _colStatusDoc(s) {
    var st = '<span class="label label-danger">Cancel</span>';
    if (s == 0) {
        st = '<span class="label label-info">Drafted</span>';
    }else if (s == 1) {
        st = '<span class="label label-primary">Submitted</span>';
    } else if (s == 2) {
        st = '<span class="label label-warning">GR Created</span>';
    } else if (s == 3) {
        st = '<span class="label label-success">Received</span>';
    }
    return st;
}


// toggle full screen
function toggleFullScreen() {
    var a = $(window).height() - 10;

    if (!document.fullscreenElement && // alternative standard method
        !document.mozFullScreenElement && !document.webkitFullscreenElement) { // current working methods
        if (document.documentElement.requestFullscreen) {
            document.documentElement.requestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) {
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullscreen) {
            document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
        }
    } else {
        if (document.cancelFullScreen) {
            document.cancelFullScreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitCancelFullScreen) {
            document.webkitCancelFullScreen();
        }
    }
}

var $window = $(window);
var nav = $('.fixed-button');
$window.scroll(function () {
    if ($window.scrollTop() >= 200) {
        nav.addClass('active');
    }
    else {
        nav.removeClass('active');
    }
});
