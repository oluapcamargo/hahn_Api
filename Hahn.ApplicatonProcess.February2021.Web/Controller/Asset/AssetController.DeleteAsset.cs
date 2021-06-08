using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteAssetInput input)
        {

            _logger.LogInformation("Start Delete id: " + input.Id.ToString());
            var result = await _mediator.Send(input);
            _logger.LogInformation("End Delete id: " + input.Id.ToString());
            return Ok(result);
        }
    }
}
