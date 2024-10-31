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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_world_mesh_detection")]
    public unsafe partial class MLWorldMeshDetection : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_world_mesh_detection";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAllocateWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferSizeML* size, [Count(Count = 0)] WorldMeshBufferML* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAllocateWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferSizeML* size, [Count(Count = 0)] ref WorldMeshBufferML buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAllocateWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AllocateWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshBufferSizeML size, [Count(Count = 0)] WorldMeshBufferML* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAllocateWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public partial Result AllocateWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshBufferSizeML size, [Count(Count = 0)] ref WorldMeshBufferML buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateWorldMeshDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWorldMeshDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshDetectorCreateInfoML* createInfo, [Count(Count = 0)] WorldMeshDetectorML* detector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateWorldMeshDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWorldMeshDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshDetectorCreateInfoML* createInfo, [Count(Count = 0)] ref WorldMeshDetectorML detector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateWorldMeshDetectorML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateWorldMeshDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshDetectorCreateInfoML createInfo, [Count(Count = 0)] WorldMeshDetectorML* detector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateWorldMeshDetectorML", Convention = CallingConvention.Winapi)]
        public partial Result CreateWorldMeshDetectorML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshDetectorCreateInfoML createInfo, [Count(Count = 0)] ref WorldMeshDetectorML detector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyWorldMeshDetectorML", Convention = CallingConvention.Winapi)]
        public partial Result DestroyWorldMeshDetectorML([Count(Count = 0)] WorldMeshDetectorML detector);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrFreeWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result FreeWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferML* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrFreeWorldMeshBufferML", Convention = CallingConvention.Winapi)]
        public partial Result FreeWorldMeshBufferML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshBufferML buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetWorldMeshBufferRecommendSizeML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetWorldMeshBufferRecommendSizeML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferRecommendedSizeInfoML* sizeInfo, [Count(Count = 0)] WorldMeshBufferSizeML* size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetWorldMeshBufferRecommendSizeML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetWorldMeshBufferRecommendSizeML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferRecommendedSizeInfoML* sizeInfo, [Count(Count = 0)] ref WorldMeshBufferSizeML size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetWorldMeshBufferRecommendSizeML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetWorldMeshBufferRecommendSizeML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshBufferRecommendedSizeInfoML sizeInfo, [Count(Count = 0)] WorldMeshBufferSizeML* size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetWorldMeshBufferRecommendSizeML", Convention = CallingConvention.Winapi)]
        public partial Result GetWorldMeshBufferRecommendSizeML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshBufferRecommendedSizeInfoML sizeInfo, [Count(Count = 0)] ref WorldMeshBufferSizeML size);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] ref WorldMeshBufferML buffer, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] ref WorldMeshBufferML buffer, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshGetInfoML getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshGetInfoML getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshGetInfoML getInfo, [Count(Count = 0)] ref WorldMeshBufferML buffer, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result RequestWorldMeshAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshGetInfoML getInfo, [Count(Count = 0)] ref WorldMeshBufferML buffer, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshRequestCompletionInfoML* completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] WorldMeshRequestCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshRequestCompletionInfoML* completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref WorldMeshRequestCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshRequestCompletionInfoML completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] WorldMeshRequestCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result RequestWorldMeshCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshRequestCompletionInfoML completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref WorldMeshRequestCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshStateAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshStateRequestInfoML* stateRequest, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshStateAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshStateRequestInfoML* stateRequest, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshStateAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshStateRequestInfoML stateRequest, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result RequestWorldMeshStateAsyncML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WorldMeshStateRequestInfoML stateRequest, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestWorldMeshStateCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] WorldMeshStateRequestCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestWorldMeshStateCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result RequestWorldMeshStateCompleteML([Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref WorldMeshStateRequestCompletionML completion);

        public MLWorldMeshDetection(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

