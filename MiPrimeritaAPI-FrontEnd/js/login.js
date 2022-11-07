$(document).ready(function(){
    $("#btn-login").click(function(){
        let User = $("#username").val().trim();
        let Password = $("#pwd").val().trim();

        console.log(User);

        if( User != "" && Password != "" ){
            $.ajax({
                url: 'https://localhost:44367/User/Login',
                type:'post',
                data:JSON.stringify({user:User,password:Password}),
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
    $("#btn-register").click(function(){
        window.location = "register.html";
    });
});