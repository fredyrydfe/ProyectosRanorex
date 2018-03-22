/*
 * Created by Ranorex
 * User: fsaldarriaga
 * Date: 21/03/2018
 * Time: 3:04 p. m.
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Avianca.Mapa_de_objetos
{
    
    [UserCodeCollection]
    public class Home
    {
    	
    	[UserCodeMethod]
    	public static void seleccionarFechaDeIda(String valor)
    	{
    		if (valor.Equals("Día en curso")) {
    			valor = obtenerFechaActual();
    		}
    		var repo = AviancaRepository.Instance;
    		var bkFechaIda = repo.EnColombiaVuelosNacionalesEInternac.BkFechaIda;
    		bkFechaIda.PressKeys(valor);
    	}
    	
    	[UserCodeMethod]
    	public static void SeleccionarFechaDeRegreso(String valor)
    	{
    		
    		if (valor.Contains("días despues de la fecha en curso")) {
    			String dias = valor.Substring(0, 1);
    			valor = obtenerFechaPosterior(dias);
    		}
    		var repo = AviancaRepository.Instance;
    		var bkFechaRegreso = repo.EnColombiaVuelosNacionalesEInternac.BkFechaRegreso;
    		bkFechaRegreso.PressKeys(valor);
    	}
        
        [UserCodeMethod]
        private static String obtenerFechaActual()
        {
        	String formatoFecha = "ddMMyyyy";
        	System.DateTime diaActual = System.DateTime.Today;
        	String fechaActual = diaActual.ToString(formatoFecha);
        	return fechaActual;
        }
        
        [UserCodeMethod]
    	public static String obtenerFechaPosterior(String valor)
    	{
    		int numeroDeDias = Int32.Parse(valor);
    		String formatoFecha = "ddMMyyyy";
    		System.DateTime dia = System.DateTime.Today.AddDays(numeroDeDias);
        	String fechaPosterior = dia.ToString(formatoFecha);
        	return fechaPosterior;
    	}
    }
}
