
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
    public static int Length() {
        return (int)Enum.GetValues(typeof(CarType)).Cast<CarType>().Last();
    }
    public static List<CarType> GetAllTypes() {
        CarType[] array = (CarType[])Enum.GetValues(typeof(CarType));
        List<CarType> list = new List<CarType>(array);
        return list;
    }
}
