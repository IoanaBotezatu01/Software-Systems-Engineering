using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
     
        Console.Write("Enter the scale to convert FROM\n Celsius\n Fahrenheit\n Kelvin \n->");
        string fromScale = Console.ReadLine().ToLower();

        Console.Write("Enter the scale to convert TO\n Celsius\n Fahrenheit\n Kelvin\n-> ");
        string toScale = Console.ReadLine().ToLower();

        Console.Write("Enter the temperature value: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        double convertedTemperature = ConvertTemperature(temperature, fromScale, toScale);

        Console.WriteLine($"Converted temperature: {convertedTemperature} {toScale}");
    }

    static double ConvertTemperature(double temperature, string fromScale, string toScale)
    {
        double convertedTemperature = 0;

        switch (fromScale)
        {
            case "celsius":
                switch (toScale)
                {
                    case "celsius":
                        convertedTemperature = temperature;
                        break;
                    case "fahrenheit":
                        convertedTemperature = (temperature * 9 / 5) + 32;
                        break;
                    case "kelvin":
                        convertedTemperature = temperature + 273.15;
                        break;
                }
                break;

            case "fahrenheit":
                switch (toScale)
                {
                    case "celsius":
                        convertedTemperature = (temperature - 32) * 5 / 9;
                        break;
                    case "fahrenheit":
                        convertedTemperature = temperature;
                        break;
                    case "kelvin":
                        convertedTemperature = (temperature + 459.67) * 5 / 9;
                        break;
                }
                break;

            case "kelvin":
                switch (toScale)
                {
                    case "celsius":
                        convertedTemperature = temperature - 273.15;
                        break;
                    case "fahrenheit":
                        convertedTemperature = (temperature * 9 / 5) - 459.67;
                        break;
                    case "kelvin":
                        convertedTemperature = temperature;
                        break;
                }
                break;
        }

        return convertedTemperature;
    }
}
