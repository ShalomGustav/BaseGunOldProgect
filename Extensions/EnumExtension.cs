namespace BaseGun.Extensions;

public static class EnumExtension
{
    public static TEnum GetValue<TEnum>(this TEnum owner, int index) where TEnum : struct, Enum
    {
        var names = Enum.GetNames<TEnum>();
        var result = Enum.Parse<TEnum>(names[index]);

        return result;
    }
}