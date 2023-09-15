
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

    data_products_list.forEach((values, key) => {
        getvaluebyid(values.fK_Category).then(value => {
            let name_tdbodytable = ('<td>' + values.productName + '</td>');
            let category_tdbodytable = ('<td>' + value + '</td>');
            let checkboxbodytable = ('<td> <input type="checkbox" value = "' + values.id + '"/> </td>');
            $('#seletor').append('<tr>' + name_tdbodytable + category_tdbodytable + checkboxbodytable);





        })

    });
}





    function addproduto(event) {
        event.preventDefault();
        var formData = {
            productname: $("#nomeproduto").val(),
            Category_ID: $("#categoria_modal").val()
        }
        $.ajax({
            type: "POST",
            dataType: "Json",
            contentType: "application/json ; charset= UTF-8",
            data: JSON.stringify(formData),
            url: "https://localhost:5002/api/Product/create",
            sucess: function (result) { },
            error: function (error) { }

        })
    }





preenche_tabela();
modal_getcategoryvalue();
