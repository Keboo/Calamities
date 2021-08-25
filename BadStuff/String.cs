
class String
{
    public static implicit operator String(var _)
    {
        return new String();
    }

    public static string operator +(String _) => "4/20/1987";
    public static string operator +(String _, int i) => "4/20/1987";
}
