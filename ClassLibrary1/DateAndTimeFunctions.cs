using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1Library;

public class DateAndTimeFunctions
{

    /*
     * Напишите функции для нахождения разницы между двумя датами, (+)
     * определения, является ли год високосным, (+)
     * нахождения времени суток по заданному времени,(+)
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


    // Проверка на високосный год
    public static bool isLeapYear(DateTime date){

        int year = date.Year;

        if (DateTime.IsLeapYear(year) == true) {
            return true;
        }
        else return false;
    }


    // Находит время суток по заданному времени
    public static string getPartOfTheDay(DateTime date){

        int hour = date.Hour;

        if (hour == 0 || hour < 6){
            return "Morning";
        }
        else if (hour == 6 || hour < 12) {
            return "Day";
        }
        else if (hour == 12 || hour < 18)
        {
            return "Evening";
        }
        else if (hour == 18 || hour < 24)
        {
            return "Night";
        }
        else throw new Exception("Wrong number of hour!");

    }


    // Функция для форматирования даты и времени
    public static string FormatDate(DateTime date, string format) {

        string strDate = date.ToString(format);

        return strDate;

    }
    











}