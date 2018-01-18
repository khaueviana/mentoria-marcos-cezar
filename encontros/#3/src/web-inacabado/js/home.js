$('.painel').addClass('painel-compacto');

$('novidades button').click(function(){
    if($('novidades .painel-compacto li:nth-child(n+7)').css('display') == 'none'){
        $('novidades .painel-compacto li:nth-child(n+7)').css({'display':'inline-block'})
        $('button').text('mostrar menos');
    }
    else if($('novidades .painel-compacto li:nth-child(n+7)').css('display') != 'none'){  
        $('novidades .painel-compacto li:nth-child(n+7)').css({'display':'none'})      
        $('novidades button').text('mostrar mais');
    }
});
