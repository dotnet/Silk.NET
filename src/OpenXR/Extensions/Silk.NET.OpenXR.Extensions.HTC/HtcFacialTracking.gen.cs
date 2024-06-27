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

namespace Silk.NET.OpenXR.Extensions.HTC
{
    [Extension("XR_HTC_facial_tracking")]
    public unsafe partial class HtcFacialTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTC_facial_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] FacialTrackerHTC* facialTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] ref FacialTrackerHTC facialTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FacialTrackerCreateInfoHTC createInfo, [Count(Count = 0)] FacialTrackerHTC* facialTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialTrackerHTC", Convention = CallingConvention.Winapi)]
        public partial Result CreateFacialTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FacialTrackerCreateInfoHTC createInfo, [Count(Count = 0)] ref FacialTrackerHTC facialTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFacialTrackerHTC", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFacialTrackerHtc([Count(Count = 0)] FacialTrackerHTC facialTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionsHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialExpressionsHtc([Count(Count = 0)] FacialTrackerHTC facialTracker, [Count(Count = 0)] FacialExpressionsHTC* facialExpressions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionsHTC", Convention = CallingConvention.Winapi)]
        public partial Result GetFacialExpressionsHtc([Count(Count = 0)] FacialTrackerHTC facialTracker, [Count(Count = 0)] ref FacialExpressionsHTC facialExpressions);

        public HtcFacialTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

