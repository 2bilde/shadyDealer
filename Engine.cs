class Engine
{
    public 
    int topSpeed = 100;
    public Engine(CarType type) //genererer tilfældig top hastiged. 100 + 10-50 * bil specifikt tal
    {
        Random rnd = new Random();
        int spd = rnd.Next(10,50);
        switch (type) {
            case CarType.Tesla:
                spd *= 4;
                break;
            case CarType.Mercedes:
                spd = (int)((double)spd*4.5);
                break;
            case CarType.BMW:
                spd *= 3;
                break;
            case CarType.Toyota:
                spd *= 2;
                break;
            case CarType.Citröen:
                spd = (int)((double)spd*1.5);
                break;
            case CarType.Aston_Martin:
                spd *= 6;
                break;
            default:
                break;

        }
        topSpeed += spd;
    }
}