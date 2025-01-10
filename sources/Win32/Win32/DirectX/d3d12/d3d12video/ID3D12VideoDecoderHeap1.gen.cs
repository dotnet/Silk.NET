// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("DA1D98C5-539F-41B2-BF6B-1198A03B6D26")]
[NativeTypeName("struct ID3D12VideoDecoderHeap1 : ID3D12VideoDecoderHeap")]
[NativeInheritance("ID3D12VideoDecoderHeap")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12VideoDecoderHeap1
    : ID3D12VideoDecoderHeap1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDecoderHeap1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, uint*, void*, int>)((*lpVtbl)[3])
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, uint, void*, int>)((*lpVtbl)[4])
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, ushort*, int>)((*lpVtbl)[6]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D3D12_VIDEO_DECODER_HEAP_DESC GetDesc()
    {
        D3D12_VIDEO_DECODER_HEAP_DESC result;
        return *(
            (delegate* unmanaged<
                ID3D12VideoDecoderHeap1,
                D3D12_VIDEO_DECODER_HEAP_DESC*,
                D3D12_VIDEO_DECODER_HEAP_DESC*>)((*lpVtbl)[8])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetProtectedResourceSession(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppProtectedSession
    )
    {
        return ((delegate* unmanaged<ID3D12VideoDecoderHeap1, Guid*, void**, int>)((*lpVtbl)[9]))(
            this,
            riid,
            ppProtectedSession
        );
    }

    public interface Interface : ID3D12VideoDecoderHeap.Interface
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
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("D3D12_VIDEO_DECODER_HEAP_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VIDEO_DECODER_HEAP_DESC*,
            D3D12_VIDEO_DECODER_HEAP_DESC*> GetDesc;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetProtectedResourceSession;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDecoderHeap1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDecoderHeap1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12VideoDecoderHeap"/> to <see cref = "ID3D12VideoDecoderHeap1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12VideoDecoderHeap"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecoderHeap1(
        Silk.NET.DirectX.ID3D12VideoDecoderHeap value
    )
    {
        return new ID3D12VideoDecoderHeap1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecoderHeap1"/> to <see cref = "Silk.NET.DirectX.ID3D12VideoDecoderHeap"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecoderHeap1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12VideoDecoderHeap(
        ID3D12VideoDecoderHeap1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12VideoDecoderHeap(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> to <see cref = "ID3D12VideoDecoderHeap1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecoderHeap1(Silk.NET.DirectX.ID3D12Pageable value)
    {
        return new ID3D12VideoDecoderHeap1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecoderHeap1"/> to <see cref = "Silk.NET.DirectX.ID3D12Pageable"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecoderHeap1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Pageable(ID3D12VideoDecoderHeap1 value)
    {
        return new Silk.NET.DirectX.ID3D12Pageable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12VideoDecoderHeap1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecoderHeap1(
        Silk.NET.DirectX.ID3D12DeviceChild value
    )
    {
        return new ID3D12VideoDecoderHeap1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecoderHeap1"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecoderHeap1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(
        ID3D12VideoDecoderHeap1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12VideoDecoderHeap1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecoderHeap1(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12VideoDecoderHeap1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecoderHeap1"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecoderHeap1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12VideoDecoderHeap1 value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VideoDecoderHeap1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecoderHeap1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12VideoDecoderHeap1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoDecoderHeap1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecoderHeap1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12VideoDecoderHeap1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
