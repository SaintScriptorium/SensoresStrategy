namespace SensoresPractica;

public class AdaptadorPresion : ISensor
{
    public readonly SensorPresion s;

    public AdaptadorPresion()
    {
        s = new SensorPresion();
    }

    public string Medir()
    {
        s.Activar();
        return $"resultado de la medicion: {s.MedirPresion()} Pa";
    }
}