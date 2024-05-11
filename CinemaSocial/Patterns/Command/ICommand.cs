namespace CinemaSocial.Patterns.Command;

public interface ICommand
{
    Task ExecuteAsync(int userId, Guid movieId);
}