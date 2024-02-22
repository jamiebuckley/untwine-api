using Microsoft.AspNetCore.Mvc;
using UnderwayAPI.Models;
using UnderwayAPI.Models.DTO;
using UnderwayAPI.Repositories;

namespace UnderwayAPI.Controllers;

[ApiController]
[Route("api/pipelines")]
public class PipelinesController(PipelinesRepository pipelinesRepository)
{
    [HttpGet]
    public ActionResult<List<PipelineReadDTO>> GetPipelines()
    {
        return pipelinesRepository.GetAllPipelines().Select(p => PipelineReadDTOMapper.MapFromPipeline(p))
            .ToList();
    }

    [HttpPost]
    public ActionResult<PipelineReadDTO> CreatePipeline([FromBody] PipelineCreateDTO dto)
    {
        var pipeline = new Pipeline
        {
            Name = dto.Name
        };
        var createdPipeline = pipelinesRepository.CreatePipeline(pipeline);
        return PipelineReadDTOMapper.MapFromPipeline(createdPipeline);
    }
}