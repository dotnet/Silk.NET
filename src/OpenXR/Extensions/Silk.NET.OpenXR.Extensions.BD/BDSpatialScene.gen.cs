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

namespace Silk.NET.OpenXR.Extensions.BD
{
    [Extension("XR_BD_spatial_scene")]
    public unsafe partial class BDSpatialScene : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_spatial_scene";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CaptureSceneAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCaptureInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CaptureSceneAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCaptureInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CaptureSceneAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SceneCaptureInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result CaptureSceneAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SceneCaptureInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CaptureSceneCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCaptureSceneCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result CaptureSceneCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        public BDSpatialScene(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

