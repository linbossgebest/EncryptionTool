using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public class InfoModel
    {
        //public string UserName { get; set; }

        //public string PassWord { get; set; }

        //public List<string> IpList { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// ip列表
        /// </summary>
        public string IPList { get; set; }

        /// <summary>
        /// 对外扩展
        /// </summary>
        public string ExpandList { get; set; }
    }
}
