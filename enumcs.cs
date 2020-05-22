public static TEnum[] GetValues<TEnum>() where TEnum : System.Enum
{
    return (TEnum[])Enum.GetValues(typeof(TEnum));
}
 

// BCL-based version
MyEnum[] values = (MyEnum[])Enum.GetValues(typeof(MyEnum));
            
// Type-safe version
MyEnum[] values2 = GetValues<MyEnum>();