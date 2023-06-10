using System;

class RemoteControlCar
{
    private int _speed;
    private int _battaryDrain;
    private int _battary;
    private int _distance;
        
    public RemoteControlCar(int speed, int battaryDrain)
    {
        _speed = speed;
        _battaryDrain = battaryDrain;
        _battary = 100;
        _distance = 0;
    }

    public bool BatteryDrained()
    {
        if (_battary >= _battaryDrain)
            return false;
        else
            return true;
    }

    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _battary = _battary - _battaryDrain;
            _distance += _speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance) => _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
        }

        if (car.DistanceDriven() >= _distance)
            return true;
        else
            return false;
    }
}
