using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.WeChat
{
    public class MpAppConfig : EntityBase<Guid>
    {
        public string AppName { get; set; }
        public string AppID { get; set; }
        public string AppSecret { get; set; }
        public string AppQrCode { get; set; }
        public bool ActiveStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
