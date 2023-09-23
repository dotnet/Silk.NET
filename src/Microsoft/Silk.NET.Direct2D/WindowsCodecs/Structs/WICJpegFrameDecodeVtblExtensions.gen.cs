// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICJpegFrameDecodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICJpegFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICJpegFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportIndexing(this ComPtr<IWICJpegFrameDecode> thisVtbl, int* pfIndexingSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int*, int>)@this->LpVtbl[3])(@this, pfIndexingSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportIndexing(this ComPtr<IWICJpegFrameDecode> thisVtbl, ref int pfIndexingSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIndexingSupportedPtr = &pfIndexingSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int*, int>)@this->LpVtbl[3])(@this, pfIndexingSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIndexing(this ComPtr<IWICJpegFrameDecode> thisVtbl, JpegIndexingOptions options, uint horizontalIntervalSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegIndexingOptions, uint, int>)@this->LpVtbl[4])(@this, options, horizontalIntervalSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ClearIndexing(this ComPtr<IWICJpegFrameDecode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[6])(@this, scanIndex, tableIndex, pAcHuffmanTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegACHuffmanTable pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTablePtr = &pAcHuffmanTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[6])(@this, scanIndex, tableIndex, pAcHuffmanTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[7])(@this, scanIndex, tableIndex, pDcHuffmanTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegDCHuffmanTable pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTablePtr = &pDcHuffmanTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[7])(@this, scanIndex, tableIndex, pDcHuffmanTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetQuantizationTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[8])(@this, scanIndex, tableIndex, pQuantizationTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetQuantizationTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegQuantizationTable pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTablePtr = &pQuantizationTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[8])(@this, scanIndex, tableIndex, pQuantizationTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, JpegFrameHeader* pFrameHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegFrameHeader*, int>)@this->LpVtbl[9])(@this, pFrameHeader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, ref JpegFrameHeader pFrameHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (JpegFrameHeader* pFrameHeaderPtr = &pFrameHeader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegFrameHeader*, int>)@this->LpVtbl[9])(@this, pFrameHeaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetScanHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, JpegScanHeader* pScanHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, JpegScanHeader*, int>)@this->LpVtbl[10])(@this, scanIndex, pScanHeader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetScanHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, ref JpegScanHeader pScanHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (JpegScanHeader* pScanHeaderPtr = &pScanHeader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, JpegScanHeader*, int>)@this->LpVtbl[10])(@this, scanIndex, pScanHeaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, ref uint pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, ref byte pbScanData, uint* pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbScanDataPtr = &pbScanData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, ref byte pbScanData, ref uint pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbScanDataPtr = &pbScanData)
        {
            fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData, uint* pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActual);
        SilkMarshal.Free((nint)pbScanDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData, ref uint pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
        fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActualPtr);
        }
        SilkMarshal.Free((nint)pbScanDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, byte* pbStreamData, ref uint pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, ref byte pbStreamData, uint* pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbStreamDataPtr = &pbStreamData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, ref byte pbStreamData, ref uint pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbStreamDataPtr = &pbStreamData)
        {
            fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbStreamData, uint* pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbStreamDataPtr = (byte*) SilkMarshal.StringToPtr(pbStreamData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActual);
        SilkMarshal.Free((nint)pbStreamDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbStreamData, ref uint pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbStreamDataPtr = (byte*) SilkMarshal.StringToPtr(pbStreamData, NativeStringEncoding.UTF8);
        fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActualPtr);
        }
        SilkMarshal.Free((nint)pbStreamDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICJpegFrameDecode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameDecode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportIndexing(this ComPtr<IWICJpegFrameDecode> thisVtbl, Span<int> pfIndexingSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportIndexing(ref pfIndexingSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegACHuffmanTable> pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAcHuffmanTable(scanIndex, tableIndex, ref pAcHuffmanTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDcHuffmanTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegDCHuffmanTable> pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDcHuffmanTable(scanIndex, tableIndex, ref pDcHuffmanTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetQuantizationTable(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegQuantizationTable> pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetQuantizationTable(scanIndex, tableIndex, ref pQuantizationTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, Span<JpegFrameHeader> pFrameHeader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameHeader(ref pFrameHeader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetScanHeader(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, Span<JpegScanHeader> pScanHeader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetScanHeader(scanIndex, ref pScanHeader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, Span<uint> pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyScan(scanIndex, scanOffset, cbScanData, pbScanData, ref pcbScanDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, Span<byte> pbScanData, uint* pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyScan(scanIndex, scanOffset, cbScanData, ref pbScanData.GetPinnableReference(), pcbScanDataActual);
    }

    /// <summary>To be documented.</summary>
    public static int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, Span<byte> pbScanData, Span<uint> pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyScan(scanIndex, scanOffset, cbScanData, ref pbScanData.GetPinnableReference(), ref pcbScanDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyScan(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint scanIndex, uint scanOffset, uint cbScanData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData, Span<uint> pcbScanDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyScan(scanIndex, scanOffset, cbScanData, pbScanData, ref pcbScanDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, byte* pbStreamData, Span<uint> pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyMinimalStream(streamOffset, cbStreamData, pbStreamData, ref pcbStreamDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, Span<byte> pbStreamData, uint* pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyMinimalStream(streamOffset, cbStreamData, ref pbStreamData.GetPinnableReference(), pcbStreamDataActual);
    }

    /// <summary>To be documented.</summary>
    public static int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, Span<byte> pbStreamData, Span<uint> pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyMinimalStream(streamOffset, cbStreamData, ref pbStreamData.GetPinnableReference(), ref pcbStreamDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyMinimalStream(this ComPtr<IWICJpegFrameDecode> thisVtbl, uint streamOffset, uint cbStreamData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbStreamData, Span<uint> pcbStreamDataActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyMinimalStream(streamOffset, cbStreamData, pbStreamData, ref pcbStreamDataActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICJpegFrameDecode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
