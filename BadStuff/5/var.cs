class var
{
    public static implicit operator var(string _)
        => new var();

    public override string ToString() => "Bob";
}