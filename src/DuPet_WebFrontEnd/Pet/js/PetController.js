// CONTROLES DE INTERAÇÃO DA PÁGINA

$("document").ready(function(){
  $(".tab-slider--body").hide();
  $(".tab-slider--body:first").show();
});

$(".tab-slider--nav li").click(function() {
  $(".tab-slider--body").hide();
  var activeTab = $(this).attr("rel");
  $("#"+activeTab).fadeIn();
    if($(this).attr("rel") == "vacinasVermifugos"){
        $('.tab-slider--tabs').addClass('slide');
    }else{
        $('.tab-slider--tabs').removeClass('slide');
    }
  $(".tab-slider--nav li").removeClass("active");
  $(this).addClass("active");
});


const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwicm9sZSI6IkFkbWluaXN0cmFkb3IiLCJuYmYiOjE2Njk1ODExNjksImV4cCI6MTY2OTYwOTk2OSwiaWF0IjoxNjY5NTgxMTY5fQ.MOe4vM6Cw6iQb1mHY6kOWa6V1Dy-XysYdqiYr9bCimg"



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
            var d = new Date(data.dataDeNascimento);
            $("#pet_id").val(data.id),            
            $("#pet_nome").val(data.nome),
            $("#pet_peso").val(data.peso),
            $("#pet_raca").val(data.raca),
            $("#pet_sexo").val(data.sexo),
            $("#pet_pelagem").val(data.pelagem),
            $("#pet_dtnascimento").val(d.toLocaleDateString())
            console.log("Pet listado com sucesso" + data);
        },
        error: function () {
            console.log("Erro a listar dados do Pet!")
        }
    });
  }

  function converterData(data) {
    d = new Date(data);
    dt=d.getDate();
    mn=d.getMonth();
    mn++;
    yy=d.getFullYear();

    $("pet_dtnascimento").val(dt+"/"+mn+"/"+yy)
  }

  function editarPet(petId) {
    var dataNasc = $("#pet_dtnascimento").val()
    var d = new Date(dataNasc)
    console.log(dataNasc)
    $.ajax({
        type: "PUT",
        url: `https://localhost:7061/api/Pets/${petId}`,   
        contentType : "application/json",   
        dataType: "json",  
        headers: {
            'Authorization': `Bearer ${token}`
        },
        data: JSON.stringify({
          id: petId,
          nome: $("#pet_nome").val(),
          peso: $("#pet_peso").val(),
          raca: $("#pet_raca").val(),
          sexo: $("#pet_sexo").val(),
          pelagem: $("#pet_pelagem").val(),
          dataDeNascimento: d.toJSON()
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



  function listarPetsDoUsuario(usuarioId) {
    $.ajax({
        type: "GET",
        url: `https://localhost:7061/api/Pets/usuarios/${usuarioId}`,   
        contentType : "application/json",     
        headers: {
            'Authorization': `Bearer ${token}`
        },
        success: function criarGridPets(data) {
            console.log("Pet listado com sucesso" + data);
            if (data == null || data.length == 0) {
                $("#grid_pets").css("justify-content", "center")
                $("#grid_pets").append(
                    `<div id="" style="display: flex; flex-direction: column; align-items: center;">
                        <p id="pet_nome">Nenhum pet foi adicionado ainda :(</p>
                        <img id="" src="https://t4.ftcdn.net/jpg/04/95/36/11/360_F_495361138_QocGCS4Q9p8hFNRqZMTYXaJbA2s2po9C.jpg" alt=""">                    
                    </div>`
                    )
            }
            else{
                data.pets.forEach(element => {
                    $("#grid_pets").append(
                        `<div id="pet_card" onClick="visualizarDetalhesDoPet(${element.petId})" class="" data-bs-toggle="modal" data-bs-target="#cadastroPet">
                            <img id="pet_photo" src="https://post.medicalnewstoday.com/wp-content/uploads/sites/3/2020/02/322868_1100-800x825.jpg" alt=""">
                            <p id="pet_nome_card">${element.pet.nome}</p>
                        </div>`
                        )                    
                    console.log(element.nome);
                });
            }                
        },
        error: function () {
            console.log("Erro a listar dados do Pet!")
        }
    });
  }
  

// Funções Auxiliares

function adicionarEditarPet(idPet) {
    if (idPet == null || idPet == undefined || idPet == 0) {
        adicionarPet()
    }
    else{
        editarPet(idPet)
    }    
  }

  function limparFormulario() {
    document.getElementById("pet_formulario").reset();
  }



 