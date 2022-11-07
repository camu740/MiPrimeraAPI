$(document).ready(function(){
    $("#btn-register").click(function(){
        let Email = $("#email").val().trim();
        let Name = $("#username").val().trim();
        let Passwd = $("#pwd").val().trim();
        let Passwd2 = $("#pwd2").val().trim();
        let BirthDate = $("#datebirth").val().trim();

        console.log(Name)

        if( Email != "" && Name != "" && Passwd != "" && Passwd2 == Passwd){
            $.ajax({
                url:'https://localhost:44367/User/Register',
                type:'post',
                data:JSON.stringify({name:Name,email:Email,passwd:Passwd,birthdate:BirthDate}),
                contentType:"application/json; charset=utf-8",
                success:function(response){
                    
                    window.location = "index.html";
                },
                error:function(){
                    $("#error").fadeIn();
                }
            });
        }
    });
});

$(document).ready(function(){
    $("#btn-login").click(function(){
        window.location = "index.html";
    });
});