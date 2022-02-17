<%-- 
    Document   : registrado
    Created on : 17/02/2022, 12:01:46 AM
    Author     : Valeria
--%>

<%@page import="java.util.Iterator"%>
<%@page import="java.util.List"%>
<%@page import="javax.servlet.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Registro completado</title>
    </head>
    <body>
        <h1>Datos de registro</h1>
        <p>Nombre del evento: 
            <%String nombreEvento = getServletContext().getInitParameter("nombreEvento");
            out.println(nombreEvento);
            %>
        </p>
        
        <p>Fecha del evento: 
            <%String fechaEvento = getServletContext().getInitParameter("fechaEvento");
            out.println(fechaEvento);
            %>
        </p>
        
        <p>Lugar del evento: 
            <%String lugarEvento = getServletContext().getInitParameter("lugarEvento");
            out.println(lugarEvento);
            %>
        </p>
        
        <h3>Datos personales: </h3>
        <%
            List info = (List)request.getAttribute("info");
            Iterator num = info.iterator();
            while(num.hasNext()){
            out.println("<br>- " + num.next());
        }
        %>
        <br>
        <br>
        <form action="formulario.html" method="POST">
            <input type="submit" value="Regresar"> 
        </form>
        
    </body>
</html>
