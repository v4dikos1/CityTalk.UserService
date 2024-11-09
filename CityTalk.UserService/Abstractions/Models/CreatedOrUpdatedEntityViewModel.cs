namespace Abstractions.Models;

public class CreatedOrUpdatedEntityViewModel<T>(T id)
{
    public T Id { get; set; } = id;
}

public class CreatedOrUpdatedEntityViewModel(Guid id) : CreatedOrUpdatedEntityViewModel<Guid>(id);