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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtSpatialPersistenceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialPersistenceContextAsync(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialPersistenceContextCreateInfoEXT* createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialPersistenceContextAsync(session, createInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialPersistenceContextAsync(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialPersistenceContextCreateInfoEXT> createInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialPersistenceContextAsync(session, in createInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialPersistenceContextAsync(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialPersistenceContextCreateInfoEXT> createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialPersistenceContextAsync(session, in createInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialPersistenceContextComplete(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<CreateSpatialPersistenceContextCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialPersistenceContextComplete(session, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialPersistenceScopes(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] uint* persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] Span<SpatialPersistenceScopeEXT> persistenceScopes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialPersistenceScopes(instance, systemId, persistenceScopeCapacityInput, persistenceScopeCountOutput, ref persistenceScopes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialPersistenceScopes(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] Span<uint> persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] SpatialPersistenceScopeEXT* persistenceScopes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialPersistenceScopes(instance, systemId, persistenceScopeCapacityInput, ref persistenceScopeCountOutput.GetPinnableReference(), persistenceScopes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialPersistenceScopes(this ExtSpatialPersistence thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint persistenceScopeCapacityInput, [Count(Count = 0)] Span<uint> persistenceScopeCountOutput, [Count(Parameter = "persistenceScopeCapacityInput")] Span<SpatialPersistenceScopeEXT> persistenceScopes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialPersistenceScopes(instance, systemId, persistenceScopeCapacityInput, ref persistenceScopeCountOutput.GetPinnableReference(), ref persistenceScopes.GetPinnableReference());
        }

    }
}

