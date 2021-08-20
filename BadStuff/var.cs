
class var
{
    //private string _originalValue;

    public static implicit operator var(string _)
    {
        return new var();
    }

    public override string ToString() => "Bob";
}

