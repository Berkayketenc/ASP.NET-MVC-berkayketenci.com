$(document).ready(function () {

    $('#DeveloperS').click(function () {
        $('#DeveloperSDiv').show();
        $('#YönetimSDiv').hide();
        $('#PazarlamaSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('#ToplulukSDiv').hide();
        
    });
    $('#PazarlamaS').click(function () {
        $('#PazarlamaSDiv').show();
        $('#YönetimSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('#ToplulukSDiv').hide();
        

    });
    $('#YönetimS').click(function () {
        $('#YönetimSDiv').show();
        $('#PazarlamaSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('#ToplulukSDiv').hide();

    });
    $('#IKS').click(function () {
        $('#IKSDiv').show();
        $('#PazarlamaSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#KISISDiv').hide();
        $('#YönetimSDiv').hide();
        $('#ToplulukSDiv').hide();

    });
   
    $('#KISIS').click(function () {
        $('#KISISDiv').show();
        $('#YönetimSDiv').hide();
        $('#PazarlamaSDiv').hide();
        $('#IKSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#ToplulukSDiv').hide();

    });
    $('ToplulukS').click(function () {
        $('#ToplulukSDiv').show();
        $('#YönetimSDiv').hide();
        $('#PazarlamaSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('DeveloperSDiv').hide();

    });
})

$('.service-catergory li').on('click', function () {

    $('li').removeClass('active');
    $(this).addClass('active');

});