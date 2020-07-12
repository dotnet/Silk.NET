// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_spatial_graph_bridge")]
    public abstract unsafe partial class MsftSpatialGraphBridge : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_graph_bridge";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT")]
        public abstract unsafe Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialGraphNodeSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT")]
        public abstract Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SpatialGraphNodeSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        public MsftSpatialGraphBridge(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

