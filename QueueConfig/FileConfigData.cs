using System.Collections.Generic;

namespace Tobasa
{
    public class Options
    {
        public string securitySalt;
        public string providerType;
    }

    public class SqliteOptions
    {
        public string dbFilePath;

        private string _connStr;
        public string connString
        {
            get
            {
                _connStr = $"Data Source={dbFilePath};Version=3;";
                return _connStr;
            }
            set
            {
                _connStr = value;
            }
        }
    }

    public struct SqlOptions
    {
        public string hostAddr;
        public string tcpPort;
        public string database;
        public string username;
        public string password;

        public string securitySalt;

        private string _passEnc;
        private string _connStr;

        public string providerType;

        public string connString
        {
            get
            {
                if (providerType == "MSSQL")
                    _connStr = $"Server={hostAddr},{tcpPort};Database={database};User ID={username};Trusted_Connection=False";
                else if (providerType == "MYSQL")
                    _connStr = $"Data Source={hostAddr},{tcpPort};User ID={username};Initial Catalog={database};";
                else if (providerType == "PGSQL")
                    _connStr = $"Host={hostAddr};Username={username};Database={database};Port={tcpPort};";

                return _connStr;
            }
            set
            {
                _connStr = value;
            }
        }

        public string passwordEnc
        {
            get
            {
                _passEnc = Util.EncryptPassword(password, securitySalt);
                return _passEnc;
            }
            set
            {
                _passEnc = value;
            }
        }
    }

    public struct QueOptions
    {
        public string hostAddr;
        public string tcpPort;
        public string username;
        public string password;

        public string securitySalt;
        public string passwordEnc
        {
            get
            {
                _passEnc = Util.EncryptPassword(password, securitySalt);
                return _passEnc;
            }
            set
            {
                _passEnc = value;
            }
        }

        private string _passEnc;
    }

    public class ConfigFile
    {
        public string name;
        public string path;
        public bool backup = false;
        public bool exists = false;
    }

    public class PostConfig
    {
        public string code; 
        public string name;
        public string caption;
    }

    public class PostConfigDisplay : PostConfig
    {
        public bool visible;
        public bool playAudio;
        public string infoText;
    }

    public class PostConfigTicket : PostConfig
    {
        public bool enabled;
        public bool visible;
        public int printCopies;
        public string ticketHeader;
    }

    public class PostConfigCaller : PostConfig
    {
    }

    public class DefaultData
    {
        public static Dictionary<string, PostConfigDisplay> CreatePostConfigDisplayMap()
        {
            Dictionary<string, PostConfigDisplay> map = new Dictionary<string, PostConfigDisplay>
            {
                {
                    "POST0",
                    new PostConfigDisplay
                    {
                        code = "POST0",
                        name = "Poli Paru",
                        caption = "POLI PARU",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI PARU"
                    }
                },
                {
                    "POST1",
                    new PostConfigDisplay
                    {
                        code = "POST1",
                        name = "Poli Mata",
                        caption = "POLI MATA",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI MATA"
                    }
                },
                {
                    "POST2",
                    new PostConfigDisplay
                    {
                        code = "POST2",
                        name = "Poli Kandungan",
                        caption = "POLI KANDUNGAN",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI KANDUNGAN"
                    }
                },
                {
                    "POST3",
                    new PostConfigDisplay
                    {
                        code = "POST3",
                        name = "Poli Bedah",
                        caption = "POLI BEDAH",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI BEDAH"
                    }
                },
                {
                    "POST4",
                    new PostConfigDisplay
                    {
                        code = "POST4",
                        name = "Poli Anak",
                        caption = "POLI ANAK",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI ANAK"
                    }
                },
                {
                    "POST5",
                    new PostConfigDisplay
                    {
                        code = "POST5",
                        name = "Poli Ortopedi",
                        caption = "POLI ORTOPEDI",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI ORTOPEDI"
                    }
                },
                {
                    "POST6",
                    new PostConfigDisplay
                    {
                        code = "POST6",
                        name = "Poli Jantung",
                        caption = "POLI JANTUNG",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI JANTUNG"
                    }
                },
                {
                    "POST7",
                    new PostConfigDisplay
                    {
                        code = "POST7",
                        name = "Poli THT",
                        caption = "POLI THT",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI THT"
                    }
                },
                {
                    "POST8",
                    new PostConfigDisplay
                    {
                        code = "POST8",
                        name = "Poli Kulit",
                        caption = "POLI KULIT",
                        visible = true,
                        playAudio = true,
                        infoText = "Poli Kulit"
                    }
                },
                {
                    "POST9",
                    new PostConfigDisplay
                    {
                        code = "POST9",
                        name = "Poli Dalam",
                        caption = "POLI DALAM",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI DALAM"
                    }
                },
                {
                    "POST10",
                    new PostConfigDisplay
                    {
                        code = "POST10",
                        name = "Poli Saraf",
                        caption = "POLI SARAF",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI SARAF"
                    }
                },
                {
                    "POST11",
                    new PostConfigDisplay
                    {
                        code = "POST11",
                        name = "Poli Psikiatri",
                        caption = "POLI PSIKIATRI",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI PSIKIATRI"
                    }
                },
                {
                    "POST12",
                    new PostConfigDisplay
                    {
                        code = "POST12",
                        name = "Poli Paru",
                        caption = "POLI PARU",
                        visible = true,
                        playAudio = true,
                        infoText = "POLI PARU"
                    }
                },
                {
                    "POST13",
                    new PostConfigDisplay
                    {
                        code = "POST13",
                        name = "Rehab Medik",
                        caption = "REHAB MEDIK",
                        visible = true,
                        playAudio = true,
                        infoText = "REHAB MEDIK"
                    }
                }
            };

            return map;
        }

        public static Dictionary<string, PostConfigTicket> CreatePostConfigTicketMap()
        {
            Dictionary<string, PostConfigTicket> map = new Dictionary<string, PostConfigTicket>
            {
                {
                    "POST0",
                    new PostConfigTicket
                    {
                        code = "POST0",
                        name = "Poli Gigi",
                        caption = "POLI GIGI",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI GIGI"
                    }
                },
                {
                    "POST1",
                    new PostConfigTicket
                    {
                        code = "POST1",
                        name = "Poli Mata",
                        caption = "POLI MATA",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI MATA"
                    }
                },
                {
                    "POST2",
                    new PostConfigTicket
                    {
                        code = "POST2",
                        name = "Poli Kandungan",
                        caption = "POLI KANDUNGAN",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI KANDUNGAN"
                    }
                },
                {
                    "POST3",
                    new PostConfigTicket
                    {
                        code = "POST3",
                        name = "Poli Bedah",
                        caption = "POLI BEDAH",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI BEDAH"
                    }
                },
                {
                    "POST4",
                    new PostConfigTicket
                    {
                        code = "POST4",
                        name = "Poli Anak",
                        caption = "POLI ANAK",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI ANAK"
                    }
                },
                {
                    "POST5",
                    new PostConfigTicket
                    {
                        code = "POST5",
                        name = "Poli Ortopedi",
                        caption = "POLI ORTOPEDI",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI ORTOPEDI"
                    }
                },
                {
                    "POST6",
                    new PostConfigTicket
                    {
                        code = "POST6",
                        name = "Poli Jantung",
                        caption = "POLI JANTUNG",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI JANTUNG"
                    }
                },
                {
                    "POST7",
                    new PostConfigTicket
                    {
                        code = "POST7",
                        name = "Poli THT",
                        caption = "POLI THT",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI THT"
                    }
                },
                {
                    "POST8",
                    new PostConfigTicket
                    {
                        code = "POST8",
                        name = "Poli Kulit",
                        caption = "POLI KULIT",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "Poli Kulit"
                    }
                },
                {
                    "POST9",
                    new PostConfigTicket
                    {
                        code = "POST9",
                        name = "Poli Dalam",
                        caption = "POLI DALAM",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI DALAM"
                    }
                },
                {
                    "POST10",
                    new PostConfigTicket
                    {
                        code = "POST10",
                        name = "Poli Saraf",
                        caption = "POLI SARAF",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI SARAF"
                    }
                },
                {
                    "POST11",
                    new PostConfigTicket
                    {
                        code = "POST11",
                        name = "Poli Psikiatri",
                        caption = "POLI PSIKIATRI",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI PSIKIATRI"
                    }
                },
                {
                    "POST12",
                    new PostConfigTicket
                    {
                        code = "POST12",
                        name = "Poli Paru",
                        caption = "POLI PARU",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "POLI PARU"
                    }
                },
                {
                    "POST13",
                    new PostConfigTicket
                    {
                        code = "POST13",
                        name = "Rehab Medik",
                        caption = "REHAB MEDIK",
                        enabled = true,
                        visible= true,
                        printCopies = 1,
                        ticketHeader = "REHAB MEDIK"
                    }
                }
            };

            return map;
        }

        public static Dictionary<string, PostConfigCaller> CreatePostConfigCallerMap()
        {
            Dictionary<string, PostConfigCaller> map = new Dictionary<string, PostConfigCaller>
            {
                {
                    "POST0",
                    new PostConfigCaller
                    {
                        code = "POST0",
                        name = "Poli Gigi",
                        caption = "Poli Gigi"
                    }
                },
                {
                    "POST1",
                    new PostConfigCaller
                    {
                        code = "POST1",
                        name = "Poli Mata",
                        caption = "Poli Mata"
                    }
                },
                {
                    "POST2",
                    new PostConfigCaller
                    {
                        code = "POST2",
                        name = "Poli Kandungan",
                        caption = "Poli Kandungan"
                    }
                },
                {
                    "POST3",
                    new PostConfigCaller
                    {
                        code = "POST3",
                        name = "Poli Bedah",
                        caption = "Poli Bedah"
                    }
                },
                {
                    "POST4",
                    new PostConfigCaller
                    {
                        code = "POST4",
                        name = "Poli Anak",
                        caption = "Poli Anak"
                    }
                },
                {
                    "POST5",
                    new PostConfigCaller
                    {
                        code = "POST5",
                        name = "Poli Ortopedi",
                        caption = "Poli Ortopedi"
                    }
                },
                {
                    "POST6",
                    new PostConfigCaller
                    {
                        code = "POST6",
                        name = "Poli Jantung",
                        caption = "Poli Jantung"
                    }
                },
                {
                    "POST7",
                    new PostConfigCaller
                    {
                        code = "POST7",
                        name = "Poli THT",
                        caption = "Poli THT"
                    }
                },
                {
                    "POST8",
                    new PostConfigCaller
                    {
                        code = "POST8",
                        name = "Poli Kulit",
                        caption = "Poli Kulit"
                    }
                },
                {
                    "POST9",
                    new PostConfigCaller
                    {
                        code = "POST9",
                        name = "Poli Dalam",
                        caption = "Poli Dalam"
                    }
                },
                {
                    "POST10",
                    new PostConfigCaller
                    {
                        code = "POST10",
                        name = "Poli Saraf",
                        caption = "Poli Saraf"
                    }
                },
                {
                    "POST11",
                    new PostConfigCaller
                    {
                        code = "POST11",
                        name = "Poli Psikiatri",
                        caption = "Poli Psikiatri"
                    }
                },
                {
                    "POST12",
                    new PostConfigCaller
                    {
                        code = "POST12",
                        name = "Poli Paru",
                        caption = "Poli Paru"
                    }
                },
                {
                    "POST13",
                    new PostConfigCaller
                    {
                        code = "POST13",
                        name = "Rehab Medik",
                        caption = "Rehab Medik"
                    }
                }
            };

            return map;
        }
    }
}
