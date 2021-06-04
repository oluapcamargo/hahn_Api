using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteAssetInput input)
        {
            var result = await _mediator.Send(input);
            return Ok(result);
        }
    }
}
