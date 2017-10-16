using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTrainingFundamentals.Business.DisplayChannels
{
    public class iPhone5 : IDisplayResolution
    {
        public string Id => "iphone5";
        public string Name => "iPhone 5 (320 x 568)";
        public int Width => 320;
        public int Height => 568;
    }
}