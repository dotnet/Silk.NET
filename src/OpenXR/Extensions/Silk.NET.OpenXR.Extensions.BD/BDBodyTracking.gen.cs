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

namespace Silk.NET.OpenXR.Extensions.BD
{
    [Extension("XR_BD_body_tracking")]
    public unsafe partial class BDBodyTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_body_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoBD* createInfo, [Count(Count = 0)] BodyTrackerBD* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoBD* createInfo, [Count(Count = 0)] ref BodyTrackerBD bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateBodyTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BodyTrackerCreateInfoBD createInfo, [Count(Count = 0)] BodyTrackerBD* bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateBodyTrackerBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateBodyTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BodyTrackerCreateInfoBD createInfo, [Count(Count = 0)] ref BodyTrackerBD bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyBodyTrackerBD", Convention = CallingConvention.Winapi)]
        public partial Result DestroyBodyTrackerBD([Count(Count = 0)] BodyTrackerBD bodyTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsBD([Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoBD* locateInfo, [Count(Count = 0)] BodyJointLocationsBD* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsBD([Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoBD* locateInfo, [Count(Count = 0)] ref BodyJointLocationsBD locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateBodyJointsBD([Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BodyJointsLocateInfoBD locateInfo, [Count(Count = 0)] BodyJointLocationsBD* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateBodyJointsBD", Convention = CallingConvention.Winapi)]
        public partial Result LocateBodyJointsBD([Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BodyJointsLocateInfoBD locateInfo, [Count(Count = 0)] ref BodyJointLocationsBD locations);

        public BDBodyTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

