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
    [Extension("XR_FB_eye_tracking_social")]
    public unsafe partial class FBEyeTrackingSocial : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_eye_tracking_social";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateEyeTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateEyeTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeTrackerCreateInfoFB* createInfo, [Count(Count = 0)] EyeTrackerFB* eyeTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateEyeTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateEyeTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeTrackerCreateInfoFB* createInfo, [Count(Count = 0)] ref EyeTrackerFB eyeTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateEyeTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateEyeTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EyeTrackerCreateInfoFB createInfo, [Count(Count = 0)] EyeTrackerFB* eyeTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateEyeTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateEyeTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EyeTrackerCreateInfoFB createInfo, [Count(Count = 0)] ref EyeTrackerFB eyeTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyEyeTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyEyeTrackerFB([Count(Count = 0)] EyeTrackerFB eyeTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetEyeGazesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEyeGazesFB([Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeGazesInfoFB* gazeInfo, [Count(Count = 0)] EyeGazesFB* eyeGazes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetEyeGazesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEyeGazesFB([Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeGazesInfoFB* gazeInfo, [Count(Count = 0)] ref EyeGazesFB eyeGazes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetEyeGazesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetEyeGazesFB([Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EyeGazesInfoFB gazeInfo, [Count(Count = 0)] EyeGazesFB* eyeGazes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetEyeGazesFB", Convention = CallingConvention.Winapi)]
        public partial Result GetEyeGazesFB([Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EyeGazesInfoFB gazeInfo, [Count(Count = 0)] ref EyeGazesFB eyeGazes);

        public FBEyeTrackingSocial(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

