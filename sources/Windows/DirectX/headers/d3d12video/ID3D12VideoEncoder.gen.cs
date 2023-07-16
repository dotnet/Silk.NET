// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder"]/*'/>
[Guid("2E0D212D-8DF9-44A6-A770-BB289B182737")]
[NativeTypeName("struct ID3D12VideoEncoder : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12VideoEncoder : ID3D12VideoEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoEncoder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, uint> )(lpVtbl[1]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, uint> )(lpVtbl[2]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, Guid*, uint*, void*, int> )(lpVtbl[3]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, Guid*, uint, void*, int> )(lpVtbl[4]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, Guid*, IUnknown*, int> )(lpVtbl[5]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, ushort*, int> )(lpVtbl[6]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, Guid*, void**, int> )(lpVtbl[7]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetNodeMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeMask()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, uint> )(lpVtbl[8]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetEncoderFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_VIDEO_ENCODER_FLAGS GetEncoderFlags()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, D3D12_VIDEO_ENCODER_FLAGS> )(lpVtbl[9]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetCodec"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_VIDEO_ENCODER_CODEC GetCodec()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, D3D12_VIDEO_ENCODER_CODEC> )(lpVtbl[10]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetCodecProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int> )(lpVtbl[11]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), dstProfile);
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetCodecConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCodecConfiguration(D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION dstCodecConfig)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION, int> )(lpVtbl[12]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this), dstCodecConfig);
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetInputFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DXGI_FORMAT GetInputFormat()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, DXGI_FORMAT> )(lpVtbl[13]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VideoEncoder.xml' path='doc/member[@name="ID3D12VideoEncoder.GetMaxMotionEstimationPrecision"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE GetMaxMotionEstimationPrecision()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoder*, D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE> )(lpVtbl[14]))((ID3D12VideoEncoder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(8)]
        uint GetNodeMask();
        [VtblIndex(9)]
        D3D12_VIDEO_ENCODER_FLAGS GetEncoderFlags();
        [VtblIndex(10)]
        D3D12_VIDEO_ENCODER_CODEC GetCodec();
        [VtblIndex(11)]
        HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile);
        [VtblIndex(12)]
        HRESULT GetCodecConfiguration(D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION dstCodecConfig);
        [VtblIndex(13)]
        DXGI_FORMAT GetInputFormat();
        [VtblIndex(14)]
        D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE GetMaxMotionEstimationPrecision();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNodeMask;
        [NativeTypeName("D3D12_VIDEO_ENCODER_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_FLAGS> GetEncoderFlags;
        [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_CODEC> GetCodec;
        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_PROFILE_DESC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int> GetCodecProfile;
        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION, int> GetCodecConfiguration;
        [NativeTypeName("DXGI_FORMAT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT> GetInputFormat;
        [NativeTypeName("D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE> GetMaxMotionEstimationPrecision;
    }
}