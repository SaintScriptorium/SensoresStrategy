namespace SensoresPractica;

public class SensorTemperatura : ISensor
{
    public string Medir()
    {
        Random ran = new Random();

        int value = ran.Next(-100,101);

        return $"Escaneando.... \nLa temperatura es: {value}\u00B0C";
    }
}