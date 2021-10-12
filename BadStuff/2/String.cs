class String
{
    public static implicit operator String(string _)
        => new String();

    public static implicit operator string(String _)
        => "4/20/1987";
}