using System.Globalization;

namespace Core.Exceptions;
/// <summary>
/// Модель исключения, возникающего в случае если объект не найден.
/// </summary>
[Serializable]
public class ObjectNotFoundException : Exception
{
    public ObjectNotFoundException() : base() { }
    public ObjectNotFoundException(string message) : base(message) { }
    public ObjectNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    public ObjectNotFoundException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
}
