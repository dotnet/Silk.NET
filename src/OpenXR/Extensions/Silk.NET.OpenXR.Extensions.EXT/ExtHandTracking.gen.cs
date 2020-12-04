// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] ref HandTrackerEXT handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public unsafe partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in HandTrackerCreateInfoEXT createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public partial Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in HandTrackerCreateInfoEXT createInfo, [Count(Count = 0)] ref HandTrackerEXT handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyHandTrackerEXT")]
        public partial Result DestroyHandTracker([Count(Count = 0)] HandTrackerEXT handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] ref HandJointLocationsEXT locations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public unsafe partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] in HandJointsLocateInfoEXT locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public partial Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] in HandJointsLocateInfoEXT locateInfo, [Count(Count = 0)] ref HandJointLocationsEXT locations);

        public ExtHandTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

