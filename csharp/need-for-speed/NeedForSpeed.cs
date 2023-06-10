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

	public bool BatteryDrained() => _battary < _battaryDrain;

	public int DistanceDriven() => _distance;

	public void Drive()
	{
		if (BatteryDrained())
			return;
		_battary -= _battaryDrain;
		_distance += _speed;
	}

	public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack
{
	private readonly int _distance;

	public RaceTrack(int distance) => _distance = distance;

	public bool TryFinishTrack(RemoteControlCar car)
	{
		while (!car.BatteryDrained())
		{
			car.Drive();
		}

		return car.DistanceDriven() >= _distance;
	}
}
