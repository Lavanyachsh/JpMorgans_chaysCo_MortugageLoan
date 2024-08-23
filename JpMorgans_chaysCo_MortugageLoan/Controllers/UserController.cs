using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.Interfaces;
using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.ModelDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JpMorgans_chaysCo_MortugageLoan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRegistrationServices _usrregservices;
        public UserController(IUserRegistrationServices usrregservices)
        {
            _usrregservices = usrregservices;
        }
        [HttpGet(Name = "GetAllUserRegistration")]
        public async Task<IActionResult> GetAllUserRegistrations()
        {
            try
            {
                var userdata = await _usrregservices.GetAllUserRegistrations();
                if (userdata != null)
                {
                    return StatusCode(StatusCodes.Status200OK, userdata);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
        [HttpPost]
        [Route("AddUserRegistration")]
        public async Task<IActionResult> Post([FromBody] UserRegistrationDtos userregdetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var userdata = await _usrregservices.AddUserRegistration(userregdetail);
                return StatusCode(StatusCodes.Status201Created, "userregistrtion  Added Succesfully");
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpGet]
        [Route("GetAllUserRegistrationById/{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            if (Id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }
            try
            {
                var userdata = await _usrregservices.GetAllUserRegistrationById(Id);
                if (userdata == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "userId  not found");
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, userdata);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpDelete]
        [Route("DelateUserRegistation/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            if (Id < 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Bad input request");
            }

            try
            {
                var usrdata = await _usrregservices.DelateUserRegistation(Id);
                if (usrdata == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "user Id not found");
                }
                else
                {
                    var Data = await _usrregservices.DelateUserRegistation(Id);
                    return StatusCode(StatusCodes.Status204NoContent, "user details deleted successfully");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }

        [HttpPut]
        [Route("UpdateUserRegistration")]
        public async Task<IActionResult> PUT([FromBody] UserRegistrationDtos usrdto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var usrdata = await _usrregservices.UpdateUserRegistration(usrdto);
                return StatusCode(StatusCodes.Status201Created, " user Details Updated Succesfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
    }
}
