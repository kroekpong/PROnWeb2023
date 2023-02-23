'use strict';

function notify(message, type, align) {
    $.growl({
        message: message
    }, {
        type: type,
        allow_dismiss: false,
        //label: 'Cancel',
        className: 'btn-xs btn-success',
        placement: {
            from: 'top',
            align: align ? align : 'right'
        },
        delay: 1500,
        animate: {
            enter: 'animated bounceIn',
            exit: 'animated bounceOut'
        },
        offset: {
            x: 30,
            y: 30
        }
    });

    $(".loader").removeClass("is-active");
};


function noti(t,l) {
    if (t == 'S') {
        notify('Save Successfully !', 'success');
    }else if (t == 'D') {
        notify('Delete Successfully !', 'success');
    }
};

