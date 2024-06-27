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
    [Extension("XR_FB_render_model")]
    public unsafe partial class FBRenderModel : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_render_model";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelPathsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] RenderModelPathInfoFB* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelPathsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref RenderModelPathInfoFB paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelPathsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] RenderModelPathInfoFB* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelPathsFB", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref RenderModelPathInfoFB paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelPropertiesFB([Count(Count = 0)] Session session, [Count(Count = 0)] ulong path, [Count(Count = 0)] RenderModelPropertiesFB* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPropertiesFB", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelPropertiesFB([Count(Count = 0)] Session session, [Count(Count = 0)] ulong path, [Count(Count = 0)] ref RenderModelPropertiesFB properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadRenderModelFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadRenderModelFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelLoadInfoFB* info, [Count(Count = 0)] RenderModelBufferFB* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadRenderModelFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadRenderModelFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelLoadInfoFB* info, [Count(Count = 0)] ref RenderModelBufferFB buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadRenderModelFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LoadRenderModelFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderModelLoadInfoFB info, [Count(Count = 0)] RenderModelBufferFB* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLoadRenderModelFB", Convention = CallingConvention.Winapi)]
        public partial Result LoadRenderModelFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderModelLoadInfoFB info, [Count(Count = 0)] ref RenderModelBufferFB buffer);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<RenderModelPathInfoFB> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelPathsFB(session, (uint) paths.Length, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelPathsFB([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<RenderModelPathInfoFB> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelPathsFB(session, (uint) paths.Length, ref pathCountOutput, ref paths.GetPinnableReference());
        }

        public FBRenderModel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

