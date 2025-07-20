namespace SensoresPractica;

public class Menu
{
    private bool on = true;
    public void Start()
    {
        do
        {
            Show();
        } while (on);
    }

    private void Show()
    {
        Console.WriteLine("-- Bienvenido a tu sensor BMP280--\n");
        Console.WriteLine("Elige una funcion: \n");
        Console.WriteLine("[1] Sensor de Temperatura. \t[2] Sensor de Presion.\n");
        MostrarResultado();
    }

    private void MostrarResultado()
    {
        var option = int.Parse(Console.ReadLine());
        var fabrica = FabricaSensor.GenerarSensor(option);
        var sensor = new SensorStrategy(fabrica);
        Console.WriteLine(sensor.Medir());
        Seguir();
    }
    public void Seguir()
    {
        Console.WriteLine("\nDesea seguir? (y/n)");
        var input = Console.ReadLine().ToLower();

        switch (input)
        {
            case "y": break;
            case "n":
                Console.WriteLine("Good Bye!"); on = false; break;
        }
    }
}