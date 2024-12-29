using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    public class NIC
    {
        public string Manufacture { get; set; }
        public string MacAddress { get; set; }
        public Type type { get; set; }


        public static NIC Obj {  get; set; }

        private NIC(string _manufacture, string _mac, Type _type)
        {
            MacAddress = _mac;
            Manufacture = _manufacture;
            type = _type;
        }

        static NIC()
        {
            Obj = new NIC("test", "101010", Type.Ethernet);
        }


        public override string ToString()
        {
            return $"{Manufacture} : {MacAddress} : {type} ";
        }
    }
}
