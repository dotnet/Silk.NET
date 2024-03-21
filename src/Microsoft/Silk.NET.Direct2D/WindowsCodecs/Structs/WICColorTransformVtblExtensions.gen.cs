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

public unsafe static class WICColorTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICColorTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICColorTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICColorTransform> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICColorTransform> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICColorTransform> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICColorTransform> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormat(this ComPtr<IWICColorTransform> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICColorTransform> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, double* pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, double* pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiYPtr = &pDpiY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, ref double pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, ref double pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPalette(this ComPtr<IWICColorTransform> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICColorTransform> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDestPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDestPtr, pixelFmtDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
        {
            fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSource, pIContextDestPtr, pixelFmtDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDest, pixelFmtDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
        {
            fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDest, pixelFmtDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
        {
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDestPtr, pixelFmtDest);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
        {
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSource, pIContextSourcePtr, pIContextDestPtr, pixelFmtDestPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDest, pixelFmtDest);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDest, pixelFmtDestPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDestPtr, pixelFmtDest);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, IWICColorContext* pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSource, pIContextDestPtr, pixelFmtDestPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDest, pixelFmtDest);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, IWICColorContext* pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDest, pixelFmtDestPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDestPtr, pixelFmtDest);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
        {
            fixed (IWICColorContext* pIContextSourcePtr = &pIContextSource)
            {
                fixed (IWICColorContext* pIContextDestPtr = &pIContextDest)
                {
                    fixed (Guid* pixelFmtDestPtr = &pixelFmtDest)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICColorTransform*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int>)@this->LpVtbl[8])(@this, pIBitmapSourcePtr, pIContextSourcePtr, pIContextDestPtr, pixelFmtDestPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICColorTransform> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorTransform> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICColorTransform> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICColorTransform> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICColorTransform> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICColorTransform> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, double* pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(pDpiX, ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, Span<double> pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), pDpiY);
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICColorTransform> thisVtbl, Span<double> pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICColorTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0, TI1, TI2>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ComPtr<TI2> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, pIContextSource, pIContextDest, ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1, TI2>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ComPtr<TI2> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, Span<IWICColorContext> pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, pIContextSource, ref pIContextDest.GetPinnableReference(), pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, Span<IWICColorContext> pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, pIContextSource, ref pIContextDest.GetPinnableReference(), ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ComPtr<TI1> pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, Span<IWICColorContext> pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, ref pIContextSource.GetPinnableReference(), pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI1> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, Span<IWICColorContext> pIContextSource, IWICColorContext* pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, ref pIContextSource.GetPinnableReference(), pIContextDest, ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI1> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, Span<IWICColorContext> pIContextSource, Span<IWICColorContext> pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, ref pIContextSource.GetPinnableReference(), ref pIContextDest.GetPinnableReference(), pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, ref pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, IWICBitmapSource* pIBitmapSource, Span<IWICColorContext> pIContextSource, Span<IWICColorContext> pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(pIBitmapSource, ref pIContextSource.GetPinnableReference(), ref pIContextDest.GetPinnableReference(), ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ComPtr<TI0> pIBitmapSource, ref IWICColorContext pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize((IWICBitmapSource*) pIBitmapSource.Handle, ref pIContextSource, ref pIContextDest, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), pIContextSource, pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ComPtr<TI1> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), pIContextSource, pIContextDest, ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0, TI1>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ComPtr<TI1> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, IWICColorContext* pIContextSource, Span<IWICColorContext> pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), pIContextSource, ref pIContextDest.GetPinnableReference(), pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ref IWICColorContext pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, IWICColorContext* pIContextSource, Span<IWICColorContext> pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), pIContextSource, ref pIContextDest.GetPinnableReference(), ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ComPtr<TI0> pIContextSource, ref IWICColorContext pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, (IWICColorContext*) pIContextSource.Handle, ref pIContextDest, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Span<IWICColorContext> pIContextSource, IWICColorContext* pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), ref pIContextSource.GetPinnableReference(), pIContextDest, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI0> pIContextDest, Guid* pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Span<IWICColorContext> pIContextSource, IWICColorContext* pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), ref pIContextSource.GetPinnableReference(), pIContextDest, ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Initialize<TI0>(this ComPtr<IWICColorTransform> thisVtbl, ref IWICBitmapSource pIBitmapSource, ref IWICColorContext pIContextSource, ComPtr<TI0> pIContextDest, ref Guid pixelFmtDest) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Initialize(ref pIBitmapSource, ref pIContextSource, (IWICColorContext*) pIContextDest.Handle, ref pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Span<IWICColorContext> pIContextSource, Span<IWICColorContext> pIContextDest, Guid* pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), ref pIContextSource.GetPinnableReference(), ref pIContextDest.GetPinnableReference(), pixelFmtDest);
    }

    /// <summary>To be documented.</summary>
    public static int Initialize(this ComPtr<IWICColorTransform> thisVtbl, Span<IWICBitmapSource> pIBitmapSource, Span<IWICColorContext> pIContextSource, Span<IWICColorContext> pIContextDest, Span<Guid> pixelFmtDest)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Initialize(ref pIBitmapSource.GetPinnableReference(), ref pIContextSource.GetPinnableReference(), ref pIContextDest.GetPinnableReference(), ref pixelFmtDest.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICColorTransform> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
