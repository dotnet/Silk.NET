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
    [Extension("XR_MSFT_perception_anchor_interop")]
    public unsafe partial class MsftPerceptionAnchorInterop : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_perception_anchor_interop";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPerceptionAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorFromPerceptionAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] Silk.NET.Core.Native.IUnknown* perceptionAnchor, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPerceptionAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorFromPerceptionAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] Silk.NET.Core.Native.IUnknown* perceptionAnchor, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPerceptionAnchorMSFT")]
        public unsafe partial Result CreateSpatialAnchorFromPerceptionAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ref Silk.NET.Core.Native.IUnknown perceptionAnchor, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPerceptionAnchorMSFT")]
        public partial Result CreateSpatialAnchorFromPerceptionAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ref Silk.NET.Core.Native.IUnknown perceptionAnchor, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrTryGetPerceptionAnchorFromSpatialAnchorMSFT")]
        public unsafe partial Result TryGetPerceptionAnchorFromSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] SpatialAnchorMSFT anchor, [Count(Count = 0)] Silk.NET.Core.Native.IUnknown** perceptionAnchor);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrTryGetPerceptionAnchorFromSpatialAnchorMSFT")]
        public unsafe partial Result TryGetPerceptionAnchorFromSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0)] SpatialAnchorMSFT anchor, [Count(Count = 0)] ref Silk.NET.Core.Native.IUnknown* perceptionAnchor);

        public MsftPerceptionAnchorInterop(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

