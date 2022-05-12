<%-- 
    Document   : newjsp
    Created on : 16 mar. 2022, 21:13:02
    Author     : PC
--%>
<%@taglib prefix="mytags" uri="/WEB-INF/tlds/mytags.tld"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello World!</h1>
        <mytags:Addition first="10" second="15"/>
        <mytags:Substraction first="10" second="15"/>
    </body>
</html>
