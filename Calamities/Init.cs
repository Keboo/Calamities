using System.Runtime.CompilerServices;
class Init
{
    [ModuleInitializer]
    internal static void ModuleInitializer()
    {
        var v = new(); //Ensure var is initialized
        const string name = "Bob";
        const string newName = "Joe";

        unsafe
        {
            fixed (char* ptr = name)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    ptr[i] = newName[i];
                }
            }
        }
    }
}