// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftHandTrackingMeshOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandMeshSpaceMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandMeshSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateHandMeshSpaceMsft(handTracker, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandMeshSpaceMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandMeshSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateHandMeshSpaceMsft(handTracker, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandMeshSpaceMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandMeshSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateHandMeshSpaceMsft(handTracker, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result UpdateHandMeshMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandMeshUpdateInfoMSFT* updateInfo, [Count(Count = 0)] Span<HandMeshMSFT> handMesh)
        {
            // SpanOverloader
            return thisApi.UpdateHandMeshMsft(handTracker, updateInfo, ref handMesh.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result UpdateHandMeshMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandMeshUpdateInfoMSFT> updateInfo, [Count(Count = 0)] HandMeshMSFT* handMesh)
        {
            // SpanOverloader
            return thisApi.UpdateHandMeshMsft(handTracker, in updateInfo.GetPinnableReference(), handMesh);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result UpdateHandMeshMsft(this MsftHandTrackingMesh thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandMeshUpdateInfoMSFT> updateInfo, [Count(Count = 0)] Span<HandMeshMSFT> handMesh)
        {
            // SpanOverloader
            return thisApi.UpdateHandMeshMsft(handTracker, in updateInfo.GetPinnableReference(), ref handMesh.GetPinnableReference());
        }

    }
}

