using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenBot
{
    class cadenBot
    {
        DiscordClient discord;

        public cadenBot()
        {
            discord = new DiscordClient(x =>
            {
                x.LogLevel - LogSeverity.Info;
                x.LogHandler - Log;
            });

            discord.ExecuteAndWait(async ()=>
            {
                await discord.Connect("NDM5NTI5MjUxMDYyOTM5NjQ5.DcUfDw.VQnAnAMVC6iy18sWStfJBuFXeaA");
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Consone.WriteLine(e.Message);
        }
    }
}