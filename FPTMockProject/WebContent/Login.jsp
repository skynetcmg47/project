<%@page import="common.StringProcess"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html" %>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<%@ taglib uri="http://struts.apache.org/tags-tiles" prefix="tiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head lang="en">
<meta charset="UTF-8">
<meta name="google-signin-scope" content="profile email">
<meta name="google-signin-client_id" content="943351996406-91kp8nd573dskbcpn4kc3i88fjquh0hj.apps.googleusercontent.com">
<script src="https://apis.google.com/js/platform.js" async defer></script>
<title>Đăng nhập</title>
<link rel="stylesheet" href="css/bootstrap.min.css" />
<link rel="stylesheet" href="css/custom.css" />
<link rel="stylesheet" href="css/style.css" />
<script src="js/jquery-1.11.2.min.js"></script>
<script src="js/bootstrap.min.js"></script>



</head>
<body>
	<script>
	var isGgClick = false;
	 function onSignIn(googleUser) {
		  var profile = googleUser.getBasicProfile();
		  console.log('ID: ' + profile.getId()); // Do not send to your backend! Use an ID token instead.
		  console.log('Name: ' + profile.getName());
		  console.log('Image URL: ' + profile.getImageUrl());
		  console.log('Email: ' + profile.getEmail()); // This is null if the 'email' scope is not present.
		  document.getElementById("fb_name").value = ""+profile.getName();
	      document.getElementById("fb_id").value = ""+profile.getId();
	      if(isGgClick==true)
		      	document.getElementById('primaryButton').click()();	}
	 function gglogin()
	 {
		isGgClick = true;	 
	 }
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
		      document.getElementById("fb_name").value = ""+response.name;
		      document.getElementById("fb_id").value = ""+response.id;
		    });
	  }
	  function login() {
		  FB.login(function(response) {
				if (response.status === 'connected') {
		    		document.getElementById('status').innerHTML = 'We are connected.';
		    		testAPI();
		    		document.getElementById('primaryButton').click()();
		    	}
				
			}, {scope: 'email'});
			
		}
	</script>
	
	<!-- start header -->
	<div id = "header">
			<nav class="navbar navbar-custom navbar-fixed-top">
			<div class="container">
		    	<div class="navbar-header">
				    <a class="navbar-brand" href="#">Laluna</a>
				 </div>
				<ul class="nav navbar-nav navbar-right">
				     <li><html:link action=""> <span class="glyphicon glyphicon-user"></span> Đăng Kí</html:link></li>
		      	</ul>
		  	</div>
			</nav>
	</div>	
	<!-- end header -->
	
	<!-- start content -->
	<br><br><br>
	<div class = "text-center">
		<h3 style="color:#0072BC"><strong>ĐĂNG NHẬP TÀI KHOẢN LALUNA</strong></h3>
	</div>
	<div id = "content" >
		<div class="container">
    		<div class="row">
	       		 <div class="col-md-6 col-md-offset-3">
	            	<div class="panel panel-default">
	                <div class="panel-heading">
	                    <span class="glyphicon glyphicon-lock"></span> Đăng Nhập</div>
	                <div class="panel-body">
					<html:form  styleClass="form-horizontal" action="/log-in" method="post" >
		                    <div class="form-group">
			                       <p class="col-md-3 control-label pull-left">Tên đăng nhập</p>
			                       <div class="col-sm-8">
			                           <html:text styleClass="form-control" property="username" tabindex="1"></html:text>
			                       </div>
			                       <div class = "col-sm-9 col-sm-offset-3">
			                      		 <p style = "color:red">
										<html:errors property="usernameError"/>
			                       </div>
		                   	</div>
		                   	<div class="form-group">
			                       <p class="col-sm-3 control-label pull-left">Mật Khẩu</p>
			                       <div class="col-sm-8">
			                           <html:password styleClass="form-control" property="password" tabindex="2"></html:password>
			                           <p style = "color:red">
			                           <html:errors property="passwordError"/>
		                        </div>
	                    	</div>
		                    <div class="row form-group">
								<div class="col-lg-9 col-lg-offset-3" style="color: red;">
										<bean:write name="loginForm" property="notice"/>
								</div>
							</div>								
							
		                    <div class="form-group last">
		                        <div class="col-sm-offset-3 col-sm-9">
		                            <html:submit styleClass="btn btn-success btn-sm" property="submit" value="Đăng Nhập" tabindex="4">
		                                Đăng Nhập
		                            </html:submit>
		                            <button type="reset" class="btn btn-default btn-sm" tabindex="5">
		                                Reset
		                            </button>
		                        </div>
		                    </div>
		                    
			                <hr  width="80%" align="center"/>
			                <p align = "center"> Đăng nhập bằng </p>
					</html:form>
					<div class = "col-sm-9 col-sm-offset-2">
						<div class="g-signin2 col-sm-6" data-width="167" data-height="41" data-onsuccess="onSignIn" onclick = "gglogin()">Google</div>
						<input type="image" src = "Resource/image/fblogin.jpg" onclick="login()" id="secondaryButton" >
	                </div>
	                </div>
	                <div class="panel-footer">
	                    Chưa có tài khoản ? <a href="http://www.google.com" tabindex="6">Đăng Kí</a></div>
	            </div>	
	        </div>
	    </div>
	    <div id = "s"></div>
	    <!-- start hiden form -->
		<html:form action = "/fb-log-in" method = "post" styleClass = "hidden">
			<input type = "hidden" id = "fb_name" name ="fbName">
			<input type = "hidden" id = "fb_id" name ="fbID">
			<input type = "submit" id="primaryButton" onclick="ExistingLogic()" >
		</html:form>
 		<!-- end hiden form -->
    
	    <!-- end content -->
	</div>
	</div>
	<div id = "status"></div>
</body>
</html>
