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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_hand_tracking")]
    public unsafe partial class ExtHandTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_hand_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] ref HandTrackerEXT handTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandTrackerCreateInfoEXT createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandTrackerCreateInfoEXT createInfo, [Count(Count = 0)] ref HandTrackerEXT handTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyHandTrackerEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroyHandTracker([Count(Count = 0)] HandTrackerEXT handTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] ref HandJointLocationsEXT locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandJointsLocateInfoEXT locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT", Convention = CallingConvention.Winapi)]
        public partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HandJointsLocateInfoEXT locateInfo, [Count(Count = 0)] ref HandJointLocationsEXT locations);

        public ExtHandTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

