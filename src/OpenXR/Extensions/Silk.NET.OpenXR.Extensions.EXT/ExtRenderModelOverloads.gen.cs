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
    public static class ExtRenderModelOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModel(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelCreateInfoEXT* createInfo, [Count(Count = 0)] Span<RenderModelEXT> renderModel)
        {
            // SpanOverloader
            return thisApi.CreateRenderModel(session, createInfo, ref renderModel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModel(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelCreateInfoEXT> createInfo, [Count(Count = 0)] RenderModelEXT* renderModel)
        {
            // SpanOverloader
            return thisApi.CreateRenderModel(session, in createInfo.GetPinnableReference(), renderModel);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModel(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelCreateInfoEXT> createInfo, [Count(Count = 0)] Span<RenderModelEXT> renderModel)
        {
            // SpanOverloader
            return thisApi.CreateRenderModel(session, in createInfo.GetPinnableReference(), ref renderModel.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelAsset(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetCreateInfoEXT* createInfo, [Count(Count = 0)] Span<RenderModelAssetEXT> asset)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelAsset(session, createInfo, ref asset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelAsset(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetCreateInfoEXT> createInfo, [Count(Count = 0)] RenderModelAssetEXT* asset)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelAsset(session, in createInfo.GetPinnableReference(), asset);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelAsset(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetCreateInfoEXT> createInfo, [Count(Count = 0)] Span<RenderModelAssetEXT> asset)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelAsset(session, in createInfo.GetPinnableReference(), ref asset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelSpace(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelSpaceCreateInfoEXT* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelSpace(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelSpace(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelSpaceCreateInfoEXT> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelSpace(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateRenderModelSpace(this ExtRenderModel thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelSpaceCreateInfoEXT> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateRenderModelSpace(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetData(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetDataGetInfoEXT* getInfo, [Count(Count = 0)] Span<RenderModelAssetDataEXT> buffer)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetData(asset, getInfo, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetData(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetDataGetInfoEXT> getInfo, [Count(Count = 0)] RenderModelAssetDataEXT* buffer)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetData(asset, in getInfo.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetData(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetDataGetInfoEXT> getInfo, [Count(Count = 0)] Span<RenderModelAssetDataEXT> buffer)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetData(asset, in getInfo.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelAssetPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] Span<RenderModelAssetPropertiesEXT> properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetProperties(asset, getInfo, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetPropertiesGetInfoEXT> getInfo, [Count(Count = 0)] RenderModelAssetPropertiesEXT* properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetProperties(asset, in getInfo.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelAssetProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelAssetEXT asset, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelAssetPropertiesGetInfoEXT> getInfo, [Count(Count = 0)] Span<RenderModelAssetPropertiesEXT> properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelAssetProperties(asset, in getInfo.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelPropertiesGetInfoEXT* getInfo, [Count(Count = 0)] Span<RenderModelPropertiesEXT> properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelProperties(renderModel, getInfo, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelPropertiesGetInfoEXT> getInfo, [Count(Count = 0)] RenderModelPropertiesEXT* properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelProperties(renderModel, in getInfo.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelProperties(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelPropertiesGetInfoEXT> getInfo, [Count(Count = 0)] Span<RenderModelPropertiesEXT> properties)
        {
            // SpanOverloader
            return thisApi.GetRenderModelProperties(renderModel, in getInfo.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelState(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderModelStateGetInfoEXT* getInfo, [Count(Count = 0)] Span<RenderModelStateEXT> state)
        {
            // SpanOverloader
            return thisApi.GetRenderModelState(renderModel, getInfo, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelState(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelStateGetInfoEXT> getInfo, [Count(Count = 0)] RenderModelStateEXT* state)
        {
            // SpanOverloader
            return thisApi.GetRenderModelState(renderModel, in getInfo.GetPinnableReference(), state);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetRenderModelState(this ExtRenderModel thisApi, [Count(Count = 0)] RenderModelEXT renderModel, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RenderModelStateGetInfoEXT> getInfo, [Count(Count = 0)] Span<RenderModelStateEXT> state)
        {
            // SpanOverloader
            return thisApi.GetRenderModelState(renderModel, in getInfo.GetPinnableReference(), ref state.GetPinnableReference());
        }

    }
}

