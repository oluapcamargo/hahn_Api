using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] InsertAssetInput input)
        {
            _logger.LogInformation("Start Insert new assent ");
            var result = await _mediator.Send(input);
            _logger.LogInformation("End Insert new assent ");
            return Ok(result);
        }
    }
}
