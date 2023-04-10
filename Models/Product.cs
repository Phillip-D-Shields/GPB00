using System;


namespace GPB00.Models
{
    public record Product(
        string Name,
        string Description,
        decimal Cost,
        DateTime CreatedDateTime,
        List<string> BulletPoints,
        Uri Image
        )
    {
      
    }
}

