using Hahn.ApplicatonProcess.February2021.Domain.Entity;
using Hahn.ApplicatonProcess.February2021.Domain.Enum;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel.Output;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Hahn.ApplicatonProcess.February2021.Web.Controller.Enum
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumDepartmentController : ControllerBase
    {
        public EnumDepartmentController(){}

        [HttpGet]
        public IActionResult GetEnum()
        {
            var lista = new List<object>();
            var result = new Result<List<object>>();

            foreach (int item in System.Enum.GetValues(typeof(EnumDepartment)))
                lista.Add(new
                {
                    item,
                    Description =
                    System.Enum.TryParse(typeof(EnumDepartment), item.ToString(), out object enumOut)
                ? ((EnumDepartment)enumOut).EnumDescription()
                : null
                });

            result.Value = lista;
            return Ok(result);

        }
    }
}
