namespace Calamities
{
    class String
    {
        private string _originalValue;

        public static implicit operator String(string str)
        {
            return new String() { _originalValue = str };
        }

        public static implicit operator string(String _)
        {
            return "4/20/1987";
        }
    }
}
