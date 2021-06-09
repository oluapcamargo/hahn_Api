using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        /// <summary>
        /// Update Asset.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Asset
        ///     {
        ///        "id":"1"
        ///        "assetName": "Item1",
        ///        "department": 1,
        ///        "countryOfDepartment": "Brasil",
        ///        "eMailAdressOfDepartment": "email@email.com",
        ///        "purchaseDate": "2021-06-01",
        ///        "broken": false
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>Updated</returns>
        /// <response code="200">Returns the update item</response>
        /// <response code="400">If the item is null</response>   
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
