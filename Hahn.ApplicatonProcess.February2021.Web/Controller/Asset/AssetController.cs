using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    [Route("api/[controller]")]
    [ApiController]

    public partial class AssetController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public AssetController(IMediator mediator, ILogger<Domain.Entity.Asset> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}
