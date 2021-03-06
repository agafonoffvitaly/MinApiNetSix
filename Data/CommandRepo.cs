using Microsoft.EntityFrameworkCore;
using MinApiNetSix.Models;

namespace MinApiNetSix.Data;
public class CommandRepo : ICommandRepo
{
    private readonly AppDbContext _context;
    public CommandRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task CreateCommand(Command cmd)
    {
        if (cmd == null)
        {
            throw new ArgumentException(nameof(cmd));
        }

        await _context.AddAsync(cmd);
    }

    public void DeleteCommand(Command cmd)
    {
        if (cmd == null)
        {
            throw new ArgumentException(nameof(cmd));
        }

        _context.Commands.Remove(cmd);
    }

    public async Task<IEnumerable<Command>> GetAllCommand()
    {
        return await _context.Commands!.ToListAsync();
    }

    public async Task<Command?> GetCommandById(int Id)
    {
        return await _context.Commands.FirstOrDefaultAsync(c => c.Id == Id);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}