/*tslint:disabled*/

async function fetchData() {
    const response = await fetch("https://localhost:5002/api/Category/");
    let data = await response.json();


    Object.entries(data).forEach(([key, value]) => {
        //  console.log(data[key].categoryName);
        $('#seletor').append('<tr> <td> ' + data[key].categoryName + '</td> </tr>'); //Utilizei dessa forma pois meu navegador estava com erros para tratar alguns parâmetros json
        $('#categoria_modal').append('<option value="' + data[key].id + '">' + data[key].categoryName + ' </option>');
    })



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





fetchData();

