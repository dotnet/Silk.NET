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
    public static class FBPassthroughOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGeometryInstanceFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeometryInstanceCreateInfoFB* createInfo, [Count(Count = 0)] Span<GeometryInstanceFB> outGeometryInstance)
        {
            // SpanOverloader
            return thisApi.CreateGeometryInstanceFB(session, createInfo, ref outGeometryInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGeometryInstanceFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeometryInstanceCreateInfoFB> createInfo, [Count(Count = 0)] GeometryInstanceFB* outGeometryInstance)
        {
            // SpanOverloader
            return thisApi.CreateGeometryInstanceFB(session, in createInfo.GetPinnableReference(), outGeometryInstance);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateGeometryInstanceFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeometryInstanceCreateInfoFB> createInfo, [Count(Count = 0)] Span<GeometryInstanceFB> outGeometryInstance)
        {
            // SpanOverloader
            return thisApi.CreateGeometryInstanceFB(session, in createInfo.GetPinnableReference(), ref outGeometryInstance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCreateInfoFB* createInfo, [Count(Count = 0)] Span<PassthroughFB> outPassthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughFB(session, createInfo, ref outPassthrough.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCreateInfoFB> createInfo, [Count(Count = 0)] PassthroughFB* outPassthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughFB(session, in createInfo.GetPinnableReference(), outPassthrough);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCreateInfoFB> createInfo, [Count(Count = 0)] Span<PassthroughFB> outPassthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughFB(session, in createInfo.GetPinnableReference(), ref outPassthrough.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughLayerFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughLayerCreateInfoFB* createInfo, [Count(Count = 0)] Span<PassthroughLayerFB> outLayer)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughLayerFB(session, createInfo, ref outLayer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughLayerFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughLayerCreateInfoFB> createInfo, [Count(Count = 0)] PassthroughLayerFB* outLayer)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughLayerFB(session, in createInfo.GetPinnableReference(), outLayer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughLayerFB(this FBPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughLayerCreateInfoFB> createInfo, [Count(Count = 0)] Span<PassthroughLayerFB> outLayer)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughLayerFB(session, in createInfo.GetPinnableReference(), ref outLayer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GeometryInstanceSetTransformFB(this FBPassthrough thisApi, [Count(Count = 0)] GeometryInstanceFB instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GeometryInstanceTransformFB> transformation)
        {
            // SpanOverloader
            return thisApi.GeometryInstanceSetTransformFB(instance, in transformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PassthroughLayerSetStyleFB(this FBPassthrough thisApi, [Count(Count = 0)] PassthroughLayerFB layer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughStyleFB> style)
        {
            // SpanOverloader
            return thisApi.PassthroughLayerSetStyleFB(layer, in style.GetPinnableReference());
        }

    }
}

