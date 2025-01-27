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
    [Extension("XR_HTC_body_tracking")]
    public unsafe partial class HtcBodyTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTC_body_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] BodyTrackerHTC* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] ref BodyTrackerHTC bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyTrackerCreateInfoHTC createInfo, [Count(Count = 0)] BodyTrackerHTC* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerHTC", Convention = CallingConvention.Winapi)]
        public partial Result CreateBodyTrackerHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyTrackerCreateInfoHTC createInfo, [Count(Count = 0)] ref BodyTrackerHTC bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyBodyTrackerHTC", Convention = CallingConvention.Winapi)]
        public partial Result DestroyBodyTrackerHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetBodySkeletonHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBodySkeletonHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] uint skeletonGenerationId, [Count(Count = 0)] BodySkeletonHTC* skeleton);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetBodySkeletonHTC", Convention = CallingConvention.Winapi)]
        public partial Result GetBodySkeletonHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] uint skeletonGenerationId, [Count(Count = 0)] ref BodySkeletonHTC skeleton);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoHTC* locateInfo, [Count(Count = 0)] BodyJointLocationsHTC* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoHTC* locateInfo, [Count(Count = 0)] ref BodyJointLocationsHTC locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyJointsLocateInfoHTC locateInfo, [Count(Count = 0)] BodyJointLocationsHTC* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsHTC", Convention = CallingConvention.Winapi)]
        public partial Result LocateBodyJointsHtc([Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyJointsLocateInfoHTC locateInfo, [Count(Count = 0)] ref BodyJointLocationsHTC locations);

        public HtcBodyTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

