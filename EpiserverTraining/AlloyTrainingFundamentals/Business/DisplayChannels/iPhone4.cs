using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTrainingFundamentals.Business.DisplayChannels
{
    public class iPhone4 : IDisplayResolution
    {
       
            public string Id => "iphone4";
            public string Name => "iPhone 4 (320 x 480)";
            public int Width => 320;
            public int Height => 480;
        
    }
}