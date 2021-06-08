using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateAssetInput input)
        {
            _logger.LogInformation("Start Update id: " + input.Asset.Id.ToString());
            var result = await _mediator.Send(input);
            _logger.LogInformation("End Update id: " + input.Asset.Id.ToString());
            return Ok(result);
        }
    }
}
