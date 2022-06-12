using MinApiNetSix.Models;

namespace MinApiNetSix.Data;

public interface ICommandRepo
{
    Task SaveChanges();
    Task<Command?> GetCommandById(int Id);
    Task<IEnumerable<Command>> GetAllCommand();
    Task CreateCommand(Command cmd);
    void DeleteCommand(Command cmd);
}