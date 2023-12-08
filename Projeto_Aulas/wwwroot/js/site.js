var parametros = new URLSearchParams(window.location.search);
var acaoDoBotao = parametros.get("botao");
if (acaoDoBotao == "relatorio")
{
    window.print();
}