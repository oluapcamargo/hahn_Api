using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Input.AssetInput;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Asset
{
    public partial class AssetController
    {
        /// <summary>
        /// Create an Asset.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Asset
        ///     {
        ///        "assentName": "Item1",
        ///        "department": 1,
        ///        "countryDepartment": "Brasil",
        ///        "emailDepartment": "email@email.com",
        ///        "purchaseDate": "2021-06-01",
        ///        "broken": false
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>A newly created</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>   
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
