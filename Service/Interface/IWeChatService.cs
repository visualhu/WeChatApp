using Core.Domain.WeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IWeChatService
    {
        MpAppConfig GetMpAppConfig();

        void AddMpAppConfig(MpAppConfig config);
    }
}
