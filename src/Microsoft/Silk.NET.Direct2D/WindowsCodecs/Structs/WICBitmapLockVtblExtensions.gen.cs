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

public unsafe static class WICBitmapLockVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapLock> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapLock> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStride(this ComPtr<IWICBitmapLock> thisVtbl, uint* pcbStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, int>)@this->LpVtbl[4])(@this, pcbStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStride(this ComPtr<IWICBitmapLock> thisVtbl, ref uint pcbStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbStridePtr = &pcbStride)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, int>)@this->LpVtbl[4])(@this, pcbStridePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, uint* pcbBufferSize, byte** ppbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSize, ppbData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, uint* pcbBufferSize, ref byte* ppbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte** ppbDataPtr = &ppbData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSize, ppbDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, ref uint pcbBufferSize, byte** ppbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbBufferSizePtr = &pcbBufferSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSizePtr, ppbData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, ref uint pcbBufferSize, ref byte* ppbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbBufferSizePtr = &pcbBufferSize)
        {
            fixed (byte** ppbDataPtr = &ppbData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSizePtr, ppbDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormat(this ComPtr<IWICBitmapLock> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICBitmapLock> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapLock> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapLock> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICBitmapLock> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStride(this ComPtr<IWICBitmapLock> thisVtbl, Span<uint> pcbStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStride(ref pcbStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, uint* pcbBufferSize, string[] ppbDataSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppbData = (byte**) SilkMarshal.StringArrayToPtr(ppbDataSa);
        var ret = @this->GetDataPointer(pcbBufferSize, ppbData);
        SilkMarshal.CopyPtrToStringArray((nint) ppbData, ppbDataSa);
        SilkMarshal.Free((nint) ppbData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, ref uint pcbBufferSize, string[] ppbDataSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppbData = (byte**) SilkMarshal.StringArrayToPtr(ppbDataSa);
        var ret = @this->GetDataPointer(ref pcbBufferSize, ppbData);
        SilkMarshal.CopyPtrToStringArray((nint) ppbData, ppbDataSa);
        SilkMarshal.Free((nint) ppbData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, Span<uint> pcbBufferSize, byte** ppbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataPointer(ref pcbBufferSize.GetPinnableReference(), ppbData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataPointer(this ComPtr<IWICBitmapLock> thisVtbl, Span<uint> pcbBufferSize, ref byte* ppbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataPointer(ref pcbBufferSize.GetPinnableReference(), ref ppbData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICBitmapLock> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapLock> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
