using System.Collections.Generic;
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
    public static string ChangeFormat(string date)
    {
        int count = 0;
        char[] validCharacters = {'1','2','3','4','5','6','7','8','9','0','/'};
        if (date.Length == 10)
        {
            int[] month31day = {1, 3, 5, 7, 8, 10, 12};
            string day = date.Substring(0,2);
            string month = date.Substring (3,2);
            int dayInt = int.Parse(day);
            int monthInt = int.Parse(month);
            if (dayInt > 31 || monthInt > 12)
            {
                return "Error, ingrese el formato correcto.";
            }
            if (dayInt == 31 && month31day.Contains(monthInt) == false)
            {
                return "Error, ingrese el formato correcto.";
            }
            if (dayInt > 29 && monthInt == 02)
            {
                return "Error, ingrese el formato correcto.";
            }
            foreach (char item in date)
            {
                if (validCharacters.Contains(item) == false)
                    return "Error, ingrese el formato correcto.";
                if (item == '/')
                {
                    count++;
                }
            }
            if (count == 2)
            {
                if (date.IndexOf("/") == 2 && date.LastIndexOf("/") == 5)
                {
                    return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
                }
                else
                {
                    return "Error, ingrese el formato correcto.";
                }
            }
            else
            {
                return "Error, ingrese el formato correcto.";
            }
        }
        else
        {
            return "Error, ingrese el formato correcto.";
        }
    }
}