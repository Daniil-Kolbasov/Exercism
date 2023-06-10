class Lasagna
{
    private const int expMin = 40;
    private const int oneLayer = 2;

    public int ExpectedMinutesInOven() => expMin;

    public int RemainingMinutesInOven(int min) => expMin - min;

    public int PreparationTimeInMinutes(int layers) => oneLayer * layers;

    public int ElapsedTimeInMinutes(int layers, int min) => min + oneLayer * layers;
}
