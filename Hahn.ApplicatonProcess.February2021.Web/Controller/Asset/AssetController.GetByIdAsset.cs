using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {

        /// <summary>
        /// Get a specific Asset.
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public async Task<IActionResult> GetAsset([FromQuery] GetAssetInput input)
        {
            _logger.LogInformation("Start Get id: " + input.Id.ToString());
            var result = await _mediator.Send(input);
            _logger.LogInformation("End Get id: " + input.Id.ToString());
            return Ok(result);
        }
    }
}
