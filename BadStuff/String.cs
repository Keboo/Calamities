class String
{
    public static implicit operator String(string _)
    {
        return new String();
    }

    public static implicit operator string(String _)
    {
        return "4/20/1987";
    }
}
