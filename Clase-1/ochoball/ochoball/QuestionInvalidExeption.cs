
namespace ochoball
{
    [Serializable]
    public class QuestionInvalidExeption : Exception
    {
        public QuestionInvalidExeption()
        {
        }

        public QuestionInvalidExeption(string? message) : base(message)
        {
        }

        public QuestionInvalidExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}