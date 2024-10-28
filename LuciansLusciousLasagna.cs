class Lasagna
{
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int ExpectedMinutesInOven = 40;
        return ExpectedMinutesInOven; 
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int ElapsedTimeInOvenInMinutes)
    {
        int RemainingMinutesInOven = 40 - ElapsedTimeInOvenInMinutes;
        return RemainingMinutesInOven; 
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int LasagnaLayers)
    {
        int PreparationTimeInMinutes = 2 * LasagnaLayers;
        return PreparationTimeInMinutes; 
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int LasagnaLayers, int ElapsedTimeInOvenInMinutes )
    {
        int PreparationTime = PreparationTimeInMinutes(LasagnaLayers);
        int ElapsedTimeInMinutes = PreparationTime + ElapsedTimeInOvenInMinutes;
        return ElapsedTimeInMinutes; 
    }
}
