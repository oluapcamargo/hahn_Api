using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        [HttpPost]
        public async Task<IActionResult> Insert([FromQuery] InsertAssetInput input)
        {
            var result = await _mediator.Send(input);
            return Ok(result);
        }
    }
}
