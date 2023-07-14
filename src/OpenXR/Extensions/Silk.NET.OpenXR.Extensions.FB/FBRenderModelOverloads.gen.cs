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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBRenderModelOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelPathsFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<RenderModelPathInfoFB> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelPathsFB(session, pathCapacityInput, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelPathsFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] RenderModelPathInfoFB* paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelPathsFB(session, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), paths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelPathsFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<RenderModelPathInfoFB> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelPathsFB(session, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelPropertiesFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong path, [Count(Count = 0)] Span<RenderModelPropertiesFB> properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelPropertiesFB(session, path, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadRenderModelFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelLoadInfoFB* info, [Count(Count = 0)] Span<RenderModelBufferFB> buffer)
        {
            // SpanOverloader
            return thisApi.LoadRenderModelFB(session, info, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadRenderModelFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelLoadInfoFB> info, [Count(Count = 0)] RenderModelBufferFB* buffer)
        {
            // SpanOverloader
            return thisApi.LoadRenderModelFB(session, in info.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LoadRenderModelFB(this FBRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelLoadInfoFB> info, [Count(Count = 0)] Span<RenderModelBufferFB> buffer)
        {
            // SpanOverloader
            return thisApi.LoadRenderModelFB(session, in info.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

    }
}

