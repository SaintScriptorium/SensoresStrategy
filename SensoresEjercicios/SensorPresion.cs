namespace SensoresPractica;

public class SensorPresion
{
    public void Activar()
    {
        Console.WriteLine("Escaneando ambiente...");
    }
    public int MedirPresion()
    {
        Random ran = new Random();
        int valor = ran.Next(200000);
        return valor;
    }
}