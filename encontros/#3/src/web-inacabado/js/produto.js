/*$('#tamanho').change(function(){
    var tamanho = $('#tamanho').val();
    var trocar = $(".tamanhos output").val(tamanho);
});*/

$('[name=tamanho').on('input',function(){
    $('[name=valortamanho]').val(this.value);
})