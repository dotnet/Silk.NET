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

public unsafe static class WICJpegFrameEncodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICJpegFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICJpegFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[3])(@this, scanIndex, tableIndex, pAcHuffmanTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegACHuffmanTable pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTablePtr = &pAcHuffmanTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[3])(@this, scanIndex, tableIndex, pAcHuffmanTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[4])(@this, scanIndex, tableIndex, pDcHuffmanTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegDCHuffmanTable pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTablePtr = &pDcHuffmanTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[4])(@this, scanIndex, tableIndex, pDcHuffmanTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetQuantizationTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[5])(@this, scanIndex, tableIndex, pQuantizationTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetQuantizationTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegQuantizationTable pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTablePtr = &pQuantizationTable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[5])(@this, scanIndex, tableIndex, pQuantizationTablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteScan(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbScanData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteScan(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbScanData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbScanDataPtr = &pbScanData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteScan(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanDataPtr);
        SilkMarshal.Free((nint)pbScanDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICJpegFrameEncode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICJpegFrameEncode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegACHuffmanTable> pAcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAcHuffmanTable(scanIndex, tableIndex, ref pAcHuffmanTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDcHuffmanTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegDCHuffmanTable> pDcHuffmanTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDcHuffmanTable(scanIndex, tableIndex, ref pDcHuffmanTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetQuantizationTable(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint scanIndex, uint tableIndex, Span<Silk.NET.DXGI.JpegQuantizationTable> pQuantizationTable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetQuantizationTable(scanIndex, tableIndex, ref pQuantizationTable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteScan(this ComPtr<IWICJpegFrameEncode> thisVtbl, uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbScanData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteScan(cbScanData, in pbScanData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICJpegFrameEncode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
