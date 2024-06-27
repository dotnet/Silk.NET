// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.VARJO
{
    [Extension("XR_VARJO_marker_tracking")]
    public unsafe partial class VarjoMarkerTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_VARJO_marker_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceVARJO", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceVarjo([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoVARJO* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceVARJO", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceVarjo([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoVARJO* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceVARJO", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateMarkerSpaceVarjo([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerSpaceCreateInfoVARJO createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateMarkerSpaceVARJO", Convention = CallingConvention.Winapi)]
        public partial Result CreateMarkerSpaceVarjo([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MarkerSpaceCreateInfoVARJO createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerSizeVARJO", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMarkerSizeVarjo([Count(Count = 0)] Session session, [Count(Count = 0)] ulong markerId, [Count(Count = 0)] Extent2Df* size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetMarkerSizeVARJO", Convention = CallingConvention.Winapi)]
        public partial Result GetMarkerSizeVarjo([Count(Count = 0)] Session session, [Count(Count = 0)] ulong markerId, [Count(Count = 0)] ref Extent2Df size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetMarkerTrackingPredictionVARJO", Convention = CallingConvention.Winapi)]
        public partial Result SetMarkerTrackingPredictionVarjo([Count(Count = 0)] Session session, [Count(Count = 0)] ulong markerId, [Count(Count = 0)] uint enable);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetMarkerTrackingTimeoutVARJO", Convention = CallingConvention.Winapi)]
        public partial Result SetMarkerTrackingTimeoutVarjo([Count(Count = 0)] Session session, [Count(Count = 0)] ulong markerId, [Count(Count = 0)] long timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetMarkerTrackingVARJO", Convention = CallingConvention.Winapi)]
        public partial Result SetMarkerTrackingVarjo([Count(Count = 0)] Session session, [Count(Count = 0)] uint enabled);

        public VarjoMarkerTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

