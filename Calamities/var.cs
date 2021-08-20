namespace Calamities
{
    class var
    {
        private string _originalValue;

        public static implicit operator var(string str)
        {
            return new var() { _originalValue = str };
        }

        public override string ToString() => "Bob";
    }
}
