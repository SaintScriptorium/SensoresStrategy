namespace SensoresPractica;

public class FabricaSensor
{
    public static ISensor GenerarSensor(int n)
    {
        switch (n)
        {
            case 1: return new SensorTemperatura(); break;
            case 2: return new AdaptadorPresion(); break;
            default : return null; break;
        }
    }
}