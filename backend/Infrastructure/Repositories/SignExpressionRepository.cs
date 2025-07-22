using Signary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Signary.Infrastructure.Persistence;

public class SignExpressionRepository : ISignExpressionRepository
{
    private readonly ApplicationDbContext _context;

    public SignExpressionRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<SignExpression> AddAsync(SignExpression signExpression)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SignExpression>> GetAllAsync()
    {
        return await _context.SignExpressions
            .Include(se => se.Definitions)
            .ToListAsync();
    }

    public Task<SignExpression?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}