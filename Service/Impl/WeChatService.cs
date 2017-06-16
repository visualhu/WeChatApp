using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.WeChat;
using Service.Interface;

namespace Service.WeChat
{
    public class WeChatService : IWeChatService
    {
        private readonly IMpAppConfigRepository _appConfigRepository;

        public WeChatService(IMpAppConfigRepository appConfigRepository)
        {
            _appConfigRepository = appConfigRepository;
        }

        public MpAppConfig GetMpAppConfig()
        {
            return _appConfigRepository.Get();
        }

        public void AddMpAppConfig(MpAppConfig config)
        {
            _appConfigRepository.Add(config);
        }
    }
}
