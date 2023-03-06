using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Models;
public class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}
