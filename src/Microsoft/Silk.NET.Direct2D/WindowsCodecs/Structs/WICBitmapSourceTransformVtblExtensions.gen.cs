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

public unsafe static class WICBitmapSourceTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICBitmapSourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICBitmapSourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prc, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint uiWidth, uint uiHeight, ref Guid pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
            {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, Guid*, BitmapTransformOptions, uint, uint, byte*, int>)@this->LpVtbl[3])(@this, prcPtr, uiWidth, uiHeight, pguidDstFormatPtr, dstTransform, nStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, uint*, uint*, int>)@this->LpVtbl[4])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestPixelFormat(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Guid* pguidDstFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, int>)@this->LpVtbl[5])(@this, pguidDstFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClosestPixelFormat(this ComPtr<IWICBitmapSourceTransform> thisVtbl, ref Guid pguidDstFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, Guid*, int>)@this->LpVtbl[5])(@this, pguidDstFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportTransform(this ComPtr<IWICBitmapSourceTransform> thisVtbl, BitmapTransformOptions dstTransform, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, BitmapTransformOptions, int*, int>)@this->LpVtbl[6])(@this, dstTransform, pfIsSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportTransform(this ComPtr<IWICBitmapSourceTransform> thisVtbl, BitmapTransformOptions dstTransform, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIsSupportedPtr = &pfIsSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapSourceTransform*, BitmapTransformOptions, int*, int>)@this->LpVtbl[6])(@this, dstTransform, pfIsSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICBitmapSourceTransform> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Guid* pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICBitmapSourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint uiWidth, uint uiHeight, Span<Guid> pguidDstFormat, BitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), uiWidth, uiHeight, ref pguidDstFormat.GetPinnableReference(), dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClosestSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClosestSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetClosestSize(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClosestSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClosestPixelFormat(this ComPtr<IWICBitmapSourceTransform> thisVtbl, Span<Guid> pguidDstFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClosestPixelFormat(ref pguidDstFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportTransform(this ComPtr<IWICBitmapSourceTransform> thisVtbl, BitmapTransformOptions dstTransform, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportTransform(dstTransform, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICBitmapSourceTransform> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
