
public class Door{
    
    const int DOOR_MIN = 1;
    const int DOOR_MAX = 2;
    public int doorAmount;


    public Door(){
        Random rng = new Random();
        //converts 1 or 2 into 3 or 5 doors, +1 because rng.Next goes [low number; high number[
        switch ( rng.Next(DOOR_MIN, DOOR_MAX+1)){
        case 1:
            doorAmount = 3;
            break;
        case 2:
            doorAmount = 5;
            break;
        }
    }
    
}