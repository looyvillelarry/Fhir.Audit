namespace Fhir.Audit.Controllers
{

    using System.Threading.Tasks;

    using Hl7.Fhir.Model;

    using Microsoft.AspNetCore.Mvc;

    using Task = System.Threading.Tasks.Task;

    [Produces("application/json")]
    [Route("api/Audit")]
    public class AuditController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> AuditEvent([FromBody] AuditEvent auditEvent)
        {
            if (auditEvent == null)
            {
                throw new System.ArgumentNullException(nameof(auditEvent));
            }

            bool retval = await Task.FromResult(true);

            return this.Ok(retval);
        }

    }
}