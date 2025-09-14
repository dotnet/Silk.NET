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
    public static class ExtSpatialEntityOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialContextAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialContextCreateInfoEXT* createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialContextAsync(session, createInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialContextAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialContextCreateInfoEXT> createInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialContextAsync(session, in createInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialContextAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialContextCreateInfoEXT> createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialContextAsync(session, in createInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialContextComplete(this ExtSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<CreateSpatialContextCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialContextComplete(session, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialDiscoverySnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotAsync(spatialContext, createInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialDiscoverySnapshotCreateInfoEXT> createInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotAsync(spatialContext, in createInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotAsync(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialDiscoverySnapshotCreateInfoEXT> createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotAsync(spatialContext, in createInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotComplete(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CreateSpatialDiscoverySnapshotCompletionInfoEXT* createSnapshotCompletionInfo, [Count(Count = 0)] Span<CreateSpatialDiscoverySnapshotCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotComplete(spatialContext, createSnapshotCompletionInfo, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotComplete(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreateSpatialDiscoverySnapshotCompletionInfoEXT> createSnapshotCompletionInfo, [Count(Count = 0)] CreateSpatialDiscoverySnapshotCompletionEXT* completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotComplete(spatialContext, in createSnapshotCompletionInfo.GetPinnableReference(), completion);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialDiscoverySnapshotComplete(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CreateSpatialDiscoverySnapshotCompletionInfoEXT> createSnapshotCompletionInfo, [Count(Count = 0)] Span<CreateSpatialDiscoverySnapshotCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialDiscoverySnapshotComplete(spatialContext, in createSnapshotCompletionInfo.GetPinnableReference(), ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityFromId(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityFromIdCreateInfoEXT* createInfo, [Count(Count = 0)] Span<SpatialEntityEXT> spatialEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityFromId(spatialContext, createInfo, ref spatialEntity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityFromId(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityFromIdCreateInfoEXT> createInfo, [Count(Count = 0)] SpatialEntityEXT* spatialEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityFromId(spatialContext, in createInfo.GetPinnableReference(), spatialEntity);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityFromId(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityFromIdCreateInfoEXT> createInfo, [Count(Count = 0)] Span<SpatialEntityEXT> spatialEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityFromId(spatialContext, in createInfo.GetPinnableReference(), ref spatialEntity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialUpdateSnapshot(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialUpdateSnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] Span<SpatialSnapshotEXT> snapshot)
        {
            // SpanOverloader
            return thisApi.CreateSpatialUpdateSnapshot(spatialContext, createInfo, ref snapshot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialUpdateSnapshot(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialUpdateSnapshotCreateInfoEXT> createInfo, [Count(Count = 0)] SpatialSnapshotEXT* snapshot)
        {
            // SpanOverloader
            return thisApi.CreateSpatialUpdateSnapshot(spatialContext, in createInfo.GetPinnableReference(), snapshot);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialUpdateSnapshot(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialUpdateSnapshotCreateInfoEXT> createInfo, [Count(Count = 0)] Span<SpatialSnapshotEXT> snapshot)
        {
            // SpanOverloader
            return thisApi.CreateSpatialUpdateSnapshot(spatialContext, in createInfo.GetPinnableReference(), ref snapshot.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilities(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] uint* capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] Span<SpatialCapabilityEXT> capabilities)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilities(instance, systemId, capabilityCapacityInput, capabilityCountOutput, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilities(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] Span<uint> capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] SpatialCapabilityEXT* capabilities)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilities(instance, systemId, capabilityCapacityInput, ref capabilityCountOutput.GetPinnableReference(), capabilities);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilities(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] Span<uint> capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] Span<SpatialCapabilityEXT> capabilities)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilities(instance, systemId, capabilityCapacityInput, ref capabilityCountOutput.GetPinnableReference(), ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilityComponentTypes(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] Span<SpatialCapabilityComponentTypesEXT> capabilityComponents)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilityComponentTypes(instance, systemId, capability, ref capabilityComponents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilityFeatures(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] uint* capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] Span<SpatialCapabilityFeatureEXT> capabilityFeatures)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilityFeatures(instance, systemId, capability, capabilityFeatureCapacityInput, capabilityFeatureCountOutput, ref capabilityFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilityFeatures(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] Span<uint> capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] SpatialCapabilityFeatureEXT* capabilityFeatures)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilityFeatures(instance, systemId, capability, capabilityFeatureCapacityInput, ref capabilityFeatureCountOutput.GetPinnableReference(), capabilityFeatures);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialCapabilityFeatures(this ExtSpatialEntity thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] Span<uint> capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] Span<SpatialCapabilityFeatureEXT> capabilityFeatures)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialCapabilityFeatures(instance, systemId, capability, capabilityFeatureCapacityInput, ref capabilityFeatureCountOutput.GetPinnableReference(), ref capabilityFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferFloat(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferFloat(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferString(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferString(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint16(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint16(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint32(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint32(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferUint8(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferUint8(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector2(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector2(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, info, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, info, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, in info.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialBufferVector3(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialBufferGetInfoEXT> info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // SpanOverloader
            return thisApi.GetSpatialBufferVector3(snapshot, in info.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialComponentData(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialComponentDataQueryConditionEXT* queryCondition, [Count(Count = 0)] Span<SpatialComponentDataQueryResultEXT> queryResult)
        {
            // SpanOverloader
            return thisApi.QuerySpatialComponentData(snapshot, queryCondition, ref queryResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialComponentData(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialComponentDataQueryConditionEXT> queryCondition, [Count(Count = 0)] SpatialComponentDataQueryResultEXT* queryResult)
        {
            // SpanOverloader
            return thisApi.QuerySpatialComponentData(snapshot, in queryCondition.GetPinnableReference(), queryResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialComponentData(this ExtSpatialEntity thisApi, [Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialComponentDataQueryConditionEXT> queryCondition, [Count(Count = 0)] Span<SpatialComponentDataQueryResultEXT> queryResult)
        {
            // SpanOverloader
            return thisApi.QuerySpatialComponentData(snapshot, in queryCondition.GetPinnableReference(), ref queryResult.GetPinnableReference());
        }

    }
}

