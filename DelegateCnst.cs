public sealed class DynamicMethodGenerator<TDelegate> where TDelegate : Delegate
{
    private readonly DynamicMethod _method;
 
    internal DynamicMethodGenerator(string name)
    {
        MethodInfo invoke = typeof(TDelegate).GetMethod("Invoke");
 
        var parameterTypes = invoke.GetParameters().Select(p => p.ParameterType).ToArray();
 
        _method = new DynamicMethod(name, invoke.ReturnType, 
            parameterTypes, restrictedSkipVisibility: true);
    }
 
    public ILGenerator GetILGenerator() => _method.GetILGenerator();
 
    public TDelegate Generate()
    {
        return (TDelegate)_method.CreateDelegate(typeof(TDelegate));
    }
}