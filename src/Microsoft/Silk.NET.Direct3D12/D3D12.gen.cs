// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    public unsafe partial class D3D12 : NativeAPI
    {

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(ref RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(ref RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(ref RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3767, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature")]
        public unsafe partial int SerializeRootSignature(ref RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3779, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer")]
        public unsafe partial int CreateRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(VersionedRootSignatureDesc* pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(VersionedRootSignatureDesc* pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(VersionedRootSignatureDesc* pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(VersionedRootSignatureDesc* pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(ref VersionedRootSignatureDesc pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(ref VersionedRootSignatureDesc pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(ref VersionedRootSignatureDesc pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3790, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature")]
        public unsafe partial int SerializeVersionedRootSignature(ref VersionedRootSignatureDesc pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer(void* pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 3801, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>(ref T0 pSrcData, uint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, void** ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, void** ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, ref void* ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, void** ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, void** ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18561, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice")]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, ref void* ppDevice);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18570, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface")]
        public unsafe partial int GetDebugInterface(Guid* riid, void** ppvDebug);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18570, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface")]
        public unsafe partial int GetDebugInterface(Guid* riid, ref void* ppvDebug);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18570, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface")]
        public unsafe partial int GetDebugInterface(ref Guid riid, void** ppvDebug);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18570, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface")]
        public unsafe partial int GetDebugInterface(ref Guid riid, ref void* ppvDebug);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, Guid* pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, Guid* pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, Guid* pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, ref Guid pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, ref Guid pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes);

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, ref Guid pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeName("Src", "Line 18596, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures")]
        public partial int EnableExperimentalFeatures<T0>(uint NumFeatures, ref Guid pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged;


        public D3D12(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

