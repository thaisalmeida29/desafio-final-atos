// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function pesquisacep() {
    var cep = document.getElementById('Cep').value.replace(/\D/g, '');

    if (cep != "") {

        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {
            const url = 'https://viacep.com.br/ws/' + cep + '/json/';
            fetch(url)
                .then(response => response.json())
                .then(json => {
                    if (json.logradouro) {
                        document.getElementById('endereco').value = json.logradouro;
                        document.getElementById('bairro').value = json.bairro;
                        document.getElementById('cidade').value = json.localidade;
                        document.getElementById('estado').value = json.uf;
                        
                    } else {
                        alert("CEP NÃO ENCONTRADO")
                    }
                })
        } else {
            alert("CEP INVÁLIDO")
        }
    }
}

// Atualizar preço total do item venda
setInterval(() => {
    var itemVendaPrecoTotal = document.getElementById('itemVendaPrecoTotal');
    if (itemVendaPrecoTotal != null) {
        var itemVendaPrecoUnitario = document.getElementById('itemVendaPrecoUnitario');
        var itemVendaQuantidade = document.getElementById('itemVendaQuantidade');
        if (itemVendaPrecoUnitario.value != '' && itemVendaQuantidade.value != '') {
            itemVendaPrecoTotal.value = parseInt(itemVendaPrecoUnitario.value) * parseInt(itemVendaQuantidade.value);
        }
    }
}, 500)




$(document).ready(function () {
    $('#tabela').DataTable();
});

