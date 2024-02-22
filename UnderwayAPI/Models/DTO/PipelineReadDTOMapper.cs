namespace UnderwayAPI.Models.DTO;

public class PipelineReadDTOMapper
{
    public static PipelineReadDTO MapFromPipeline(Pipeline pipeline)
    {
        PipelineReadDTO dto = new PipelineReadDTO();
        dto.Id = pipeline.Id.ToString();
        dto.Name = pipeline.Name.ToString();
        return dto;
    }
}