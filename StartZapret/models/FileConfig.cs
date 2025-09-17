using System.Runtime.Serialization;

namespace StartZapret.models;

[DataContract]
class FileConfig
{
    [DataMember]
    public string _pathName { get; set; }
    [DataMember]
    public string _urlName { get; set; }
}
