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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_body_tracking")]
    public unsafe partial class FBBodyTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_body_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoFB* createInfo, [Count(Count = 0)] BodyTrackerFB* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoFB* createInfo, [Count(Count = 0)] ref BodyTrackerFB bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyTrackerCreateInfoFB createInfo, [Count(Count = 0)] BodyTrackerFB* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateBodyTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyTrackerCreateInfoFB createInfo, [Count(Count = 0)] ref BodyTrackerFB bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyBodyTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyBodyTrackerFB([Count(Count = 0)] BodyTrackerFB bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetBodySkeletonFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetBodySkeletonFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0)] BodySkeletonFB* skeleton);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetBodySkeletonFB", Convention = CallingConvention.Winapi)]
        public partial Result GetBodySkeletonFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0)] ref BodySkeletonFB skeleton);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoFB* locateInfo, [Count(Count = 0)] BodyJointLocationsFB* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoFB* locateInfo, [Count(Count = 0)] ref BodyJointLocationsFB locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyJointsLocateInfoFB locateInfo, [Count(Count = 0)] BodyJointLocationsFB* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsFB", Convention = CallingConvention.Winapi)]
        public partial Result LocateBodyJointsFB([Count(Count = 0)] BodyTrackerFB bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BodyJointsLocateInfoFB locateInfo, [Count(Count = 0)] ref BodyJointLocationsFB locations);

        public FBBodyTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

