using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectTemplate.Business.Entity.Table
{
    public sealed class WUser
    {
        public WUser() { }

        public decimal CodUser { get; private set; }
        public string DsUserName { get; private set; }
        public string DsName { get; private set; }
        public string DsPassword { get; private set; }
        public string DsEmail { get; private set; }
        public string DsCelular { get; private set; }
        public string DsPhone { get; private set; }
        public string DsFax { get; private set; }
        public string DsCep { get; private set; }
        public string DsAddress { get; private set; }
        public string DsDistrict { get; private set; }
        public string DsCity { get; private set; }
        public string StUserActive { get; private set; }
        public string StAdministrator { get; private set; }
        public string CodUserType { get; private set; }
        public string StColumnist { get; private set; }
        public int? CodCity { get; private set; }
        public string StEnabled { get; private set; }
        public string DsCpf { get; private set; }
        public string DsIdentification { get; private set; }
        public string DsContact { get; private set; }
        public int? CodState { get; private set; }
        public string DsZone { get; private set; }
        public string StNewsletter { get; private set; }
        public Guid CodUserUid { get; private set; }
        public decimal? CodUserSubstitution { get; private set; }
        public string StLoginType { get; private set; }
        public string StAbsent { get; private set; }
        public decimal? CodUserCreate { get; private set; }
        public string DsPhoto { get; private set; }
        public DateTime? DtLastPasswordChange { get; private set; }
        public int? NbLoginAttemptFailed { get; private set; }
        public string StAccountLocked { get; private set; }
        public string StAdministratorGlobal { get; private set; }

        public bool UsersActives(WUser user) => !string.IsNullOrEmpty(user.StUserActive) && user.StUserActive.Equals("1");
    }
}
