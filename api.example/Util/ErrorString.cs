namespace Util
{
    public class ErrorString
    {
        private string _string;

        public ErrorString(string errorString)
        {
            _string = errorString;
        }

        public static implicit operator ErrorString(string errorString)
        {
            if (errorString == null)
                return null;

            return new ErrorString(errorString);
        }

        public override string ToString()
        {
            return _string;
        }
    }
}