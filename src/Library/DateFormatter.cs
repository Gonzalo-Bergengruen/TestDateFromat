using System;

namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    
    public static bool DiaValido(string date)
    {
        if (Int32.Parse(date.Substring(0, 2)) > 0 && Int32.Parse(date.Substring(0, 2)) <= 31 &&
            Int32.Parse(date.Substring(3, 2)) > 0 && Int32.Parse(date.Substring(3, 2)) <= 12 &&
            Int32.Parse(date.Substring(6)) > 0)
        {
            return true;
        } else{
            return false;
        }
    }
    public static string ChangeFormat(string date)
    {
        if (String.IsNullOrEmpty(date))
        {
            return "Error: fecha vacía.";
        } else if (DiaValido(date) == false)
        {
            return "Error: fecha invalida.";
        } else {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
    }
}
