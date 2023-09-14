/*tslint:disabled*/
//async function Get_value_category() {
//    const address = fetch("https://jsonplaceholder.typicode.com/users/1")
//        .then((response) => response.json())
//        .then((user) => {
//            return user.address;
//        });
//}


async function getvaluebyid(id) {
    var response = await fetch("https://localhost:5002/api/category/FindId?id=" + id)
    var data = await response.json();
    return data.categoryName;
}

async function getlistproducts() {
    var response = await fetch("https://localhost:5002/api/Product/")
    let data = await response.json();
    return data;
}

async function preenche_tabela() {
    let data_products_list = await getlistproducts();

    size_product_list = Object.keys(await getlistproducts()).length;
  //  console.log(getvaluebyid(1));


    

    data_products_list.forEach((values,key) => {
        getvaluebyid(values.fK_Category).then(value => {
            console.log(values.productName, value);
            $('#seletor').append('<tr> <td> ' + values.productName + '</td> <td>                                   </td>  <td> ' + value + '</td>  </tr>');

        })
    //    console.log("key:" + values.productName + "value:" + values.fK_Category);
    });
        
  
    //    const numFruit = await getNumFruit(fruit)
    //    console.log(numFruit)
    //})


}

   // let key = length

    //fruitsToGet.forEach(async fruit => {
    //    const numFruit = await getNumFruit(fruit)
    //    console.log(numFruit)
    //})

    //for (let x;x < size_product_list; x++) {

    //}
    //  //      let nome_categoria = await getlistproducts(value.FK_Category);
    //        console.log(resultado);
    //    }
    //Object.entries(data_products_list)

    //Object.entries(data_products_list).forEach(([key, value]) => {
    //    let nome_categoria = await getlistproducts(value.FK_Category);

    //    $('#seletor').append('<tr> <td> ' + value.productName + '</td>  <td> ' + nome_categoria + '</td>  </tr>');
    //      }
    // )

 
//preenche_tabela();
     //Utilizei dessa forma pois meu navegador estava com erros para tratar alguns parâmetros json



//let data_prod = await response.json();


//$('#seletor').append('<tr> <td> ' + name_categoria.categoryName + '</td>  <td> ' + name_categoria + '</td>  </tr>'); //Utilizei dessa forma pois meu navegador estava com erros para tratar alguns parâmetros json


//console.log(retorno); 
//console.log(namecategory);
//  console.log(data[key].categoryName);
//  $('#seletor').append('<tr> <td> ' + data[key].categoryName + '</td> </tr>'); //Utilizei dessa forma pois meu navegador estava com erros para tratar alguns parâmetros json

// $('#categoria_modal').append('<option value="' + data[key].id + '">' + data[key].categoryName + ' </option>');











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

