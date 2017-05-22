<!DOCTYPE html>
<html>
<head>
<title>Facebook Login JavaScript Example</title>
<meta charset="UTF-8">
</head>
<body>
<script>
  function statusChangeCallback(response) {
    console.log('statusChangeCallback');
    console.log(response);
    if (response.status === 'connected') {
      // Logged into your app and Facebook.
      testAPI();
    }
  }
  function checkLoginState() {
    FB.getLoginStatus(function(response) {
      statusChangeCallback(response);
    });
  }
  window.fbAsyncInit = function() {
  FB.init({
    appId      : '1836667879988026',
    cookie     : true,  // enable cookies to allow the server to access 
                        // the session
    xfbml      : true,  // parse social plugins on this page
    version    : 'v2.8' // use graph api version 2.8
  });
  FB.getLoginStatus(function(response) {
    statusChangeCallback(response);
  });

  };

  (function(d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
  }(document, 'script', 'facebook-jssdk'));

  function testAPI() {
    FB.api('/me?fields=name,email', function(response) {
      document.getElementById('status').innerHTML =
        'Thanks for logging in, ' + response.name + '!'+response.id+'!';
      document.getElementById("nameh").value = ""+response.name;
    });
  }

</script>
<h1><script>testAPI1();</script></h1>
<div id="status">
</div>
<input type ="hidden" id = "nameh" value = "hello">
</body>
</html>