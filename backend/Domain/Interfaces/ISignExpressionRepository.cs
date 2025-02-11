using Signary.Domain.Entities;

public interface ISignExpressionRepository
{
    Task<SignExpression> AddAsync(SignExpression signExpression);
    Task<SignExpression?> GetByIdAsync(Guid id);
    Task<List<SignExpression>> GetAllAsync();
}