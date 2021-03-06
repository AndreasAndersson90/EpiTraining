﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework.Localization;
using EPiServer.Framework.Web;
using EPiServer.Web;

namespace AlloyTrainingFundamentals.Business.DisplayChannels
{
    public class MobileDisplayChannel : DisplayChannel
    {
        public override string ChannelName => RenderingTags.Mobile;
        public override string ResolutionId => "iphone5";



        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }
        
    }
}