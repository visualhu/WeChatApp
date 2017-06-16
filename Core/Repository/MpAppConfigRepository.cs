using Core.Dapper;
using Core.Domain.WeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class MpAppConfigRepository : DbRepository, IMpAppConfigRepository
    {
        public MpAppConfigRepository(IDbContext context) : base(context)
        {

        }

        public MpAppConfig Get()
        {
            return Context.Query<MpAppConfig>("select * from mp_appconfig order by createdon desc limit 1;").FirstOrDefault();
        }

        public void Add(MpAppConfig config)
        {
            Context.Execute("insert into mp_appconfig values (@ID,@AppName,@AppID,@AppSecret,@AppQrCode,@ActiveStatus,@CreatedOn,@CreatedBy);", config);
        }
    }
}
