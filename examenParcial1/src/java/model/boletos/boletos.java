/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model.boletos;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Valeria
 */
public class boletos {
   public List getDatos (String user_name, String user_lastName, String user_email, String user_phone, String user_city, 
                         String user_country, String user_zipcode, String tipo_boleto){
        List datosBoleto = new ArrayList();
        datosBoleto.add(user_name);
        datosBoleto.add(user_lastName);
        datosBoleto.add(user_email);
        datosBoleto.add(user_phone);
        datosBoleto.add(user_city);
        datosBoleto.add(user_country);
        datosBoleto.add(user_zipcode);
        datosBoleto.add(tipo_boleto);
        return (datosBoleto);
    }
}
