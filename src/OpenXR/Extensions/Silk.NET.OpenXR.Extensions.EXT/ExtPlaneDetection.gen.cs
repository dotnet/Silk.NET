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
    [Extension("XR_EXT_plane_detection")]
    public unsafe partial class ExtPlaneDetection : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_plane_detection";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginPlaneDetectionEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BeginPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorBeginInfoEXT* beginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginPlaneDetectionEXT", Convention = CallingConvention.Winapi)]
        public partial Result BeginPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PlaneDetectorBeginInfoEXT beginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePlaneDetectorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePlaneDetector([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorCreateInfoEXT* createInfo, [Count(Count = 0)] PlaneDetectorEXT* planeDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePlaneDetectorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePlaneDetector([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorCreateInfoEXT* createInfo, [Count(Count = 0)] ref PlaneDetectorEXT planeDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePlaneDetectorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePlaneDetector([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PlaneDetectorCreateInfoEXT createInfo, [Count(Count = 0)] PlaneDetectorEXT* planeDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePlaneDetectorEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreatePlaneDetector([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PlaneDetectorCreateInfoEXT createInfo, [Count(Count = 0)] ref PlaneDetectorEXT planeDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyPlaneDetectorEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroyPlaneDetector([Count(Count = 0)] PlaneDetectorEXT planeDetector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorGetInfoEXT* info, [Count(Count = 0)] PlaneDetectorLocationsEXT* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorGetInfoEXT* info, [Count(Count = 0)] ref PlaneDetectorLocationsEXT locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PlaneDetectorGetInfoEXT info, [Count(Count = 0)] PlaneDetectorLocationsEXT* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionsEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPlaneDetection([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PlaneDetectorGetInfoEXT info, [Count(Count = 0)] ref PlaneDetectorLocationsEXT locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionStateEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPlaneDetectionState([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] PlaneDetectionStateEXT* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlaneDetectionStateEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPlaneDetectionState([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] ref PlaneDetectionStateEXT state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlanePolygonBufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPlanePolygonBuffer([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] ulong planeId, [Count(Count = 0)] uint polygonBufferIndex, [Count(Count = 0)] PlaneDetectorPolygonBufferEXT* polygonBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetPlanePolygonBufferEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPlanePolygonBuffer([Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] ulong planeId, [Count(Count = 0)] uint polygonBufferIndex, [Count(Count = 0)] ref PlaneDetectorPolygonBufferEXT polygonBuffer);

        public ExtPlaneDetection(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

