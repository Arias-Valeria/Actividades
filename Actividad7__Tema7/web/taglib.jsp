<%-- 
    Document   : taglib
    Created on : 9 mar. 2022, 20:55:06
    Author     : PC
--%>
<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <c:out value="fsf"/>
        <c:set var="uno" value="one"/>
        <!-- api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key} -->
        <c:url value="api.openweathermap.org/data/2.5/weather" var="CurrentWeather" scope="session">
            <c:param name="lat" value="19.4303725"/>
            <c:param name="lon" value="-99.145879"/>
            <c:param name="appid" value="14f27b6867946452fc92dbd997575863"/>
        </c:url>
        <c:out value="${sessionScope.CurrentWeather}"/>
    </body>
</html>
