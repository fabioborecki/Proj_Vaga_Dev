function changePlaceholder() {
    
        if ($("#newprod_cat_modal").val() == 0) {
            $('#cat_new_or_change').attr('placeholder', 'Nome da Categoria');
            $('#btn_delete_cat').attr('type', 'hidden');
            $('#btn_create_update_cat').attr('value', 'Criar');
        }
        else {
            $('#cat_new_or_change').attr('placeholder', 'Novo nome');
            $('#btn_delete_cat').attr('type', 'button');
            $('#btn_create_update_cat').attr('value', 'Atualizar');
        }

    
}
async function getvaluebyid(id) {
    var response = await fetch("https://localhost:5002/api/category/FindId?id=" + id)
    var data = await response.json();
    return data.categoryName;
}

async function modal_getcategoryvalue() {
    var response = await fetch("https://localhost:5002/api/category/");
    var data = await response.json();
    data.forEach((values) => {

        $('#categoria_modal').append('<option value="' + values.id + '">' + values.categoryName + ' </option>');
        $('#newprod_cat_modal').append('<option value="' + values.id + '">' + values.categoryName + ' </option>');

        
        }
    )
 
}


async function getlistproducts() {
    var response = await fetch("https://localhost:5002/api/Product/")
    let data = await response.json();
    return data;
}

async function preenche_tabela() {
    let data_products_list = await getlistproducts();

    data_products_list.forEach((values) => {

        getvaluebyid(values.fK_Category).then(value => {
            let btn_function = ('<td> <a href="#editProductModal"  data-toggle="modal"> <i class="material-symbols-outlined"> edit </i >  </a> </td> ');
            let name_tdbodytable = ('<td> <input type="checkbox" value = " ' + values.id + '"/> </td> <td style="width:400px">' + values.productName + '</td>');
            let category_tdbodytable = ('<td >' + value + '</td>');

            $('#seletor').append('<tr>' + name_tdbodytable + category_tdbodytable +'<td style="width:380px"> </td>'+ btn_function + '</tr>');





        }
        )

    });
}


function removeproduct(event) {

        var inputs = document.querySelectorAll('input[type="checkbox"]:checked');

        for (var i = 0; i < inputs.length; i++) {
            if (inputs[i].checked == true) { //segunda validação p confirmar rs
                jsonremove(inputs[i].value);
            }
        }
    }


function jsonremove(id) {
    var formData = {
        id: id
    }
    $.ajax({
        type: "DELETE",
        dataType: "Delete",
        contentType: "application/json ; charset= UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:5002/api/Product/remove",
        sucess: function (result) {
            window.location.reload();
        },
        error: function (error) { }

    })
}

function jsonadd(formData) {

    $.ajax({
        type: "POST",
        dataType: "Post",
        contentType: "application/json ; charset= UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:5002/api/Product/create",
        sucess: function (result) {
     
        },
        error: function (error) { }

    })
}


    function addproduto(event) {
        
        var formData = {
            ProductName: $("#nomeproduto").val(),
            FK_Category: $("#categoria_modal").val()
        }
        jsonadd(formData);
        window.location.reload();
    }





preenche_tabela();
modal_getcategoryvalue();
