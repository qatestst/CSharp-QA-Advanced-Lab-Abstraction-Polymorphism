using Cars;

    public class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int battery;

    public Tesla(string model, string color, int battery)
    {
        this.model = model;
        this.color = color;
        this.battery = battery;
    }

   int IElectricCar.battery { get ; set ; }
    public int Battery { get; set; }

    string ICar.Model { get; set; }
    string ICar.Color { get; set; }
    string ICar.Start { get; set; }
    string ICar.Stop { get; set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Break!";
    }


    public override string ToString()
    {
        return $"{this.color} Tesla {this.model} with {this.battery} Batteries\n" +
            $"{this.Start()}\n" +
            $"{this.Stop()}";
    }
}