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

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    [Extension("XR_ANDROID_face_tracking")]
    public unsafe partial class AndroidFaceTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_face_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] FaceTrackerANDROID* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] ref FaceTrackerANDROID faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceTrackerCreateInfoANDROID createInfo, [Count(Count = 0)] FaceTrackerANDROID* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerANDROID", Convention = CallingConvention.Winapi)]
        public partial Result CreateFaceTracker([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceTrackerCreateInfoANDROID createInfo, [Count(Count = 0)] ref FaceTrackerANDROID faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFaceTrackerANDROID", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFaceTracker([Count(Count = 0)] FaceTrackerANDROID faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceCalibrationStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceCalibrationState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0)] uint* faceIsCalibratedOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceCalibrationStateANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetFaceCalibrationState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0)] ref uint faceIsCalibratedOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceStateGetInfoANDROID* getInfo, [Count(Count = 0)] FaceStateANDROID* faceStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceStateGetInfoANDROID* getInfo, [Count(Count = 0)] ref FaceStateANDROID faceStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceStateANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceStateGetInfoANDROID getInfo, [Count(Count = 0)] FaceStateANDROID* faceStateOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceStateANDROID", Convention = CallingConvention.Winapi)]
        public partial Result GetFaceState([Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceStateGetInfoANDROID getInfo, [Count(Count = 0)] ref FaceStateANDROID faceStateOutput);

        public AndroidFaceTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

