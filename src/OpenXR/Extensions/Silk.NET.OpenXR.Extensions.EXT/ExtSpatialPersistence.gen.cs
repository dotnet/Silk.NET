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
    [Extension("XR_EXT_spatial_persistence")]
    public unsafe partial class ExtSpatialPersistence : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_spatial_persistence";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialPersistenceContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialPersistenceContextCreateInfoEXT* createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialPersistenceContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialPersistenceContextCreateInfoEXT* createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialPersistenceContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialPersistenceContextCreateInfoEXT createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialPersistenceContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialPersistenceContextCreateInfoEXT createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialPersistenceContextComplete([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] CreateSpatialPersistenceContextCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialPersistenceContextCompleteEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialPersistenceContextComplete([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref CreateSpatialPersistenceContextCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialPersistenceContextEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialPersistenceContext([Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialPersistenceScopesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] uint* persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] SpatialPersistenceScopeEXT* persistenceScopes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialPersistenceScopesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] uint* persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] ref SpatialPersistenceScopeEXT persistenceScopes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialPersistenceScopesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] ref uint persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] SpatialPersistenceScopeEXT* persistenceScopes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialPersistenceScopesEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] ref uint persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] ref SpatialPersistenceScopeEXT persistenceScopes);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] Span<SpatialPersistenceScopeEXT> persistenceScopes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialPersistenceScopes(instance, systemId, (uint) persistenceScopes.Length, persistenceScopeCountOutput, ref persistenceScopes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialPersistenceScopes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] Span<SpatialPersistenceScopeEXT> persistenceScopes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialPersistenceScopes(instance, systemId, (uint) persistenceScopes.Length, ref persistenceScopeCountOutput, ref persistenceScopes.GetPinnableReference());
        }

        public ExtSpatialPersistence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

