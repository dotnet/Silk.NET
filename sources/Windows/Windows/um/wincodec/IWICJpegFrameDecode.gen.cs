// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode"]/*' />
[Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
[NativeTypeName("struct IWICJpegFrameDecode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IWICJpegFrameDecode : IWICJpegFrameDecode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameDecode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint>)(lpVtbl[1]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint>)(lpVtbl[2]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.DoesSupportIndexing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportIndexing(BOOL* pfIndexingSupported)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, BOOL*, int>)(lpVtbl[3]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.SetIndexing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, WICJpegIndexingOptions, uint, int>)(lpVtbl[4]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.ClearIndexing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearIndexing()
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, int>)(lpVtbl[5]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.GetAcHuffmanTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int>)(lpVtbl[6]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.GetDcHuffmanTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int>)(lpVtbl[7]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.GetQuantizationTable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int>)(lpVtbl[8]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.GetFrameHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFrameHeader(WICJpegFrameHeader* pFrameHeader)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, WICJpegFrameHeader*, int>)(lpVtbl[9]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.GetScanHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, WICJpegScanHeader*, int>)(lpVtbl[10]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.CopyScan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)(lpVtbl[11]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
    }

    /// <include file='IWICJpegFrameDecode.xml' path='doc/member[@name="IWICJpegFrameDecode.CopyMinimalStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual)
    {
        return ((delegate* unmanaged<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)(lpVtbl[12]))((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
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
        HRESULT GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

        [VtblIndex(7)]
        HRESULT GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

        [VtblIndex(8)]
        HRESULT GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

        [VtblIndex(9)]
        HRESULT GetFrameHeader(WICJpegFrameHeader* pFrameHeader);

        [VtblIndex(10)]
        HRESULT GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader);

        [VtblIndex(11)]
        HRESULT CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual);

        [VtblIndex(12)]
        HRESULT CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual);
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

        [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int> GetAcHuffmanTable;

        [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int> GetDcHuffmanTable;

        [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int> GetQuantizationTable;

        [NativeTypeName("HRESULT (WICJpegFrameHeader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICJpegFrameHeader*, int> GetFrameHeader;

        [NativeTypeName("HRESULT (UINT, WICJpegScanHeader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WICJpegScanHeader*, int> GetScanHeader;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, byte*, uint*, int> CopyScan;

        [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, int> CopyMinimalStream;
    }
}
