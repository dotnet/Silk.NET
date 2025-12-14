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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_spatial_persistence_operations")]
    public unsafe partial class ExtSpatialPersistenceOperations : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_spatial_persistence_operations";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityPersistInfoEXT* persistInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityPersistInfoEXT* persistInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityPersistInfoEXT persistInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public partial Result PersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityPersistInfoEXT persistInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialEntityComplete([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] PersistSpatialEntityCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialEntityCompleteEXT", Convention = CallingConvention.Winapi)]
        public partial Result PersistSpatialEntityComplete([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref PersistSpatialEntityCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityUnpersistInfoEXT* unpersistInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityUnpersistInfoEXT* unpersistInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityUnpersistInfoEXT unpersistInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityAsyncEXT", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistSpatialEntityAsync([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityUnpersistInfoEXT unpersistInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialEntityComplete([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] UnpersistSpatialEntityCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialEntityCompleteEXT", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistSpatialEntityComplete([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref UnpersistSpatialEntityCompletionEXT completion);

        public ExtSpatialPersistenceOperations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

