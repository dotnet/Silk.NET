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
    [Extension("XR_EXT_interaction_render_model")]
    public unsafe partial class ExtInteractionRenderModel : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_interaction_render_model";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ref ulong renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ref ulong renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ref ulong renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ulong* renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInteractionRenderModelIdsEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] uint renderModelIdCapacityInput, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] ref ulong renderModelIds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ulong paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ulong paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ulong paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ulong* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateRenderModelSubactionPathsEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ulong paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPoseTopLevelUserPathEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelPoseTopLevelUserPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelTopLevelUserPathGetInfoEXT* info, [Count(Count = 0)] ulong* topLevelUserPath);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPoseTopLevelUserPathEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelPoseTopLevelUserPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelTopLevelUserPathGetInfoEXT* info, [Count(Count = 0)] ref ulong topLevelUserPath);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPoseTopLevelUserPathEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetRenderModelPoseTopLevelUserPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelTopLevelUserPathGetInfoEXT info, [Count(Count = 0)] ulong* topLevelUserPath);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetRenderModelPoseTopLevelUserPathEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetRenderModelPoseTopLevelUserPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelTopLevelUserPathGetInfoEXT info, [Count(Count = 0)] ref ulong topLevelUserPath);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInteractionRenderModelIds(session, getInfo, (uint) renderModelIds.Length, renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelIdsEnumerateInfoEXT* getInfo, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInteractionRenderModelIds(session, getInfo, (uint) renderModelIds.Length, ref renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] uint* renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInteractionRenderModelIds(session, in getInfo, (uint) renderModelIds.Length, renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInteractionRenderModelIds([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelIdsEnumerateInfoEXT getInfo, [Count(Count = 0)] ref uint renderModelIdCountOutput, [Count(Parameter = "renderModelIdCapacityInput")] Span<ulong> renderModelIds)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInteractionRenderModelIds(session, in getInfo, (uint) renderModelIds.Length, ref renderModelIdCountOutput, ref renderModelIds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelSubactionPath(renderModel, info, (uint) paths.Length, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionRenderModelSubactionPathInfoEXT* info, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelSubactionPath(renderModel, info, (uint) paths.Length, ref pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelSubactionPath(renderModel, in info, (uint) paths.Length, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateRenderModelSubactionPath([Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly InteractionRenderModelSubactionPathInfoEXT info, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ulong> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateRenderModelSubactionPath(renderModel, in info, (uint) paths.Length, ref pathCountOutput, ref paths.GetPinnableReference());
        }

        public ExtInteractionRenderModel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

