using Calculadora.BEP.Business;
using Calculadora.BFP.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.BEF.Web.Controllers
{
    [ApiController]
    public class CalculadoraBFPController : Controller
    {
        [Route("API/V1/Calculdara/Hombre")]
        [HttpPost]
        public ResponseAPI GetHombreResultado(DatosHombre dt)
        {
            ResponseAPI response = new ResponseAPI();
            CalcuadoraBusiness bs = new CalcuadoraBusiness();
            try
            {
                response.Respuesta = bs.ResulatadoHombreBusiness(dt);
                response.Codigo = 0;
                response.Mensaje = "resulatado ok";
            }
            catch (Exception ex)
            {
                response.Codigo = 1;
                response.Respuesta = ex.Message;
            }
            return response;
        }

        [Route("API/V1/Calculdara/Mujer")]
        [HttpPost]
        public ResponseAPI GetMujerResultado(DatosMujer dt)
        {
            ResponseAPI response = new ResponseAPI();
            CalcuadoraBusiness bs = new CalcuadoraBusiness();
            try
            {
                response.Respuesta = bs.ResulatadoMujerBusiness(dt);
                response.Codigo = 0;
                response.Mensaje = "resulatado ok";
            }
            catch (Exception ex)
            {
                response.Codigo = 1;
                response.Respuesta = ex.Message;
            }
            return response;
        }
    }
}
