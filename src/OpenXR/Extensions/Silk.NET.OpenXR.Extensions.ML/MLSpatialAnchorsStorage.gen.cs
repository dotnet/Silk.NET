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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_spatial_anchors_storage")]
    public unsafe partial class MLSpatialAnchorsStorage : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_spatial_anchors_storage";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsStorageML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsStorageML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateStorageInfoML* createInfo, [Count(Count = 0)] SpatialAnchorsStorageML* storage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsStorageML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsStorageML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateStorageInfoML* createInfo, [Count(Count = 0)] ref SpatialAnchorsStorageML storage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsStorageML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsStorageML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsCreateStorageInfoML createInfo, [Count(Count = 0)] SpatialAnchorsStorageML* storage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsStorageML", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorsStorageML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsCreateStorageInfoML createInfo, [Count(Count = 0)] ref SpatialAnchorsStorageML storage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DeleteSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsDeleteInfoML* deleteInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DeleteSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsDeleteInfoML* deleteInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DeleteSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsDeleteInfoML deleteInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result DeleteSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsDeleteInfoML deleteInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DeleteSpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SpatialAnchorsDeleteCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeleteSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result DeleteSpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SpatialAnchorsDeleteCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialAnchorsStorageML", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialAnchorsStorageML([Count(Count = 0)] SpatialAnchorsStorageML storage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PublishSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsPublishInfoML* publishInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PublishSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsPublishInfoML* publishInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PublishSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsPublishInfoML publishInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result PublishSpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsPublishInfoML publishInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PublishSpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SpatialAnchorsPublishCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPublishSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result PublishSpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SpatialAnchorsPublishCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsQueryInfoBaseHeaderML queryInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result QuerySpatialAnchorsAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsQueryInfoBaseHeaderML queryInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SpatialAnchorsQueryCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result QuerySpatialAnchorsCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SpatialAnchorsQueryCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateSpatialAnchorsExpirationAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsUpdateExpirationInfoML* updateInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateSpatialAnchorsExpirationAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsUpdateExpirationInfoML* updateInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateSpatialAnchorsExpirationAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsUpdateExpirationInfoML updateInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result UpdateSpatialAnchorsExpirationAsyncML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsUpdateExpirationInfoML updateInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateSpatialAnchorsExpirationCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SpatialAnchorsUpdateExpirationCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSpatialAnchorsExpirationCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result UpdateSpatialAnchorsExpirationCompleteML([Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SpatialAnchorsUpdateExpirationCompletionML completion);

        public MLSpatialAnchorsStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

