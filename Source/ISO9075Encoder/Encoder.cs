using System;

namespace ISO9075Encoder
{
    public class Encoder
    {
        public static string Encode(string source) => System.Xml.XmlConvert.EncodeName(source);
        public static string Decode(string iso9075String) => System.Xml.XmlConvert.DecodeName(iso9075String);
    }
}
