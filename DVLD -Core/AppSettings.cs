using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core
{
    public static class AppSettings
    {
        public static string PersonImagesPath
       => ConfigurationManager.AppSettings["PersonImagesPath"];

        public static string RememberMeFilePath
            => ConfigurationManager.AppSettings["RememberMeFilePath"];
    }
}
