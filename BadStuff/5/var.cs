class var
{
    public static implicit operator var(string _)
        => new();

    public override string ToString() => "Bob";
}