package model.empleado;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
import java.awt.*;
import java.io.Serializable;
         
                        
public class Empleado implements Serializable{

    public int id;
    public String name;
    public String rol;

    public Empleado(int id, String name, String rol) {
        this.id = id;
        this.name = name;
        this.rol = rol;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getId() {
        return id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
    
    public void setRol(String rol) {
        this.rol = rol;
    }

    public String getRol() {
        return rol;
    }
    
    
}
