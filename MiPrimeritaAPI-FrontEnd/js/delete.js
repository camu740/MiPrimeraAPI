$(document).ready(function(){
    $("#btn-delete").click(function(){
        let DNI = $("#dni").val().trim();

        console.log(DNI)

        if( DNI != "" ){
            $.ajax({
                url:'https://localhost:44367/Alumno?DNI='+DNI,
                type:'delete',
                data:JSON.stringify({dni:DNI}),
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