using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPi.DTOs;
using MovieAPi.DTOs.V1.Request;
using MovieAPi.DTOs.V1.Response;

namespace MovieAPi.Interfaces.Persistence.Services
{
    public interface IStudioServices
    {
        Task<IActionResult> Create(CreateStudioDto createStudioDto);
        Task<IActionResult> GetPagedResponseAsync(int pageNumber, int pageSize);
        Task<IActionResult> Update(CreateStudioDto createStudioDto, int id);
        Task<IActionResult> Delete(int id);
    }
}