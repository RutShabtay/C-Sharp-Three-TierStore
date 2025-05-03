namespace DO;

public class DalNotExistsIdException : Exception
{

    public DalNotExistsIdException(string message) : base(message)
    {

    }

}

public class DalAlreadyExistsIdException : Exception
{

    public DalAlreadyExistsIdException(string message) : base(message)
    {
    }


}

public class DalReadForXmlException : Exception
{

    public DalReadForXmlException(string message) : base(message)
    {
    }

}

public class DalWriteForXmlException : Exception
{

    public DalWriteForXmlException(string message) : base(message)
    {
    }

}

