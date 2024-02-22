using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnderwayAPI.Models;

public class Pipeline
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
    public Guid Id { get; set; }
    public string Name { get; set; }
}