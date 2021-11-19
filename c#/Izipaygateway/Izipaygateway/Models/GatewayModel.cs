using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izipaygateway.Models
{
    public class GatewayModel
    {
        private const string _KEY_USER = "62114337";
        private const string _KEY_PASSWORD = "testpassword_t8DY7EZT5oF6IeGEljncoA00zSRQxu4gr1VH7NgNhsFMA";
        private const string _KEY_JS = "62114337:testpublickey_UbudXuMMngDU6ZbA7zkL1K7iV8kFnxQYjtyKc3j8tRcJj";
        private const string _KEY_SHA256 = "vg8VSiWelsfgFO8zwzTfuqM3u5Kfh1FjyUvBdllWdKBHw";
        private const string _URL_BASE = "https://api.micuentaweb.pe/";

        public string KEY_USER => _KEY_USER;
        public string KEY_PASSWORD => _KEY_PASSWORD;
        public string KEY_JS => _KEY_JS;
        public string KEY_SHA256 => _KEY_SHA256;
        public string URL_BASE => _URL_BASE;

    }
}
