﻿using System.Net;

namespace Texnomic.DNS.Middlewares
{
    public class GoogleTLSMiddleware : TLSMiddleware
    {
        public GoogleTLSMiddleware() : base(IPAddress.Parse("8.8.8.8"),
            "3082010A02820101009D1FA4EF5D3E883319ABE79A6DC82BF72A3C1D312EAD5DAB4143368F042D45FA819BC8DD1E3F0227A2A2398DB945E0AB3F1AB143A87F83884BFCCB40230DAA673C2A441ECADF392ABBDB7CA3677DCE04BB92480BBC5F64AACA1A5BB295A66A0EDCE7060F05B88BCA08D0AB36290B192815504E58972D60AFF9F7EC8DAB488107E32E2F89B0DBCDF5CE022530EB32D1740826FB7584A81225BACC70005B74453EADCF3EE2A0AE75E9B3D85A3416A10D7670CD1FFE35D43C03A371DDFBE4F687BCF902DECB68552242F0211FA9572E61D3BBBFEEE782219AE5793608EE06800B347D6340732521EEB813AB544BB603148CEAF7C1AAA62EF4DA2AC23415052C16B90203010001")
        {
        }
    }
}
