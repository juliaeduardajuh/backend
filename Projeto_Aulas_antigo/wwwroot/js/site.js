var paremetros = new URLSearchParams(window.location.search);
var acaoDoBotao = paremetros.get("botao");
if (acaoDoBotao == "relatorio")
{
    window.print();
}