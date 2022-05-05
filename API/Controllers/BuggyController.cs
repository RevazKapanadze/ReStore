namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound();
        }
         [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest("This is bad request");
        }
         [HttpGet("unauthorised")]
        public ActionResult GetUnauthorised()
        {
            return Unauthorised();
        }
         [HttpGet("validation-error")]
        public ActionResult GEtValidationError()
        {
            ModelState.AddModelError("Problem1", "This is first error");
            ModelState.AddModelError("Problem2", "This is second error");
            return ValidationProblem();
        }
         [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("this is server error");
        }
        
    }
}