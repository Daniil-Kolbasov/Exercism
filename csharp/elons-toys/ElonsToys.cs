using System;

class RemoteControlCar
{
    private int meters;
    private byte battery = 100;

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay() => battery != 0 ? $"Battery at {battery}%" : "Battery empty";

    public void Drive()
    {
        if (battery > 0)
        {
            meters += 20;
            battery--;
        }
    }
}
