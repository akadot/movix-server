using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Base
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
}
