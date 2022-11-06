// CONTROLES DE INTERAÇÃO DA PÁGINA

$("document").ready(function(){
  $(".tab-slider--body").hide();
  $(".tab-slider--body:first").show();
});

$(".tab-slider--nav li").click(function() {
  $(".tab-slider--body").hide();
  var activeTab = $(this).attr("rel");
  $("#"+activeTab).fadeIn();
    if($(this).attr("rel") == "tab2"){
        $('.tab-slider--tabs').addClass('slide');
    }else{
        $('.tab-slider--tabs').removeClass('slide');
    }
  $(".tab-slider--nav li").removeClass("active");
  $(this).addClass("active");
});


const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwicm9sZSI6IkFkbWluaXN0cmFkb3IiLCJuYmYiOjE2Njc3MDM5OTYsImV4cCI6MTY2NzczMjc5NiwiaWF0IjoxNjY3NzAzOTk2fQ.Z6n_pyMyftGwB5s36PhIw6pzZ9ZSADoZZIQxH4Vqnxk"



// ROTAS DA API PETS

  function autenticarUsuario(idUsuario, senha) {
    $.ajax({
        method : "POST",
        url : `https://localhost:7061/api/Usuarios/autenticacao`,
        contentType : "application/json",
        data : JSON.stringify({
            id: idUsuario, 
            senha: senha
        }),
        success: function (data) {
            console.log("Usuário autenticado com sucesso" + data);
        },
        error: function () {
            console.log("Erro ao autenticar usuário")
        }
    });
  }

  function adicionarPet() {
    $.ajax({
        type: "POST",
        url: `https://localhost:7061/api/Pets/`,   
        contentType : "application/json",   
        dataType: "json",  
        headers: {
            'Authorization': `Bearer ${token}`
        },
        data: JSON.stringify({
          nome: $("#pet_nome").val(),
          peso: $("#pet_peso").val(),
          raca: $("#pet_raca").val(),
          sexo: $("#pet_sexo").val(),
          pelagem: $("#pet_pelagem").val(),
          dataDeNascimento: $("#pet_dtnascimento").val()
        }),
        success: function (data) {
            console.log(data + "Pet Criado Com sucesso" + data);
        },
        error: function () {
            console.log("Erro ao adicionar Pet!")
        }
    });
  }

  function visualizarDetalhesDoPet(petId) {
    $.ajax({
        type: "GET",
        url: `https://localhost:7061/api/Pets/${petId}`,   
        contentType : "application/json",     
        headers: {
            'Authorization': `Bearer ${token}`
        },
        success: function (data) {
            console.log("Pet listado com sucesso" + data);
        },
        error: function () {
            console.log("Erro a listar dados do Pet!")
        }
    });
  }

  function editarPet() {
    $.ajax({
        type: "PUT",
        url: `https://localhost:7061/api/Pets/`,   
        contentType : "application/json",   
        dataType: "json",  
        headers: {
            'Authorization': `Bearer ${token}`
        },
        data: JSON.stringify({
          nome: $("#pet_nome").val(),
          peso: $("#pet_peso").val(),
          raca: $("#pet_raca").val(),
          sexo: $("#pet_sexo").val(),
          pelagem: $("#pet_pelagem").val(),
          dataDeNascimento: $("#pet_dtnascimento").val()
        }),
        success: function (data) {
            console.log(data + "Pet Editado Com sucesso" + data);
        },
        error: function () {
            console.log("Erro a salvar alterações no registro do Pet!")
        }
    });
  }

  function removerPet(petId) {
    $.ajax({
        type: "DELETE",
        url: `https://localhost:7061/api/Pets/${petId}`,   
        contentType : "application/json",     
        headers: {
            'Authorization': `Bearer ${token}`
        },
        success: function (data) {
            console.log("Pet removido com sucesso");
        },
        error: function () {
            console.log("Erro ao remover Pet!")
        }
    });
  }

    // function autenticarUsuarioteste() {
    //     const data = { id: 1, senha: 'teste123' };
    //     fetch('https://localhost:7061/api/Usuarios/autenticacao', {
    //         method: 'POST', // or 'PUT'
    //         headers: {
    //             'Content-Type': 'application/json',
    //         },
    //         body: JSON.stringify(data),
    //         })
    //     .then((response) => response.json())
    //     .then((data) => {
    //         console.log('Success:', data);
    //     })
    //     .catch((error) => {
    //         console.error('Error:', error);
    //     });
    // }



 