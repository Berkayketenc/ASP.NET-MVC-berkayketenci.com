$(document).ready(function () {

    $('#DeveloperS').click(function () {
        $('#DeveloperSDiv').show();
        $('#Y�netimSDiv').hide();
        $('#PazarlamaSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('#ToplulukSDiv').hide();
        
    });
    $('#PazarlamaS').click(function () {
        $('#PazarlamaSDiv').show();
        $('#Y�netimSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#IKSDiv').hide();
        $('#KISISDiv').hide();
        $('#ToplulukSDiv').hide();
        

    });
    $('#Y�netimS').click(function () {
        $('#Y�netimSDiv').show();
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
        $('#Y�netimSDiv').hide();
        $('#ToplulukSDiv').hide();

    });
   
    $('#KISIS').click(function () {
        $('#KISISDiv').show();
        $('#Y�netimSDiv').hide();
        $('#PazarlamaSDiv').hide();
        $('#IKSDiv').hide();
        $('#DeveloperSDiv').hide();
        $('#ToplulukSDiv').hide();

    });
    $('ToplulukS').click(function () {
        $('#ToplulukSDiv').show();
        $('#Y�netimSDiv').hide();
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