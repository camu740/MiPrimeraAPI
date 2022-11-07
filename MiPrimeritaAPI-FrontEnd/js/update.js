$(document).ready(function(){
    $("#btn-update").click(function(){
        let Nombre = $("#name").val().trim();
        let DNI = $("#dni").val().trim();
        let PIN = $("#pin").val().trim();

        console.log(Nombre)

        if( Nombre != "" && DNI != "" && PIN != ""){
            $.ajax({
                url:'https://localhost:44367/Alumno',
                type:'put',
                data:JSON.stringify({nombre:Nombre,dni:DNI,pin:PIN}),
                contentType:"application/json; charset=utf-8",
                success:function(response){
                    window.location = "welcome.html";
                },
                error:function(){
                    $("#error").fadeIn();
                }
            });
        }
    });
});

$(document).ready(function(){
    $("#btn-volver").click(function(){
        window.location = "welcome.html";
    });
});