using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApiDDD.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        private readonly IApplicationServiceLancamentos _applicationServiceLancamentos;

        public LancamentosController(IApplicationServiceLancamentos ApplicationServiceLancamentos)
        {
            _applicationServiceLancamentos = ApplicationServiceLancamentos;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceLancamentos.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceLancamentos.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] LancamentosDTO lancamentoDTO)
        {
            try
            {
                if (lancamentoDTO == null)
                    return NotFound();


                _applicationServiceLancamentos.Add(lancamentoDTO);
                return Ok("o Lançamento foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] LancamentosDTO LancamentoDTO)
        {

            try
            {
                if (LancamentoDTO == null)
                    return NotFound();

                _applicationServiceLancamentos.Update(LancamentoDTO);
                return Ok("Lançamento atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] LancamentosDTO LançamentoDTO)
        {
            try
            {
                if (LançamentoDTO == null)
                    return NotFound();

                _applicationServiceLancamentos.Remove(LançamentoDTO);
                return Ok("Lançamento removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}