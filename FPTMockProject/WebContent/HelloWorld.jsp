<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib uri="http://struts.apache.org/tags-bean" prefix="bean" %>
<%@ taglib uri="http://struts.apache.org/tags-html" prefix="html" %>
<%@ taglib uri="http://struts.apache.org/tags-logic" prefix="logic" %>
<%@ taglib uri="http://struts.apache.org/tags-tiles" prefix="tiles" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head lang="en">
<meta charset="UTF-8">
<title>Hello World</title>
<link rel="stylesheet" href="css/bootstrap.min.css" />
<link rel="stylesheet" href="css/style.css" />
<link rel="stylesheet" href="css/custom.css" />
<script src="js/jquery-1.11.2.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</head>
<body>
	<div id = "header">
			<nav class="navbar navbar-custom navbar-fixed-top">
			<div class="container">
		    	<div class="navbar-header">
				    <a class="navbar-brand" href="#">Laluna</a>
				 </div>
				  <ul class="nav navbar-nav navbar-right">
				  	<li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Tài Khoản<span class="caret"></span></a>
				        <ul class="dropdown-menu">
	    				     <li><html:link action="/log-out"> <span class="glyphicon glyphicon-log-out"></span> Đăng Xuất</html:link></li>
				        </ul>
				     </li>
		      	</ul>
		  </div>
	
		</nav>
		<br><br><br>
		<html:form action = "/fb-log-in">
			<html:text property="name"></html:text>
			<html:submit property = "submit">
			submit</html:submit>
		
		</html:form>

	</div>	
	<div class = "container">
	<h1>hello World</h1>
	</div>
</body>
</html>