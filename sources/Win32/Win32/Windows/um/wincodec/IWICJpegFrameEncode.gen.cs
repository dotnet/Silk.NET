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

[Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
[NativeTypeName("struct IWICJpegFrameEncode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IWICJpegFrameEncode : IWICJpegFrameEncode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameEncode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICJpegFrameEncode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICJpegFrameEncode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICJpegFrameEncode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAcHuffmanTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameEncode,
                uint,
                uint,
                DXGI_JPEG_AC_HUFFMAN_TABLE*,
                int>)((*lpVtbl)[3])
        )(this, scanIndex, tableIndex, pAcHuffmanTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDcHuffmanTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameEncode,
                uint,
                uint,
                DXGI_JPEG_DC_HUFFMAN_TABLE*,
                int>)((*lpVtbl)[4])
        )(this, scanIndex, tableIndex, pDcHuffmanTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetQuantizationTable(
        uint scanIndex,
        uint tableIndex,
        DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
    )
    {
        return (
            (delegate* unmanaged<
                IWICJpegFrameEncode,
                uint,
                uint,
                DXGI_JPEG_QUANTIZATION_TABLE*,
                int>)((*lpVtbl)[5])
        )(this, scanIndex, tableIndex, pQuantizationTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteScan(uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
    {
        return ((delegate* unmanaged<IWICJpegFrameEncode, uint, byte*, int>)((*lpVtbl)[6]))(
            this,
            cbScanData,
            pbScanData
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable
        );

        [VtblIndex(4)]
        HRESULT GetDcHuffmanTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable
        );

        [VtblIndex(5)]
        HRESULT GetQuantizationTable(
            uint scanIndex,
            uint tableIndex,
            DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable
        );

        [VtblIndex(6)]
        HRESULT WriteScan(uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData);
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

        [NativeTypeName("HRESULT (UINT, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> WriteScan;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICJpegFrameEncode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICJpegFrameEncode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICJpegFrameEncode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICJpegFrameEncode(Silk.NET.Windows.IUnknown value)
    {
        return new IWICJpegFrameEncode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICJpegFrameEncode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICJpegFrameEncode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICJpegFrameEncode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
