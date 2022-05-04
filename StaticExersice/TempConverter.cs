using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExersice
{
    //Create a new console app called StaticExercise.
//Now create a static class called TempConverter.The class should have at least 2 methods,
//one called FahrenheitToCelsius that will require a double as a parameter and return a double,
//the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
//Fill out these methods and call them in your Program.cs file.Make sure they’re accurate!
//(farTemperature - 32) / 1.8

    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double farTC)
        {
           double answer = (farTC - 32) / 1.8;
            return answer;

        }
        public static double CelsiusToFarenheit(double celTF)
        {
            double answer1 = (celTF * 1.8) + 32;
            return answer1;
        }

    }

}
