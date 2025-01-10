// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("465217F2-5568-43CF-B5B9-F61D54531CA1")]
[NativeTypeName("struct ID3D11VideoProcessorEnumerator1 : ID3D11VideoProcessorEnumerator")]
[NativeInheritance("ID3D11VideoProcessorEnumerator")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID3D11VideoProcessorEnumerator1
    : ID3D11VideoProcessorEnumerator1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessorEnumerator1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessorEnumerator1, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoProcessorEnumerator1, ID3D11Device*, void>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessorEnumerator1, Guid*, uint*, void*, int>)(
                (*lpVtbl)[4]
            )
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessorEnumerator1, Guid*, uint, void*, int>)(
                (*lpVtbl)[5]
            )
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessorEnumerator1, Guid*, IUnknown, int>)(
                (*lpVtbl)[6]
            )
        )(this, guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVideoProcessorContentDesc(D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pContentDesc)
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                D3D11_VIDEO_PROCESSOR_CONTENT_DESC*,
                int>)((*lpVtbl)[7])
        )(this, pContentDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CheckVideoProcessorFormat(DXGI_FORMAT Format, uint* pFlags)
    {
        return (
            (delegate* unmanaged<ID3D11VideoProcessorEnumerator1, DXGI_FORMAT, uint*, int>)(
                (*lpVtbl)[8]
            )
        )(this, Format, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetVideoProcessorCaps(D3D11_VIDEO_PROCESSOR_CAPS* pCaps)
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                D3D11_VIDEO_PROCESSOR_CAPS*,
                int>)((*lpVtbl)[9])
        )(this, pCaps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetVideoProcessorRateConversionCaps(
        uint TypeIndex,
        D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS* pCaps
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                uint,
                D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*,
                int>)((*lpVtbl)[10])
        )(this, TypeIndex, pCaps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetVideoProcessorCustomRate(
        uint TypeIndex,
        uint CustomRateIndex,
        D3D11_VIDEO_PROCESSOR_CUSTOM_RATE* pRate
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                uint,
                uint,
                D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*,
                int>)((*lpVtbl)[11])
        )(this, TypeIndex, CustomRateIndex, pRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetVideoProcessorFilterRange(
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        D3D11_VIDEO_PROCESSOR_FILTER_RANGE* pRange
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                D3D11_VIDEO_PROCESSOR_FILTER,
                D3D11_VIDEO_PROCESSOR_FILTER_RANGE*,
                int>)((*lpVtbl)[12])
        )(this, Filter, pRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckVideoProcessorFormatConversion(
        DXGI_FORMAT InputFormat,
        DXGI_COLOR_SPACE_TYPE InputColorSpace,
        DXGI_FORMAT OutputFormat,
        DXGI_COLOR_SPACE_TYPE OutputColorSpace,
        BOOL* pSupported
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoProcessorEnumerator1,
                DXGI_FORMAT,
                DXGI_COLOR_SPACE_TYPE,
                DXGI_FORMAT,
                DXGI_COLOR_SPACE_TYPE,
                BOOL*,
                int>)((*lpVtbl)[13])
        )(this, InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
    }

    public interface Interface : ID3D11VideoProcessorEnumerator.Interface
    {
        [VtblIndex(13)]
        HRESULT CheckVideoProcessorFormatConversion(
            DXGI_FORMAT InputFormat,
            DXGI_COLOR_SPACE_TYPE InputColorSpace,
            DXGI_FORMAT OutputFormat,
            DXGI_COLOR_SPACE_TYPE OutputColorSpace,
            BOOL* pSupported
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CONTENT_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D11_VIDEO_PROCESSOR_CONTENT_DESC*,
            int> GetVideoProcessorContentDesc;

        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint*, int> CheckVideoProcessorFormat;

        [NativeTypeName("HRESULT (D3D11_VIDEO_PROCESSOR_CAPS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_PROCESSOR_CAPS*, int> GetVideoProcessorCaps;

        [NativeTypeName(
            "HRESULT (UINT, D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS*,
            int> GetVideoProcessorRateConversionCaps;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3D11_VIDEO_PROCESSOR_CUSTOM_RATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3D11_VIDEO_PROCESSOR_CUSTOM_RATE*,
            int> GetVideoProcessorCustomRate;

        [NativeTypeName(
            "HRESULT (D3D11_VIDEO_PROCESSOR_FILTER, D3D11_VIDEO_PROCESSOR_FILTER_RANGE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_VIDEO_PROCESSOR_FILTER,
            D3D11_VIDEO_PROCESSOR_FILTER_RANGE*,
            int> GetVideoProcessorFilterRange;

        [NativeTypeName(
            "HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_FORMAT,
            DXGI_COLOR_SPACE_TYPE,
            DXGI_FORMAT,
            DXGI_COLOR_SPACE_TYPE,
            BOOL*,
            int> CheckVideoProcessorFormatConversion;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11VideoProcessorEnumerator1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11VideoProcessorEnumerator1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11VideoProcessorEnumerator"/> to <see cref = "ID3D11VideoProcessorEnumerator1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11VideoProcessorEnumerator"/> instance to be converted </param>
    public static explicit operator ID3D11VideoProcessorEnumerator1(
        Silk.NET.DirectX.ID3D11VideoProcessorEnumerator value
    )
    {
        return new ID3D11VideoProcessorEnumerator1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoProcessorEnumerator1"/> to <see cref = "Silk.NET.DirectX.ID3D11VideoProcessorEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoProcessorEnumerator1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11VideoProcessorEnumerator(
        ID3D11VideoProcessorEnumerator1 value
    )
    {
        return new Silk.NET.DirectX.ID3D11VideoProcessorEnumerator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11VideoProcessorEnumerator1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11VideoProcessorEnumerator1(
        Silk.NET.DirectX.ID3D11DeviceChild value
    )
    {
        return new ID3D11VideoProcessorEnumerator1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoProcessorEnumerator1"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoProcessorEnumerator1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(
        ID3D11VideoProcessorEnumerator1 value
    )
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11VideoProcessorEnumerator1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11VideoProcessorEnumerator1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11VideoProcessorEnumerator1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoProcessorEnumerator1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoProcessorEnumerator1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11VideoProcessorEnumerator1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
