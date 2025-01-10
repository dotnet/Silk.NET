// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
[NativeTypeName("struct IWICJpegFrameDecode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IWICJpegFrameDecode : IWICJpegFrameDecode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameDecode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICJpegFrameDecode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportIndexing(BOOL* pfIndexingSupported)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            pfIndexingSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize)
    {
        return (
            (delegate* unmanaged<IWICJpegFrameDecode, WICJpegIndexingOptions, uint, int>)(
                (*lpVtbl)[4]
            )
        )(this, options, horizontalIntervalSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearIndexing()
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAcHuffmanTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameDecode,
                uint,
                uint,
                DXGI_JPEG_AC_HUFFMAN_TABLE*,
                int>)((*lpVtbl)[6])
        )(this, scanIndex, tableIndex, pAcHuffmanTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDcHuffmanTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameDecode,
                uint,
                uint,
                DXGI_JPEG_DC_HUFFMAN_TABLE*,
                int>)((*lpVtbl)[7])
        )(this, scanIndex, tableIndex, pDcHuffmanTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetQuantizationTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameDecode,
                uint,
                uint,
                DXGI_JPEG_QUANTIZATION_TABLE*,
                int>)((*lpVtbl)[8])
        )(this, scanIndex, tableIndex, pQuantizationTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFrameHeader(WICJpegFrameHeader* pFrameHeader)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode, WICJpegFrameHeader*, int>)((*lpVtbl)[9]))(
            this,
            pFrameHeader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader)
    {
        return (
            (delegate* unmanaged<IWICJpegFrameDecode, uint, WICJpegScanHeader*, int>)((*lpVtbl)[10])
        )(this, scanIndex, pScanHeader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CopyScan(
        uint scanIndex,
        uint scanOffset,
        uint cbScanData,
        byte* pbScanData,
        uint* pcbScanDataActual
    )
    {
        return (
            (delegate* unmanaged<IWICJpegFrameDecode, uint, uint, uint, byte*, uint*, int>)(
                (*lpVtbl)[11]
            )
        )(this, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CopyMinimalStream(
        uint streamOffset,
        uint cbStreamData,
        byte* pbStreamData,
        uint* pcbStreamDataActual
    )
    {
        return (
            (delegate* unmanaged<IWICJpegFrameDecode, uint, uint, byte*, uint*, int>)((*lpVtbl)[12])
        )(this, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoesSupportIndexing(BOOL* pfIndexingSupported);

        [VtblIndex(4)]
        HRESULT SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize);

        [VtblIndex(5)]
        HRESULT ClearIndexing();

        [VtblIndex(6)]
        HRESULT GetAcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        );

        [VtblIndex(7)]
        HRESULT GetDcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        );

        [VtblIndex(8)]
        HRESULT GetQuantizationTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        );

        [VtblIndex(9)]
        HRESULT GetFrameHeader(WICJpegFrameHeader* pFrameHeader);

        [VtblIndex(10)]
        HRESULT GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader);

        [VtblIndex(11)]
        HRESULT CopyScan(
            uint scanIndex,
            uint scanOffset,
            uint cbScanData,
            byte* pbScanData,
            uint* pcbScanDataActual
        );

        [VtblIndex(12)]
        HRESULT CopyMinimalStream(
            uint streamOffset,
            uint cbStreamData,
            byte* pbStreamData,
            uint* pcbStreamDataActual
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportIndexing;

        [NativeTypeName("HRESULT (WICJpegIndexingOptions, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICJpegIndexingOptions, uint, int> SetIndexing;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearIndexing;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_JPEG_AC_HUFFMAN_TABLE*,
            int> GetAcHuffmanTable;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_JPEG_DC_HUFFMAN_TABLE*,
            int> GetDcHuffmanTable;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_JPEG_QUANTIZATION_TABLE*,
            int> GetQuantizationTable;

        [NativeTypeName("HRESULT (WICJpegFrameHeader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICJpegFrameHeader*, int> GetFrameHeader;

        [NativeTypeName("HRESULT (UINT, WICJpegScanHeader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICJpegScanHeader*, int> GetScanHeader;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, byte*, uint*, int> CopyScan;

        [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, int> CopyMinimalStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICJpegFrameDecode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICJpegFrameDecode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICJpegFrameDecode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICJpegFrameDecode(Silk.NET.Windows.IUnknown value)
    {
        return new IWICJpegFrameDecode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICJpegFrameDecode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICJpegFrameDecode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICJpegFrameDecode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
