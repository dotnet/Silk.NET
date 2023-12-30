// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12VideoDecoder1.xml' path='doc/member[@name="ID3D12VideoDecoder1"]/*'/>
[Guid("79A2E5FB-CCD2-469A-9FDE-195D10951F7E")]
[NativeTypeName("struct ID3D12VideoDecoder1 : ID3D12VideoDecoder")]
[NativeInheritance("ID3D12VideoDecoder")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct ID3D12VideoDecoder1 : ID3D12VideoDecoder1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDecoder1));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, uint>)(lpVtbl[1]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, uint>)(lpVtbl[2]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, uint*, void*, int>)(lpVtbl[3]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            guid,
            pDataSize,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, uint, void*, int>)(lpVtbl[4]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            guid,
            DataSize,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown* pData
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, IUnknown*, int>)(lpVtbl[5]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            guid,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, ushort*, int>)(lpVtbl[6]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            Name
        );
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, void**, int>)(lpVtbl[7]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            riid,
            ppvDevice
        );
    }

    /// <inheritdoc cref = "ID3D12VideoDecoder.GetDesc"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D3D12_VIDEO_DECODER_DESC GetDesc()
    {
        D3D12_VIDEO_DECODER_DESC result;
        return *(
            (delegate* unmanaged<
                ID3D12VideoDecoder1*,
                D3D12_VIDEO_DECODER_DESC*,
                D3D12_VIDEO_DECODER_DESC*>)(lpVtbl[8])
        )((ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID3D12VideoDecoder1.xml' path='doc/member[@name="ID3D12VideoDecoder1.GetProtectedResourceSession"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetProtectedResourceSession(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppProtectedSession
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoder1*, Guid*, void**, int>)(lpVtbl[9]))(
            (ID3D12VideoDecoder1*)Unsafe.AsPointer(ref this),
            riid,
            ppProtectedSession
        );
    }

    public interface Interface : ID3D12VideoDecoder.Interface
    {
        [VtblIndex(9)]
        HRESULT GetProtectedResourceSession(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppProtectedSession
        );
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

        [NativeTypeName("D3D12_VIDEO_DECODER_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_DESC*,
            D3D12_VIDEO_DECODER_DESC*> GetDesc;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetProtectedResourceSession;
    }
}
