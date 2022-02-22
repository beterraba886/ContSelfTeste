// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("input").prop('required',true);
$("textarea").prop('required',true);

var texto = $(".atividade");
var limite = 150;

//var resultado = text.slice(0, count) + (texto.length > count ? "..." : "");
var salario = $('.salario');
salario.each((index)=>{
    //console.log(texto[index].innerText.length);

    texto[index].innerText = texto[index].innerText.slice(0, limite) + (texto[index].innerText.length > limite ? "..." : "");
    salario[index].innerText += " R$";
});


