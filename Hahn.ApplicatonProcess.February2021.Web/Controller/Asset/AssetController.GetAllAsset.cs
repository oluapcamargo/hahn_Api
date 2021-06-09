using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        // <summary>
        /// Get all Asset.
        /// </summary>
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var input = new GetAllAssetInput();
            _logger.LogInformation("Start Get All ");
            var result = await _mediator.Send(input);
            _logger.LogInformation("End Get All ");
            return Ok(result);
        }
    }
}
