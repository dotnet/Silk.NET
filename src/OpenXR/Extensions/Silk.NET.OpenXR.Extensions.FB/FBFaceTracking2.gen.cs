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
    [Extension("XR_FB_face_tracking2")]
    public unsafe partial class FBFaceTracking2 : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_face_tracking2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTracker2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker2fB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfo2FB* createInfo, [Count(Count = 0)] FaceTracker2FB* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTracker2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker2fB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfo2FB* createInfo, [Count(Count = 0)] ref FaceTracker2FB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTracker2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTracker2fB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceTrackerCreateInfo2FB createInfo, [Count(Count = 0)] FaceTracker2FB* faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTracker2FB", Convention = CallingConvention.Winapi)]
        public partial Result CreateFaceTracker2fB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceTrackerCreateInfo2FB createInfo, [Count(Count = 0)] ref FaceTracker2FB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFaceTracker2FB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFaceTracker2fB([Count(Count = 0)] FaceTracker2FB faceTracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeights2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeights2fB([Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfo2FB* expressionInfo, [Count(Count = 0)] FaceExpressionWeights2FB* expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeights2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeights2fB([Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfo2FB* expressionInfo, [Count(Count = 0)] ref FaceExpressionWeights2FB expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeights2FB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFaceExpressionWeights2fB([Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceExpressionInfo2FB expressionInfo, [Count(Count = 0)] FaceExpressionWeights2FB* expressionWeights);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFaceExpressionWeights2FB", Convention = CallingConvention.Winapi)]
        public partial Result GetFaceExpressionWeights2fB([Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FaceExpressionInfo2FB expressionInfo, [Count(Count = 0)] ref FaceExpressionWeights2FB expressionWeights);

        public FBFaceTracking2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

