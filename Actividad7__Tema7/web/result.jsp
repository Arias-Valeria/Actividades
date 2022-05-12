<%-- 
    Document   : result
    Created on : 14 mar. 2022, 21:06:15
    Author     : PC
--%>
<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Population</th>
                </tr>
            </thead>
            
            <tbody>
                <c:forEach items="${empleados}" var="emp">
                <tr>
                    <td>${emp.id}</td>
                    <td>${emp.name}</td>
                    <td>${emp.rol}</td>
                </tr>
                </c:forEach>   
            </tbody>
        </table>
    </body>
</html>
