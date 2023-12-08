using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeSaude3.Models
{
    internal class About
    {
        
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public string MoreInfoUrl { get; set; }

        public About()
        {
            this.Title = AppInfo.Name;
            this.Version = AppInfo.VersionString;
            this.Description = "Este aplicativo foi desenvolvido com o intuito do usuario poder anotar tudo referente a sua saude. Consultas,exames,tratamentos e etc...";
            this.Message = "Cuide-se!";
            this.MoreInfoUrl = "https://www.facebook.com/kyohei.matsuno.376?locale=pt_BR";
        }
    }
}
