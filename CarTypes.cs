
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
        return Enum.GetName(typeof(CarType), type).Replace("_", " ");
    }
    public static int Count() {
        return (int)Enum.GetValues(typeof(CarType)).Cast<CarType>().Last();
    }
    public static List<CarType> GetAllTypes() {
        CarType[] array = (CarType[])Enum.GetValues(typeof(CarType));
        return new List<CarType>(array);
    }
}
