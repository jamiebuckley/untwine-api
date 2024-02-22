using Microsoft.EntityFrameworkCore;
using UnderwayAPI.Data;
using UnderwayAPI.Models;

namespace UnderwayAPI.Repositories;

public class PipelinesRepository
{
    private readonly UnderwayContext _context;

    public PipelinesRepository(UnderwayContext context)
    {
        _context = context;
    }
    
    public List<Pipeline> GetAllPipelines()
    {
        return _context.Pipelines.ToList();
    }

    public Pipeline CreatePipeline(Pipeline newPipeline)
    {
        _context.Pipelines.Add(newPipeline);
        _context.SaveChanges();
        return newPipeline;
    }
}