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
    [Extension("XR_MSFT_spatial_anchor")]
    public abstract unsafe partial class MsftSpatialAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_anchor";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public abstract unsafe Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public abstract Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SpatialAnchorCreateInfoMSFT createInfo, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public abstract unsafe Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public abstract Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SpatialAnchorSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialAnchorMSFT")]
        public abstract Result DestroySpatialAnchorMsft([Count(Count = 0)] SpatialAnchorMSFT anchor);

        public MsftSpatialAnchor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

