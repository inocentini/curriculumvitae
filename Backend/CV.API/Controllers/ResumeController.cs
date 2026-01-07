using CV.API.Models;
using CV.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CV.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResumeController : ControllerBase
{
    private readonly IResumeService _resumeService;

    public ResumeController(IResumeService resumeService)
    {
        _resumeService = resumeService;
    }

    [HttpGet]
    public ActionResult<ResumeData> Get()
    {
        return Ok(_resumeService.GetResume());
    }
}
