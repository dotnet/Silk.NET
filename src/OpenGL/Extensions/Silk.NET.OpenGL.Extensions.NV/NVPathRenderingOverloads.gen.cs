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

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVPathRenderingOverloads
    {
        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, transformValues);
        }

        public static unsafe void CoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void GetPathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> commands)
        {
            // SpanOverloader
            thisApi.GetPathCommands(path, out commands.GetPinnableReference());
        }

        public static unsafe void GetPathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PathCoordType> commands)
        {
            // SpanOverloader
            thisApi.GetPathCommands(path, out commands.GetPinnableReference());
        }

        public static unsafe void GetPathCoords(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> coords)
        {
            // SpanOverloader
            thisApi.GetPathCoords(path, out coords.GetPinnableReference());
        }

        public static unsafe void GetPathDashArray(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> dashArray)
        {
            // SpanOverloader
            thisApi.GetPathDashArray(path, out dashArray.GetPinnableReference());
        }

        public static unsafe void GetPathMetric(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, metrics);
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, metrics);
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, metrics);
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, metrics);
        }

        public static unsafe void GetPathMetric<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetricRange(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathMetricRange(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> metrics)
        {
            // SpanOverloader
            thisApi.GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, out metrics.GetPinnableReference());
        }

        public static unsafe void GetPathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            thisApi.GetPathParameter(path, pname, out value.GetPinnableReference());
        }

        public static unsafe void GetPathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            thisApi.GetPathParameter(path, pname, out value.GetPinnableReference());
        }

        public static unsafe void GetPathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> value)
        {
            // SpanOverloader
            thisApi.GetPathParameter(path, pname, out value.GetPinnableReference());
        }

        public static unsafe void GetPathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> value)
        {
            // SpanOverloader
            thisApi.GetPathParameter(path, pname, out value.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing)
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, returnedSpacing);
        }

        public static unsafe void GetPathSpacing<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> returnedSpacing) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GetPathSpacing(pathListMode, numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, advanceScale, kerningScale, transformType, out returnedSpacing.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad3x2(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad3x2(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoad3x3(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoad3x3(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixLoadTranspose3x3(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixLoadTranspose3x3(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMult(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult3x2(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult3x2(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMult3x3(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMult3x3(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose(mode, in m.GetPinnableReference());
        }

        public static unsafe void MatrixMultTranspose3x3(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MatrixMultTranspose3x3(matrixMode, in m.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCommands(path, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCoords<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCoords(path, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathCoords<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathCoords(path, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathDashArray(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashArray)
        {
            // SpanOverloader
            thisApi.PathDashArray(path, dashCount, in dashArray.GetPinnableReference());
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyph<T0, T1>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyph(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, numGlyphs, type, in charcodes.GetPinnableReference(), handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe NV PathGlyphIndexArray<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexArray(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe NV PathGlyphIndexArray<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexArray(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe NV PathGlyphIndexRange(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> baseAndCount)
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, out baseAndCount.GetPinnableReference());
        }

        public static unsafe NV PathGlyphIndexRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, in fontName.GetPinnableReference(), fontStyle, pathParameterTemplate, emScale, baseAndCount);
        }

        public static unsafe NV PathGlyphIndexRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> baseAndCount) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, in fontName.GetPinnableReference(), fontStyle, pathParameterTemplate, emScale, out baseAndCount.GetPinnableReference());
        }

        public static unsafe NV PathGlyphIndexRange(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> baseAndCount)
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, out baseAndCount.GetPinnableReference());
        }

        public static unsafe NV PathGlyphIndexRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, in fontName.GetPinnableReference(), fontStyle, pathParameterTemplate, emScale, baseAndCount);
        }

        public static unsafe NV PathGlyphIndexRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> baseAndCount) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathGlyphIndexRange(fontTarget, in fontName.GetPinnableReference(), fontStyle, pathParameterTemplate, emScale, out baseAndCount.GetPinnableReference());
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathGlyphRange<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathGlyphRange(firstPathName, fontTarget, in fontName.GetPinnableReference(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe NV PathMemoryGlyphIndexArray<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint faceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PathMemoryGlyphIndexArray(firstPathName, fontTarget, fontSize, in fontData.GetPinnableReference(), faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public static unsafe void PathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.PathParameter(path, pname, in value.GetPinnableReference());
        }

        public static unsafe void PathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.PathParameter(path, pname, in value.GetPinnableReference());
        }

        public static unsafe void PathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.PathParameter(path, pname, in value.GetPinnableReference());
        }

        public static unsafe void PathParameter(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.PathParameter(path, pname, in value.GetPinnableReference());
        }

        public static unsafe void PathString<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathString(path, format, length, in pathString.GetPinnableReference());
        }

        public static unsafe void PathString<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathStringFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathString(path, format, length, in pathString.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCommands(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public static unsafe void PathSubCommands<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCommands(path, commandStart, commandsToDelete, numCommands, in commands.GetPinnableReference(), numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCoords<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCoords(path, coordStart, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe void PathSubCoords<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> coords) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PathSubCoords(path, coordStart, numCoords, coordType, in coords.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, y, tangentX, out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, y, out tangentX.GetPinnableReference(), tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, y, out tangentX.GetPinnableReference(), out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, out y.GetPinnableReference(), tangentX, tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, out y.GetPinnableReference(), tangentX, out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, out y.GetPinnableReference(), out tangentX.GetPinnableReference(), tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, x, out y.GetPinnableReference(), out tangentX.GetPinnableReference(), out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), y, tangentX, tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), y, tangentX, out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), y, out tangentX.GetPinnableReference(), tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), y, out tangentX.GetPinnableReference(), out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), out y.GetPinnableReference(), tangentX, tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), out y.GetPinnableReference(), tangentX, out tangentY.GetPinnableReference());
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), out y.GetPinnableReference(), out tangentX.GetPinnableReference(), tangentY);
        }

        public static unsafe bool PointAlongPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> tangentY)
        {
            // SpanOverloader
            return thisApi.PointAlongPath(path, startSegment, numSegments, distance, out x.GetPinnableReference(), out y.GetPinnableReference(), out tangentX.GetPinnableReference(), out tangentY.GetPinnableReference());
        }

        public static unsafe void ProgramPathFragmentInputGen(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coeffs)
        {
            // SpanOverloader
            thisApi.ProgramPathFragmentInputGen(program, location, genMode, components, in coeffs.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, transformValues);
        }

        public static unsafe void StencilFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, transformValues);
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, transformValues);
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, transformValues);
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, transformValues);
        }

        public static unsafe void StencilStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverFillPathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverFillPathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, fillMode, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, transformValues);
        }

        public static unsafe void StencilThenCoverStrokePathInstanced<T0>(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StencilThenCoverStrokePathInstanced(numPaths, pathNameType, in paths.GetPinnableReference(), pathBase, reference, mask, coverMode, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void TransformPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.TransformPath(resultPath, srcPath, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void TransformPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> transformValues)
        {
            // SpanOverloader
            thisApi.TransformPath(resultPath, srcPath, transformType, in transformValues.GetPinnableReference());
        }

        public static unsafe void WeightPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.WeightPath(resultPath, numPaths, paths, in weights.GetPinnableReference());
        }

        public static unsafe void WeightPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights)
        {
            // SpanOverloader
            thisApi.WeightPath(resultPath, numPaths, in paths.GetPinnableReference(), weights);
        }

        public static unsafe void WeightPath(this NVPathRendering thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.WeightPath(resultPath, numPaths, in paths.GetPinnableReference(), in weights.GetPinnableReference());
        }

    }
}

