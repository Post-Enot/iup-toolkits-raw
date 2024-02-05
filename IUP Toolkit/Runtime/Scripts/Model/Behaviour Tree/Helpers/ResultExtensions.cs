namespace IUP.Toolkits.BehaviourTree
{
    public static class ResultExtensions
    {
        public static Result Invert(this Result result)
        {
            return result switch
            {
                Result.Failure => Result.Success,
                Result.Success => Result.Failure,
                _ => result
            };
        }
    }
}
