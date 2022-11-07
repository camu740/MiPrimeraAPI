$(document).ready(function(){
    $.ajax({
        url:'https://localhost:44367/Alumno/All',
        type:'get',
        contentType:"application/json; charset=utf-8",
        success:function(response){
            let alumnos = response
            alumnos.forEach(alumno => {
                console.log(alumno)
                $("#alumnos").append('<li>' + alumno.nombre + '</li>');
            });
            
        },
        error:function(){            
            alert("error")
        }
    });
});

$(document).ready(function(){
    $("#btn-insert").click(function(){
        window.location = "insert.html";
    });
});

$(document).ready(function(){
    $("#btn-update").click(function(){
        window.location = "update.html";
    });
});

$(document).ready(function(){
    $("#btn-delete").click(function(){
        window.location = "delete.html";
    });
});