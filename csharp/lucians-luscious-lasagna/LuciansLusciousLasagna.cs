class Lasagna
{
    private const int expMin = 40;
    private const int oneLayer = 2;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return expMin;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int min){
        return expMin - min;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers){
        return oneLayer * layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int min){
        return min + oneLayer * layers;
    }
}
