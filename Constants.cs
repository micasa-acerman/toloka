using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TolokaManager.Models
{
    public class Constants
    {
        private Constants() { }

        private const string BASE_URL = "https://toloka.yandex.ru/api/v1/";
        public const string ASSIGMENTS_URL = BASE_URL+"assignments";
        public const string ATTACHMENTS_URL = BASE_URL + "attachments";

        public const string STATUS_ACCEPTED = "ACCEPTED";
        public const string STATUS_SUBMITTED = "SUBMITTED";
        public const string OAUTH_TOKEN = "TEXT TOKEN HERE";

    }
}
