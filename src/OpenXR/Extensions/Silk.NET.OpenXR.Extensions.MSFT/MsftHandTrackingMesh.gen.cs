// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_hand_tracking_mesh")]
    public unsafe partial class MsftHandTrackingMesh : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_hand_tracking_mesh";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT")]
        public unsafe partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandMeshSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateHandMeshSpaceMSFT")]
        public partial Result CreateHandMeshSpaceMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ref HandMeshSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT")]
        public unsafe partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandMeshUpdateInfoMSFT* updateInfo, [Count(Count = 0)] HandMeshMSFT* handMesh);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrUpdateHandMeshMSFT")]
        public partial Result UpdateHandMeshMsft([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ref HandMeshUpdateInfoMSFT updateInfo, [Count(Count = 0)] ref HandMeshMSFT handMesh);

        public MsftHandTrackingMesh(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

