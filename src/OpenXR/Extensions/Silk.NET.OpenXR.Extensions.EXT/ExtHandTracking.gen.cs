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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_hand_tracking")]
    public abstract unsafe partial class ExtHandTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_hand_tracking";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public abstract unsafe Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandTrackerEXT")]
        public abstract Result CreateHandTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref HandTrackerCreateInfoEXT createInfo, [Count(Count = 0)] ref HandTrackerEXT handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyHandTrackerEXT")]
        public abstract Result DestroyHandTracker([Count(Count = 0)] HandTrackerEXT handTracker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public abstract unsafe Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateHandJointsEXT")]
        public abstract Result LocateHandJoints([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ref HandJointsLocateInfoEXT locateInfo, [Count(Count = 0)] ref HandJointLocationsEXT locations);

        public ExtHandTracking(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

