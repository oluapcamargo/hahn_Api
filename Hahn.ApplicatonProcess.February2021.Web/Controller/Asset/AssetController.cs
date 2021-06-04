using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public partial class AssetController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AssetController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
