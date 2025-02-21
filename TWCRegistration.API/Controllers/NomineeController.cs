using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TWCRegistration.Business;
using TWCRegistration.Core.Models.Individual;

namespace TWCRegistration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomineeController : ControllerBase
    {
        #region Global Variables
        private readonly ILogger<NomineeController> _logger;
        private readonly INomineeManager _nominee;

        #endregion

        #region Ctor
        public NomineeController(ILogger<NomineeController> logger, INomineeManager INominee)
        {
            _logger = logger;
            _nominee = INominee;
        }

        #endregion

        #region Method
        [HttpPost("InsertOrUpdateNominee")]
        public async Task<ResultModel> InsertNominee(NomineeModel model)
        {
            try
            {


                var data = await _nominee.InsertORUpdateNominee(model);
                if (data != null)
                {

                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.OK,
                        Data = data,
                        Message = "",
                        Token = ""
                    };
                }
                else
                {
                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.NotFound,
                        Data = data,
                        Message = "",
                        Token = ""
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("NomineeController -- InsertOrUpdateNominee " + HttpStatusCode.NotFound + ",Failed" + "Errorline" + ex.Source + "");
                _logger.LogError(ex.Message);
                return new ResultModel()
                {
                    Code = HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Data = null
                };
            }
        }
        [HttpPost("InsertOrUpdateNomineeGuardian")]
        public async Task<ResultModel> InsertNomineeGuardian(NomineeGuardianModel model)
        {
            try
            {


                var data = await _nominee.InsertORUpdateNomineeGuardian(model);

                if (data != null)
                {
                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.OK,
                        Data = data,
                        Message = data,
                        Token = ""
                    };
                }
                else
                {
                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.NotFound,
                        Data = data,
                        Message = "",
                        Token = ""
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("NomineeController -- InsertOrUpdateNomineeGuardian " + HttpStatusCode.NotFound + ",Failed" + "Errorline" + ex.Source + "");
                _logger.LogError(ex.Message);
                return new ResultModel()
                {
                    Code = HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        [HttpGet("GetRelationList")]
        public async Task<ResultModel> GetRelationShipName()
        {
            try
            {


                var data = _nominee.GetRelationshipName();

                if (data != null)
                {
                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.OK,
                        Data = data.Result.ToList(),
                        Message = "",
                        Token = ""
                    };
                }
                else
                {
                    return new ResultModel()
                    {
                        Code = System.Net.HttpStatusCode.NotFound,
                        Data = data,
                        Message = "",
                        Token = ""
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("NomineeController -- GetRelationList " + HttpStatusCode.NotFound + ",Failed" + "Errorline" + ex.Source + "");
                _logger.LogError(ex.Message);
                return new ResultModel()
                {
                    Code = HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Data = null
                };
            }
        }

        #endregion
    }
}
