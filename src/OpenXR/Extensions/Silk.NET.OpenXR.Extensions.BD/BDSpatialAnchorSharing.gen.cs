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
    [Extension("XR_BD_spatial_anchor_sharing")]
    public unsafe partial class BDSpatialAnchorSharing : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_spatial_anchor_sharing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DownloadSharedSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedSpatialAnchorDownloadInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DownloadSharedSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedSpatialAnchorDownloadInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DownloadSharedSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedSpatialAnchorDownloadInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result DownloadSharedSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedSpatialAnchorDownloadInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DownloadSharedSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDownloadSharedSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result DownloadSharedSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorShareInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorShareInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorShareInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result ShareSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorShareInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result ShareSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        public BDSpatialAnchorSharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

