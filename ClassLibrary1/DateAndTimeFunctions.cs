using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateFunctionsLibrary;

public class DateAndTimeFunctions
{

    /*
     * Напишите функции для нахождения разницы между двумя датами, (+)
     * определения, является ли год високосным, 
     * нахождения времени суток по заданному времени, 
     * а также для форматирования даты и времени. 
     * Напишите модульные тесты для каждой функции.
     */


    // Сравнение двух дат.
    public static DateTime DateCompare(DateTime Date1, DateTime Date2){
        if (Date1 == Date2) {
            throw new Exception("Dates are equal!");
        }
        else {
            int result = DateTime.Compare(Date1, Date2);
            if (result < 0){
                return Date1;
            }
            else 
                return Date2;
        }
    }

    //end




}