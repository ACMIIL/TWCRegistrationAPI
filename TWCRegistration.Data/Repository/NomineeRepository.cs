using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TWCRegistration.API.ConnectionClass;
using TWCRegistration.Core.Configurations;
using TWCRegistration.Core.Models.Individual;


namespace TWCRegistration.Data.Repository
{
    public class NomineeRepository : INomineeRepository
    {
        #region Global Varibable
        private readonly IDbConnection _dbconnection;
        #endregion

        #region Constructor
        public NomineeRepository(IEnumerable<IDBConnection> connections)
        {
            if (connections.FirstOrDefault(x => x.ConnectionName == "WPConnection") != null)
            {
                _dbconnection = connections.FirstOrDefault(x => x.ConnectionName == "WPConnection").Connection;
            }
        }
        #endregion


        #region Method
        public async Task<List<RelationshipModel>> GetRelationshipName()
        {
            var dp = new DynamicParameters();
            var relationshipModel = await _dbconnection.QueryAsync<RelationshipModel>(
                  sql: StoredProcedure.Getrelation,
                  param: dp,
                  commandType: CommandType.StoredProcedure);
            return relationshipModel.ToList();
        }

        public async Task<string> InsertORUpdateNominee(NomineeModel request)
        {
            DateTime dob = Convert.ToDateTime(request.DOBNominee);
            string nomineedob = dob.ToString("yyyy-MM-dd");

            var dp = new DynamicParameters();
            dp.Add("@UserId", request.UserId);
            dp.Add("@NomineeFirstName", request.NomineeFirstName);
            dp.Add("@NomineeMiddleName", request.NomineeMiddleName);
            dp.Add("@NomineeLastName", request.NomineeLastName);
            dp.Add("@DOBNominee", nomineedob);
            dp.Add("@IsMinor", request.IsMinor);
            dp.Add("@PanNumber", request.PanNumber);
            dp.Add("@RelationshipType", request.RelationshipType);
            dp.Add("@FileName", request.FileName);
            dp.Add("@FilePath", request.FilePath);
            var result = await _dbconnection.ExecuteScalarAsync<string>(
                   sql: StoredProcedure.InsertUpdate_UserNomineeDetails,
                   param: dp,
                   commandType: CommandType.StoredProcedure);

            return result.ToString();
        }

        public async Task<string> InsertORUpdateNomineeGuardian(NomineeGuardianModel request)
        {
            DateTime dob = Convert.ToDateTime(request.DOB);
            string nomineedob = dob.ToString("yyyy-MM-dd");

            var dp = new DynamicParameters();
            dp.Add("@UserId", request.UserId);
            dp.Add("@GuardianFirstName", request.GuardianFirstName);
            dp.Add("@GuardianMiddleName", request.GuardianMiddleName);
            dp.Add("@GuardianLastName", request.GuardianLastName);
            dp.Add("@GuardianRelationshipType", request.GuardianRelationshipType);
            dp.Add("@PanNumber", request.PanNumber);
            dp.Add("@FileName", request.FileName);
            dp.Add("@FilePath", request.FilePath);
            dp.Add("@DOB", nomineedob);
            var result = await _dbconnection.ExecuteScalarAsync<string>(
                   sql: StoredProcedure.InsertUpdate_UserNomineeGuardianDetails,
                   param: dp,
                   commandType: CommandType.StoredProcedure);

            return result.ToString();
        }

        #endregion
    }
}
