namespace BO;

[Serializable]
public class BlNotExistsIdException : Exception
{

    public BlNotExistsIdException(string? message) : base(message)
    {
    }
    public BlNotExistsIdException(string message, Exception innerException)
        : base(message, innerException) { }

}

[Serializable]
public class BlAlreadyExistsIdException : Exception
{

    public BlAlreadyExistsIdException(string message) : base(message)
    {
    }

    public BlAlreadyExistsIdException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

}

public class BlGeneralException : Exception
{

    public BlGeneralException(string message) : base(message)
    {
    }
}

public class BlInvalidQuantity : Exception
{

    public BlInvalidQuantity(string message) : base(message)
    {
    }
}


