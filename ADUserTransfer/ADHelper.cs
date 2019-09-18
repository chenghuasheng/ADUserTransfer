using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace ADUserTransfer
{
    public class ADHelper
    {
        #region 构造单例
        private ADHelper() { }
        public static readonly ADHelper Instance = new ADHelper();
        #endregion       

        ///
        ///域名
        ///
        private static string DomainName = "10.8.3.249";//在有可解析的域名的情况下，请写域名，否则请填写IP地址
        /// LDAP绑定路径
        ///
        private static string ADPath = "LDAP://" + DomainName;
        ///
        ///登录帐号
        ///
        private static string ADUser = "administrator"; //administrator
        ///
        ///登录密码
        ///
        private static string ADPassword = "11235813@a";

        private DirectoryEntry rootEntry = null;
        public DirectoryEntry DomainRootEntry
        {
            get
            {
                if (rootEntry == null)
                {
                    try
                    {
                        rootEntry = new DirectoryEntry(ADPath, ADUser, ADPassword);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
                return rootEntry;
            }
        }

        /// <summary>
        ///根据用户公共名称取得用户的对象
        ///用户公共名称
        ///如果找到该用户，则返回用户的对象；否则返回 null
        /// </summary>
        /// <param name="cnName"></param>
        /// <returns></returns>
        public DirectoryEntry GetUser(string cnName, DirectoryEntry parentEntry = null)
        {
            string filter = "(&(&(objectCategory=person)(objectClass=user))(cn=" + cnName + "))";
            return this.GetEntry(filter, parentEntry);
        }

        /// <summary>
        ///根据组名取得用户组的对象
        ///组名
        /// </summary>
        /// <param name="cnName"></param>
        /// <returns></returns>
        public DirectoryEntry GetGroup(string cnName, DirectoryEntry parentEntry = null)
        {
            string filter = "(&(objectClass=group)(cn=" + cnName + "))";
            return this.GetEntry(filter, parentEntry);
        }

        public DirectoryEntry GetOrgUnit(string ouName, DirectoryEntry parentEntry = null)
        {
            string filter = "(&(objectClass=organizationalUnit)(ou=" + ouName + "))";
            return this.GetEntry(filter, parentEntry);
        }

        public DirectoryEntry GetEntry(string filter, DirectoryEntry parentEntry = null)
        {
            if (parentEntry == null) parentEntry = this.DomainRootEntry;
            DirectorySearcher deSearch = new DirectorySearcher(this.DomainRootEntry);
            deSearch.Filter = filter;
            deSearch.SearchScope = SearchScope.Subtree;
            DirectoryEntry entry;
            try
            {
                SearchResult result = deSearch.FindOne();
                entry = result.GetDirectoryEntry();
                return entry;
            }
            catch
            {
                return null;
            }
        }

        public List<DirectoryEntry> GetEntries(string filter, DirectoryEntry parentEntry = null)
        {
            if (parentEntry == null) parentEntry = this.DomainRootEntry;
            DirectorySearcher deSearch = new DirectorySearcher(this.DomainRootEntry);
            deSearch.Filter = filter;
            deSearch.SearchScope = SearchScope.Subtree;
            List<DirectoryEntry> entries = new List<DirectoryEntry>();
            try
            {
                SearchResultCollection results = deSearch.FindAll();
                foreach (SearchResult result in results)
                {
                    entries.Add(result.GetDirectoryEntry());
                }
                return entries;
            }
            catch
            {
                return null;
            }
        }

        public List<DirectoryEntry> GetGroups(string cnName=null, DirectoryEntry parentEntry = null)
        {
            string filter;
            if (cnName == null || cnName == "") filter = "(objectClass=group)";
            else filter = "(&(objectClass=group)(cn=" + cnName + "))";
            return this.GetEntries(filter, parentEntry);
        }

        public List<DirectoryEntry> GetOrgUnits(string ouName=null, DirectoryEntry parentEntry = null)
        {
            string filter;
            if (ouName == null || ouName == "") filter = "(objectClass=organizationalUnit)";
            else filter = "(&(objectClass=organizationalUnit)(ou=" + ouName + "))";
            return this.GetEntries(filter, parentEntry);
        }

        public List<DirectoryEntry> GetUsers(string cnName=null, DirectoryEntry parentEntry = null)
        {
            string filter;
            if (cnName == null || cnName == "") filter = "(&(objectCategory=person)(objectClass=user))";
            else filter = "(&(&(objectCategory=person)(objectClass=user))(cn=" + cnName + "))";
            return this.GetEntries(filter, parentEntry);
        }

        public void AddUserToGroup(DirectoryEntry oUser, DirectoryEntry oGroup)
        {
            if (oGroup != null && oUser != null)
            {
                oGroup.Properties["member"].Add(oUser.Properties["distinguishedName"].Value);
                oGroup.CommitChanges();
            }
        }

        public void RemoveUserFromGroup(DirectoryEntry oUser, DirectoryEntry oGroup)
        {
            if (oGroup != null && oUser != null)
            {
                oGroup.Properties["member"].Remove(oUser.Properties["distinguishedName"].Value);
                oGroup.CommitChanges();
            }
        }
    }
}
