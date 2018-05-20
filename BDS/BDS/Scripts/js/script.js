$('#hien-mk').on('click',function () {
var passInput=$('#password-signup').attr('type');			
	if (passInput == 'password') {
		$('#password-signup').attr('type', 'text');
	}
	if (passInput == 'text') {
		$('#password-signup').attr('type', 'password');
	}
});

$('.taotaikhoan').on('click', function(){
	$('#sign-in').modal('hide');
	setTimeout(function(){
		$('#sign-up').modal('show');}, 500);	
});









window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}




       
        


