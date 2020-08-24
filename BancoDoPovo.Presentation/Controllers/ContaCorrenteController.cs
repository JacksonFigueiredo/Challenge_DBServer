using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDDD.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContaCorrentesController : ControllerBase
    {

        private readonly IApplicationServiceContaCorrente _applicationServiceContaCorrente;


        public ContaCorrentesController(IApplicationServiceContaCorrente ApplicationServiceContaCorrente)
        {
            _applicationServiceContaCorrente = ApplicationServiceContaCorrente;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceContaCorrente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceContaCorrente.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ContaCorrenteDTO ContaDTO)
        {
            try
            {
                if (ContaDTO == null)
                    return NotFound();

                _applicationServiceContaCorrente.Add(ContaDTO);
                return Ok("Conta Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ContaCorrenteDTO ContaDTO)
        {
            try
            {
                if (ContaDTO == null)
                    return NotFound();

                _applicationServiceContaCorrente.Update(ContaDTO);
                return Ok("Conta Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }






        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ContaCorrenteDTO contaDTO)
        {
            try
            {
                if (contaDTO == null)
                    return NotFound();

                _applicationServiceContaCorrente.Remove(contaDTO);
                return Ok("Conta Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}