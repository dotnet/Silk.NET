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
    [Extension("XR_FB_face_tracking")]
    public unsafe partial class FBFaceTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_face_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoFB* createInfo, [Count(Count = 0)] FaceTrackerFB* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoFB* createInfo, [Count(Count = 0)] ref FaceTrackerFB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceTrackerCreateInfoFB createInfo, [Count(Count = 0)] FaceTrackerFB* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateFaceTrackerFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceTrackerCreateInfoFB createInfo, [Count(Count = 0)] ref FaceTrackerFB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFaceTrackerFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFaceTrackerFB([Count(Count = 0)] FaceTrackerFB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeightsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeightsFB([Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfoFB* expressionInfo, [Count(Count = 0)] FaceExpressionWeightsFB* expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeightsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeightsFB([Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfoFB* expressionInfo, [Count(Count = 0)] ref FaceExpressionWeightsFB expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeightsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeightsFB([Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceExpressionInfoFB expressionInfo, [Count(Count = 0)] FaceExpressionWeightsFB* expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeightsFB", Convention = CallingConvention.Winapi)]
        public partial Result GetFaceExpressionWeightsFB([Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceExpressionInfoFB expressionInfo, [Count(Count = 0)] ref FaceExpressionWeightsFB expressionWeights);

        public FBFaceTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

