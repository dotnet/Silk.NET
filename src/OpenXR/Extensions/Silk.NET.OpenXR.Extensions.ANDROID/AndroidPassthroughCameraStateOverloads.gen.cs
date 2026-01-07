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

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    public static class AndroidPassthroughCameraStateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPassthroughCameraState(this AndroidPassthroughCameraState thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCameraStateGetInfoANDROID* getInfo, [Count(Count = 0)] Span<PassthroughCameraStateANDROID> cameraStateOutput)
        {
            // SpanOverloader
            return thisApi.GetPassthroughCameraState(session, getInfo, ref cameraStateOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPassthroughCameraState(this AndroidPassthroughCameraState thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCameraStateGetInfoANDROID> getInfo, [Count(Count = 0)] PassthroughCameraStateANDROID* cameraStateOutput)
        {
            // SpanOverloader
            return thisApi.GetPassthroughCameraState(session, in getInfo.GetPinnableReference(), cameraStateOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPassthroughCameraState(this AndroidPassthroughCameraState thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCameraStateGetInfoANDROID> getInfo, [Count(Count = 0)] Span<PassthroughCameraStateANDROID> cameraStateOutput)
        {
            // SpanOverloader
            return thisApi.GetPassthroughCameraState(session, in getInfo.GetPinnableReference(), ref cameraStateOutput.GetPinnableReference());
        }

    }
}

