using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.WeChat
{
    public interface IMpAppConfigRepository
    {
        MpAppConfig Get();
        void Add(MpAppConfig config);
    }
}
