public class Car
{
    private string Model;
    private int Year;
    private int Speed;

    public Car(string model, int year, int speed)
    {
        this.Model = model;
        this.Year = year;
        this.Speed = 0;
    }
    public string ShowInfo()
    {
        return $"Model: {Model}, Year: {Year}, Speed: {Speed} km/h";
    }
    public bool IsOld()
    {
        if (Year < 2000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
