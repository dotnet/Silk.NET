// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12SerializeRootSignature"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12SerializeRootSignature([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")] D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateRootSignatureDeserializer"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12CreateRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12SerializeVersionedRootSignature"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature, ID3DBlob** ppBlob, ID3DBlob** ppErrorBlob);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateVersionedRootSignatureDeserializer"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12CreateVersionedRootSignatureDeserializer([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes, [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateDevice"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12CreateDevice(IUnknown* pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, [NativeTypeName("const IID &")] Guid* riid, void** ppDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetDebugInterface"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12GetDebugInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvDebug);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12EnableExperimentalFeatures"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, [NativeTypeName("const IID *")] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);
    [NativeTypeName("const UUID")]
    public static ref readonly Guid D3D12ExperimentalShaderModels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x3E, 0x57, 0xF5, 0x76, 0x3A, 0xF1, 0xF5, 0x40, 0xB2, 0x97, 0x81, 0xCE, 0x9E, 0x18, 0x93, 0x3F];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const UUID")]
    public static ref readonly Guid D3D12TiledResourceTier4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [0x5F, 0x72, 0xC4, 0xC9, 0x1A, 0xA8, 0x56, 0x4F, 0x8C, 0x5B, 0xC5, 0x10, 0x39, 0xD6, 0x94, 0xFB];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetInterface"]/*'/>
    [DllImport("d3d12", ExactSpelling = true)]
    public static extern HRESULT D3D12GetInterface([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, void** ppvDebug);
}