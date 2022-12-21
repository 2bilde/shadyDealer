public class Door{
    
    public int doorMin = 1;
    public int doorMax = 2;
    public int doorAmount;

    public void DoorAmount(int doorMin, int doorMax){
        Random rng = new Random();

    int doorAmount = rng.Next(doorMin, doorMax);
        switch (doorAmount){
        case 1:
            doorAmount = 3;
            break;
        case 2:
            doorAmount = 5;
            break;
        }
    }
    
    public Door(int doorMin, int doorMax){
        
    }
}