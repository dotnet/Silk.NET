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
    [Extension("XR_BD_spatial_anchor")]
    public unsafe partial class BDSpatialAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_spatial_anchor";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SpatialAnchorCreateCompletionBD* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SpatialAnchorCreateCompletionBD completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorPersistInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorPersistInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorPersistInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result PersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorPersistInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result PersistSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorUnpersistInfoBD* info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorUnpersistInfoBD* info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorUnpersistInfoBD info, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistSpatialAnchorAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorUnpersistInfoBD info, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistSpatialAnchorCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        public BDSpatialAnchor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

