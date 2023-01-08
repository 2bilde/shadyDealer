
public enum CarType {
    Tesla,
    Mercedes,
    BMW,
    Toyota,
    Citröen,
    Aston_Martin,
}

public static class CarTypeMethods 
{
    public static string Name(this CarType type) {
        return Enum.GetName(typeof(CarType), type).Replace("_", " "); //en "extension" method. erstatter _ med " "
    }
    public static int Count() { //returner mængden af værdier i "CarTypes". bruges ikke kan slettes?
        return (int)Enum.GetValues(typeof(CarType)).Cast<CarType>().Last();
    }
    public static List<CarType> GetAllTypes() { //konverterer bilerne til en liste
        CarType[] array = (CarType[])Enum.GetValues(typeof(CarType));
        return new List<CarType>(array);
    }
}
