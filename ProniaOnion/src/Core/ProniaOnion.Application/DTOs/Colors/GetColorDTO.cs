using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProniaOnion.Domain.Entities;

namespace ProniaOnion.Application.DTOs.Colors
{
    public record GetColorDTO(int Id, string Name, ICollection<Product> Products)
    {
    }
}
