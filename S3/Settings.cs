using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class Settings
    {
        public bool tintEnabled = false;
        public string tintColor = "#FFF";
        public int serverPort = 8081;
        public InformationUpdate streamData;

        public string smashgg { get; internal set; }
        public string StreamName { get; set; }
        public int streamId;
    }
}
