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
    [Extension("XR_EXT_spatial_entity")]
    public unsafe partial class ExtSpatialEntity : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_spatial_entity";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialContextCreateInfoEXT* createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialContextCreateInfoEXT* createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialContextCreateInfoEXT createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextAsyncEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialContextAsync([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialContextCreateInfoEXT createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialContextComplete([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] CreateSpatialContextCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialContextCompleteEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialContextComplete([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref CreateSpatialContextCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotAsync([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialDiscoverySnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotAsync([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialDiscoverySnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotAsyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotAsync([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialDiscoverySnapshotCreateInfoEXT createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotAsyncEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialDiscoverySnapshotAsync([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialDiscoverySnapshotCreateInfoEXT createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotComplete([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CreateSpatialDiscoverySnapshotCompletionInfoEXT* createSnapshotCompletionInfo, [Count(Count = 0)] CreateSpatialDiscoverySnapshotCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotComplete([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CreateSpatialDiscoverySnapshotCompletionInfoEXT* createSnapshotCompletionInfo, [Count(Count = 0)] ref CreateSpatialDiscoverySnapshotCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotCompleteEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialDiscoverySnapshotComplete([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CreateSpatialDiscoverySnapshotCompletionInfoEXT createSnapshotCompletionInfo, [Count(Count = 0)] CreateSpatialDiscoverySnapshotCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialDiscoverySnapshotCompleteEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialDiscoverySnapshotComplete([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CreateSpatialDiscoverySnapshotCompletionInfoEXT createSnapshotCompletionInfo, [Count(Count = 0)] ref CreateSpatialDiscoverySnapshotCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityFromIdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityFromId([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityFromIdCreateInfoEXT* createInfo, [Count(Count = 0)] SpatialEntityEXT* spatialEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityFromIdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityFromId([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityFromIdCreateInfoEXT* createInfo, [Count(Count = 0)] ref SpatialEntityEXT spatialEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityFromIdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityFromId([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityFromIdCreateInfoEXT createInfo, [Count(Count = 0)] SpatialEntityEXT* spatialEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityFromIdEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialEntityFromId([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityFromIdCreateInfoEXT createInfo, [Count(Count = 0)] ref SpatialEntityEXT spatialEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialUpdateSnapshotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialUpdateSnapshot([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialUpdateSnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] SpatialSnapshotEXT* snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialUpdateSnapshotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialUpdateSnapshot([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialUpdateSnapshotCreateInfoEXT* createInfo, [Count(Count = 0)] ref SpatialSnapshotEXT snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialUpdateSnapshotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialUpdateSnapshot([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialUpdateSnapshotCreateInfoEXT createInfo, [Count(Count = 0)] SpatialSnapshotEXT* snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialUpdateSnapshotEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialUpdateSnapshot([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialUpdateSnapshotCreateInfoEXT createInfo, [Count(Count = 0)] ref SpatialSnapshotEXT snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialContextEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialContext([Count(Count = 0)] SpatialContextEXT spatialContext);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialEntityEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialEntity([Count(Count = 0)] SpatialEntityEXT spatialEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialSnapshotEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialSnapshot([Count(Count = 0)] SpatialSnapshotEXT snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilitiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] uint* capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] SpatialCapabilityEXT* capabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilitiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] uint* capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] ref SpatialCapabilityEXT capabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilitiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] ref uint capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] SpatialCapabilityEXT* capabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilitiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint capabilityCapacityInput, [Count(Count = 0)] ref uint capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] ref SpatialCapabilityEXT capabilities);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityComponentTypesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilityComponentTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] SpatialCapabilityComponentTypesEXT* capabilityComponents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityComponentTypesEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpatialCapabilityComponentTypes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] ref SpatialCapabilityComponentTypesEXT capabilityComponents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityFeaturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] uint* capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] SpatialCapabilityFeatureEXT* capabilityFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityFeaturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] uint* capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] ref SpatialCapabilityFeatureEXT capabilityFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityFeaturesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] ref uint capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] SpatialCapabilityFeatureEXT* capabilityFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialCapabilityFeaturesEXT", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint capabilityFeatureCapacityInput, [Count(Count = 0)] ref uint capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] ref SpatialCapabilityFeatureEXT capabilityFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref float buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref float buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref float buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] float* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferFloatEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref float buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferStringEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref ushort buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref ushort buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref ushort buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ushort* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint16EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref ushort buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref uint buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref uint buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref uint buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] uint* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint32EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref uint buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferUint8EXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector2f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector2f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector2f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector2f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector2fEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector2f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector3f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector3f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector3f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Vector3f* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialBufferVector3fEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref Vector3f buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialComponentDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialComponentData([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialComponentDataQueryConditionEXT* queryCondition, [Count(Count = 0)] SpatialComponentDataQueryResultEXT* queryResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialComponentDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialComponentData([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialComponentDataQueryConditionEXT* queryCondition, [Count(Count = 0)] ref SpatialComponentDataQueryResultEXT queryResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialComponentDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpatialComponentData([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialComponentDataQueryConditionEXT queryCondition, [Count(Count = 0)] SpatialComponentDataQueryResultEXT* queryResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpatialComponentDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result QuerySpatialComponentData([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialComponentDataQueryConditionEXT queryCondition, [Count(Count = 0)] ref SpatialComponentDataQueryResultEXT queryResult);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] Span<SpatialCapabilityEXT> capabilities)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialCapabilities(instance, systemId, (uint) capabilities.Length, capabilityCountOutput, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialCapabilities([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint capabilityCountOutput, [Count(Parameter = "capabilityCapacityInput")] Span<SpatialCapabilityEXT> capabilities)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialCapabilities(instance, systemId, (uint) capabilities.Length, ref capabilityCountOutput, ref capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] uint* capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] Span<SpatialCapabilityFeatureEXT> capabilityFeatures)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialCapabilityFeatures(instance, systemId, capability, (uint) capabilityFeatures.Length, capabilityFeatureCountOutput, ref capabilityFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialCapabilityFeatures([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SpatialCapabilityEXT capability, [Count(Count = 0)] ref uint capabilityFeatureCountOutput, [Count(Parameter = "capabilityFeatureCapacityInput")] Span<SpatialCapabilityFeatureEXT> capabilityFeatures)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialCapabilityFeatures(instance, systemId, capability, (uint) capabilityFeatures.Length, ref capabilityFeatureCountOutput, ref capabilityFeatures.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferFloat(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferFloat(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferFloat(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferFloat([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<float> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferFloat(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferString(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferString(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferString(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferString([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferString(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint16(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint16(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint16(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint16([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<ushort> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint16(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint32(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint32(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint32(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint32([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<uint> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint32(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint8(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint8(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint8(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferUint8([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferUint8(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector2(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector2(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector2(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector2([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector2f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector2(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector3(snapshot, info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialBufferGetInfoEXT* info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector3(snapshot, info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector3(snapshot, in info, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSpatialBufferVector3([Count(Count = 0)] SpatialSnapshotEXT snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialBufferGetInfoEXT info, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<Vector3f> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSpatialBufferVector3(snapshot, in info, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        public ExtSpatialEntity(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

