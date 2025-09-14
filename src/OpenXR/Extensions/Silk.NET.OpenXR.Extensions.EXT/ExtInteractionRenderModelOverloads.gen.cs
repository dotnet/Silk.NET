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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtInteractionRenderModelOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, getInfo, renderModelIdCapacityInput, renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] Span<uint> renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, getInfo, renderModelIdCapacityInput, ref renderModelIdCountOutput.GetPinnableReference(), renderModelIds);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] Span<uint> renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, getInfo, renderModelIdCapacityInput, ref renderModelIdCountOutput.GetPinnableReference(), ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelIdsEnumerateInfoEXT> getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, in getInfo.GetPinnableReference(), renderModelIdCapacityInput, renderModelIdCountOutput, renderModelIds);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelIdsEnumerateInfoEXT> getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, in getInfo.GetPinnableReference(), renderModelIdCapacityInput, renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelIdsEnumerateInfoEXT> getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] Span<uint> renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, in getInfo.GetPinnableReference(), renderModelIdCapacityInput, ref renderModelIdCountOutput.GetPinnableReference(), renderModelIds);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInteractionRenderModelIds(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelIdsEnumerateInfoEXT> getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] Span<uint> renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // SpanOverloader
            return thisApi.EnumerateInteractionRenderModelIds(session, in getInfo.GetPinnableReference(), renderModelIdCapacityInput, ref renderModelIdCountOutput.GetPinnableReference(), ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, info, pathCapacityInput, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, info, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), paths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, info, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelSubactionPathInfoEXT> info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, in info.GetPinnableReference(), pathCapacityInput, pathCountOutput, paths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelSubactionPathInfoEXT> info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, in info.GetPinnableReference(), pathCapacityInput, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelSubactionPathInfoEXT> info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, in info.GetPinnableReference(), pathCapacityInput, ref pathCountOutput.GetPinnableReference(), paths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRenderModelSubactionPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelSubactionPathInfoEXT> info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateRenderModelSubactionPath(renderModel, in info.GetPinnableReference(), pathCapacityInput, ref pathCountOutput.GetPinnableReference(), ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelPoseTopLevelUserPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelTopLevelUserPathGetInfoEXT* info, [Count(Count = 0)] Span<ulong> topLevelUserPath)
        {
            // SpanOverloader
            return thisApi.GetRenderModelPoseTopLevelUserPath(renderModel, info, ref topLevelUserPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelPoseTopLevelUserPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelTopLevelUserPathGetInfoEXT> info, [Count(Count = 0)] ulong* topLevelUserPath)
        {
            // SpanOverloader
            return thisApi.GetRenderModelPoseTopLevelUserPath(renderModel, in info.GetPinnableReference(), topLevelUserPath);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelPoseTopLevelUserPath(this ExtInteractionRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionRenderModelTopLevelUserPathGetInfoEXT> info, [Count(Count = 0)] Span<ulong> topLevelUserPath)
        {
            // SpanOverloader
            return thisApi.GetRenderModelPoseTopLevelUserPath(renderModel, in info.GetPinnableReference(), ref topLevelUserPath.GetPinnableReference());
        }

    }
}

