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

namespace Silk.NET.Direct3D12
{
    public static class D3D12Overloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public static unsafe int SerializeRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RootSignatureDesc> pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeRootSignature(in pRootSignature.GetPinnableReference(), Version, ppBlob, ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public static unsafe int SerializeRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RootSignatureDesc> pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeRootSignature(in pRootSignature.GetPinnableReference(), Version, ppBlob, ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public static unsafe int SerializeRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RootSignatureDesc> pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeRootSignature(in pRootSignature.GetPinnableReference(), Version, ref ppBlob, ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public static unsafe int SerializeRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RootSignatureDesc> pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeRootSignature(in pRootSignature.GetPinnableReference(), Version, ref ppBlob, ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer)
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, pRootSignatureDeserializerInterface, ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, pRootSignatureDeserializerInterface, ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public static unsafe int CreateRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public static unsafe int SerializeVersionedRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeVersionedRootSignature(in pRootSignature.GetPinnableReference(), ppBlob, ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public static unsafe int SerializeVersionedRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeVersionedRootSignature(in pRootSignature.GetPinnableReference(), ppBlob, ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public static unsafe int SerializeVersionedRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeVersionedRootSignature(in pRootSignature.GetPinnableReference(), ref ppBlob, ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public static unsafe int SerializeVersionedRootSignature(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VersionedRootSignatureDesc> pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob)
        {
            // SpanOverloader
            return thisApi.SerializeVersionedRootSignature(in pRootSignature.GetPinnableReference(), ref ppBlob, ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer)
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer)
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, pRootSignatureDeserializerInterface, ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, pRootSignatureDeserializerInterface, ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public static unsafe int CreateVersionedRootSignatureDeserializer<T0>(this D3D12 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcData, nuint SrcDataSizeInBytes, Span<Guid> pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateVersionedRootSignatureDeserializer(in pSrcData.GetPinnableReference(), SrcDataSizeInBytes, ref pRootSignatureDeserializerInterface.GetPinnableReference(), ref ppRootSignatureDeserializer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Span<Guid> riid, void** ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, MinimumFeatureLevel, ref riid.GetPinnableReference(), ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Span<Guid> riid, ref void* ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(pAdapter, MinimumFeatureLevel, ref riid.GetPinnableReference(), ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, void** ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), MinimumFeatureLevel, riid, ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), MinimumFeatureLevel, riid, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Span<Guid> riid, void** ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), MinimumFeatureLevel, ref riid.GetPinnableReference(), ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public static unsafe int CreateDevice(this D3D12 thisApi, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Span<Guid> riid, ref void* ppDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref pAdapter.GetPinnableReference(), MinimumFeatureLevel, ref riid.GetPinnableReference(), ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        public static unsafe int GetDebugInterface(this D3D12 thisApi, Span<Guid> riid, void** ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface(ref riid.GetPinnableReference(), ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        public static unsafe int GetDebugInterface(this D3D12 thisApi, Span<Guid> riid, ref void* ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetDebugInterface(ref riid.GetPinnableReference(), ref ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, Span<uint> pConfigurationStructSizes)
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, pIIDs, pConfigurationStructs, ref pConfigurationStructSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures<T0>(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, Span<T0> pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, pIIDs, ref pConfigurationStructs.GetPinnableReference(), pConfigurationStructSizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures<T0>(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, Span<T0> pConfigurationStructs, Span<uint> pConfigurationStructSizes) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, pIIDs, ref pConfigurationStructs.GetPinnableReference(), ref pConfigurationStructSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), pConfigurationStructs, pConfigurationStructSizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, void* pConfigurationStructs, Span<uint> pConfigurationStructSizes)
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), pConfigurationStructs, ref pConfigurationStructSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures<T0>(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, Span<T0> pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), ref pConfigurationStructs.GetPinnableReference(), pConfigurationStructSizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        public static unsafe int EnableExperimentalFeatures<T0>(this D3D12 thisApi, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, Span<T0> pConfigurationStructs, Span<uint> pConfigurationStructSizes) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), ref pConfigurationStructs.GetPinnableReference(), ref pConfigurationStructSizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Guid* rclsid, Span<Guid> riid, void** ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(rclsid, ref riid.GetPinnableReference(), ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Guid* rclsid, Span<Guid> riid, ref void* ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(rclsid, ref riid.GetPinnableReference(), ref ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Span<Guid> rclsid, Guid* riid, void** ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(ref rclsid.GetPinnableReference(), riid, ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Span<Guid> rclsid, Guid* riid, ref void* ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(ref rclsid.GetPinnableReference(), riid, ref ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Span<Guid> rclsid, Span<Guid> riid, void** ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ppvDebug);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public static unsafe int GetInterface(this D3D12 thisApi, Span<Guid> rclsid, Span<Guid> riid, ref void* ppvDebug)
        {
            // SpanOverloader
            return thisApi.GetInterface(ref rclsid.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvDebug);
        }

    }
}

