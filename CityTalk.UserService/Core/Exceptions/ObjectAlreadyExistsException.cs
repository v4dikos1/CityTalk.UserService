using System.Globalization;

namespace Core.Exceptions;

/// <summary>
/// Модель исключения, возникающего в случае если объект уже существует
/// </summary>
public class ObjectAlreadyExistsException : Exception
{
    public ObjectAlreadyExistsException() : base() { }
    public ObjectAlreadyExistsException(string message) : base(message) { }
    public ObjectAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }

    public ObjectAlreadyExistsException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
