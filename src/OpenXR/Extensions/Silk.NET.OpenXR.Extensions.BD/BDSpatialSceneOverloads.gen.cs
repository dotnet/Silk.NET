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

namespace Silk.NET.OpenXR.Extensions.BD
{
    public static class BDSpatialSceneOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CaptureSceneAsyncBD(this BDSpatialScene thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCaptureInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CaptureSceneAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CaptureSceneAsyncBD(this BDSpatialScene thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCaptureInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CaptureSceneAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CaptureSceneAsyncBD(this BDSpatialScene thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCaptureInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CaptureSceneAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CaptureSceneCompleteBD(this BDSpatialScene thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.CaptureSceneCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

    }
}

