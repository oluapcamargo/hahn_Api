using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Hahn.ApplicatonProcess.February2021.Web.Models.Examples;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.Examples;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        // <summary>
        /// Delete a specific Asset.
        /// </summary>
        /// <param name="id"></param>
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
