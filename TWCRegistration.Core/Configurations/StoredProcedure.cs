using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWCRegistration.Core.Configurations
{
    public class StoredProcedure
    {
        #region Individual
        public const string Usp_GetMA_DetailsPDF = "Usp_GetMA_DetailsPDF";
        public const string EmailSendForEsign = "USP_EmailSend";
        public const string InsertPanData = "USP_INSERTPanData";
        public const string InsertEsignLink = "USP_InsertEsignLink";
        public const string SaveEsignDetails = "USP_SaveEsignDetails";
        public const string InsertUpdate_UserNomineeGuardianDetails = "InsertUpdate_UserNomineeGuardianDetails";
        public const string InsertUpdate_UserNomineeDetails = "InsertUpdate_UserNomineeDetails";
        public const string Getrelation = "GetRelationshipName";
        #endregion
    }
}
