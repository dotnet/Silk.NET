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

[Guid("22B35D96-876A-44C0-B25E-FB8C9C7F1C4A")]
[NativeTypeName("struct ID3D12VideoEncoderHeap : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct ID3D12VideoEncoderHeap : ID3D12VideoEncoderHeap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoEncoderHeap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<ID3D12VideoEncoderHeap, Guid*, uint*, void*, int>)((*lpVtbl)[3])
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
            (delegate* unmanaged<ID3D12VideoEncoderHeap, Guid*, uint, void*, int>)((*lpVtbl)[4])
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, ushort*, int>)((*lpVtbl)[6]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeMask()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS GetEncoderHeapFlags()
    {
        return (
            (delegate* unmanaged<ID3D12VideoEncoderHeap, D3D12_VIDEO_ENCODER_HEAP_FLAGS>)(
                (*lpVtbl)[9]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_VIDEO_ENCODER_CODEC GetCodec()
    {
        return (
            (delegate* unmanaged<ID3D12VideoEncoderHeap, D3D12_VIDEO_ENCODER_CODEC>)((*lpVtbl)[10])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile)
    {
        return (
            (delegate* unmanaged<ID3D12VideoEncoderHeap, D3D12_VIDEO_ENCODER_PROFILE_DESC, int>)(
                (*lpVtbl)[11]
            )
        )(this, dstProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCodecLevel(D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel)
    {
        return (
            (delegate* unmanaged<ID3D12VideoEncoderHeap, D3D12_VIDEO_ENCODER_LEVEL_SETTING, int>)(
                (*lpVtbl)[12]
            )
        )(this, dstLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetResolutionListCount()
    {
        return ((delegate* unmanaged<ID3D12VideoEncoderHeap, uint>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetResolutionList(
        [NativeTypeName("const UINT")] uint ResolutionsListCount,
        D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VideoEncoderHeap,
                uint,
                D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC*,
                int>)((*lpVtbl)[14])
        )(this, ResolutionsListCount, pResolutionList);
    }

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(8)]
        uint GetNodeMask();

        [VtblIndex(9)]
        D3D12_VIDEO_ENCODER_HEAP_FLAGS GetEncoderHeapFlags();

        [VtblIndex(10)]
        D3D12_VIDEO_ENCODER_CODEC GetCodec();

        [VtblIndex(11)]
        HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile);

        [VtblIndex(12)]
        HRESULT GetCodecLevel(D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel);

        [VtblIndex(13)]
        uint GetResolutionListCount();

        [VtblIndex(14)]
        HRESULT GetResolutionList(
            [NativeTypeName("const UINT")] uint ResolutionsListCount,
            D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNodeMask;

        [NativeTypeName("D3D12_VIDEO_ENCODER_HEAP_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_HEAP_FLAGS> GetEncoderHeapFlags;

        [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_CODEC> GetCodec;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_PROFILE_DESC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_PROFILE_DESC, int> GetCodecProfile;

        [NativeTypeName("HRESULT (D3D12_VIDEO_ENCODER_LEVEL_SETTING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VIDEO_ENCODER_LEVEL_SETTING, int> GetCodecLevel;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetResolutionListCount;

        [NativeTypeName(
            "HRESULT (const UINT, D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC*,
            int> GetResolutionList;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoEncoderHeap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoEncoderHeap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> to <see cref = "ID3D12VideoEncoderHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> instance to be converted </param>
    public static explicit operator ID3D12VideoEncoderHeap(Silk.NET.DirectX.ID3D12Pageable value)
    {
        return new ID3D12VideoEncoderHeap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoEncoderHeap"/> to <see cref = "Silk.NET.DirectX.ID3D12Pageable"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoEncoderHeap"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Pageable(ID3D12VideoEncoderHeap value)
    {
        return new Silk.NET.DirectX.ID3D12Pageable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12VideoEncoderHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12VideoEncoderHeap(Silk.NET.DirectX.ID3D12DeviceChild value)
    {
        return new ID3D12VideoEncoderHeap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoEncoderHeap"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoEncoderHeap"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(ID3D12VideoEncoderHeap value)
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12VideoEncoderHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12VideoEncoderHeap(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12VideoEncoderHeap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoEncoderHeap"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoEncoderHeap"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12VideoEncoderHeap value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VideoEncoderHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VideoEncoderHeap(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12VideoEncoderHeap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VideoEncoderHeap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoEncoderHeap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12VideoEncoderHeap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
