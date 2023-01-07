
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
        return Enum.GetName(typeof(CarType), type).Replace("_", " "); //en metode til at "få" bilernes navne andre steder. erstatter _ med mellemrum for Aston_Martin
    }
    public static int Count() { //bruges ikke. tror godt kan slettes
        return (int)Enum.GetValues(typeof(CarType)).Cast<CarType>().Last();
    }
    public static List<CarType> GetAllTypes() { //en metode til at "få" bilernes type til at lasve listen
        CarType[] array = (CarType[])Enum.GetValues(typeof(CarType));
        return new List<CarType>(array);
    }
}
