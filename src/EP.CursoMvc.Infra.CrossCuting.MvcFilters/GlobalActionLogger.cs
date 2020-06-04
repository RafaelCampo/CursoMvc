using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EP.CursoMvc.Infra.CrossCuting.MvcFilters
{
   public class GlobalActionLogger : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Log de Auditoria
            //Usuario, Acao,IP, Maquina
            
            if(filterContext.Exception != null)
            {
                //Manipular EX
                //Injetar alguma LIB de tratamento de erro
                // -> Gravar LOG de ERRO no BD
                // -> Email para o admin
                // -> Retornar cod erro amigavel

                //Log4Net
                //Elmah.IO
                //Custom Logger

                filterContext.ExceptionHandled = true;
                filterContext.Result = new HttpStatusCodeResult(500);
            }


            base.OnActionExecuted(filterContext);
        }
    }
}
