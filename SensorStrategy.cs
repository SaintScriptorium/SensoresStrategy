namespace SensoresPractica;

public class SensorStrategy 
{
    private ISensor fabrica;

    public SensorStrategy(ISensor fabrica)
    {
        this.fabrica = fabrica;
    }

    public string Medir()
    {
       return fabrica.Medir();
    }
}