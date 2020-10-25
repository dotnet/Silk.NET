// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_spatial_anchor")]
    public unsafe partial class MsftSpatialAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_anchor";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SpatialAnchorCreateInfoMSFT createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT")]
        public partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SpatialAnchorCreateInfoMSFT createInfo, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SpatialAnchorSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT")]
        public partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SpatialAnchorSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialAnchorMSFT")]
        public partial Result DestroySpatialAnchorMsft([Count(Count = 0)] SpatialAnchorMSFT anchor);

        public MsftSpatialAnchor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

