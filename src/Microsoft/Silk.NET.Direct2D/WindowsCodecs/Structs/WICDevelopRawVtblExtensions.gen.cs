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

public unsafe static class WICDevelopRawVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICDevelopRaw> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICDevelopRaw> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, uint* puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, uint* puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiHeightPtr = &puiHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint puiWidth, ref uint puiHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puiWidthPtr = &puiWidth)
        {
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelFormat(this ComPtr<IWICDevelopRaw> thisVtbl, Guid* pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICDevelopRaw> thisVtbl, ref Guid pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pPixelFormatPtr = &pPixelFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Guid*, int>)@this->LpVtbl[4])(@this, pPixelFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, double* pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, double* pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiYPtr = &pDpiY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiX, pDpiYPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pDpiX, ref double pDpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pDpiXPtr = &pDpiX)
        {
            fixed (double* pDpiYPtr = &pDpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, double*, int>)@this->LpVtbl[5])(@this, pDpiXPtr, pDpiYPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPalette(this ComPtr<IWICDevelopRaw> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICDevelopRaw> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prc, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcPtr = &prc)
        {
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[7])(@this, prcPtr, cbStride, cbBufferSize, pbBufferPtr);
        SilkMarshal.Free((nint)pbBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICDevelopRaw> thisVtbl, IWICMetadataQueryReader** ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataQueryReader(this ComPtr<IWICDevelopRaw> thisVtbl, ref IWICMetadataQueryReader* ppIMetadataQueryReader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataQueryReader** ppIMetadataQueryReaderPtr = &ppIMetadataQueryReader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)@this->LpVtbl[8])(@this, ppIMetadataQueryReaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcActualCountPtr = &pcActualCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContexts, pcActualCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, uint* pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, ref uint pcActualCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext** ppIColorContextsPtr = &ppIColorContexts)
        {
            fixed (uint* pcActualCountPtr = &pcActualCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)@this->LpVtbl[9])(@this, cCount, ppIColorContextsPtr, pcActualCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICDevelopRaw> thisVtbl, IWICBitmapSource** ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetThumbnail(this ComPtr<IWICDevelopRaw> thisVtbl, ref IWICBitmapSource* ppIThumbnail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppIThumbnailPtr = &ppIThumbnail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICBitmapSource**, int>)@this->LpVtbl[10])(@this, ppIThumbnailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryRawCapabilitiesInfo(this ComPtr<IWICDevelopRaw> thisVtbl, RawCapabilitiesInfo* pInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawCapabilitiesInfo*, int>)@this->LpVtbl[11])(@this, pInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryRawCapabilitiesInfo(this ComPtr<IWICDevelopRaw> thisVtbl, ref RawCapabilitiesInfo pInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RawCapabilitiesInfo* pInfoPtr = &pInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawCapabilitiesInfo*, int>)@this->LpVtbl[11])(@this, pInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadParameterSet(this ComPtr<IWICDevelopRaw> thisVtbl, RawParameterSet ParameterSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawParameterSet, int>)@this->LpVtbl[12])(@this, ParameterSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentParameterSet(this ComPtr<IWICDevelopRaw> thisVtbl, Silk.NET.Core.Win32Extras.IPropertyBag2** ppCurrentParameterSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[13])(@this, ppCurrentParameterSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentParameterSet(this ComPtr<IWICDevelopRaw> thisVtbl, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppCurrentParameterSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppCurrentParameterSetPtr = &ppCurrentParameterSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[13])(@this, ppCurrentParameterSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetExposureCompensation(this ComPtr<IWICDevelopRaw> thisVtbl, double ev)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[14])(@this, ev);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExposureCompensation(this ComPtr<IWICDevelopRaw> thisVtbl, double* pEV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[15])(@this, pEV);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetExposureCompensation(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pEV)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pEVPtr = &pEV)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[15])(@this, pEVPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint Red, uint Green, uint Blue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, uint, uint, int>)@this->LpVtbl[16])(@this, Red, Green, Blue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, uint* pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreen, pBlue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, uint* pGreen, ref uint pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pBluePtr = &pBlue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreen, pBluePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, ref uint pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pGreenPtr = &pGreen)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreenPtr, pBlue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, ref uint pGreen, ref uint pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pGreenPtr = &pGreen)
        {
            fixed (uint* pBluePtr = &pBlue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRed, pGreenPtr, pBluePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pRed, uint* pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRedPtr = &pRed)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreen, pBlue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pRed, uint* pGreen, ref uint pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRedPtr = &pRed)
        {
            fixed (uint* pBluePtr = &pBlue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreen, pBluePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pRed, ref uint pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRedPtr = &pRed)
        {
            fixed (uint* pGreenPtr = &pGreen)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreenPtr, pBlue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pRed, ref uint pGreen, ref uint pBlue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRedPtr = &pRed)
        {
            fixed (uint* pGreenPtr = &pGreen)
            {
                fixed (uint* pBluePtr = &pBlue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[17])(@this, pRedPtr, pGreenPtr, pBluePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNamedWhitePoint(this ComPtr<IWICDevelopRaw> thisVtbl, NamedWhitePoint WhitePoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint, int>)@this->LpVtbl[18])(@this, WhitePoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNamedWhitePoint(this ComPtr<IWICDevelopRaw> thisVtbl, NamedWhitePoint* pWhitePoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint*, int>)@this->LpVtbl[19])(@this, pWhitePoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNamedWhitePoint(this ComPtr<IWICDevelopRaw> thisVtbl, ref NamedWhitePoint pWhitePoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (NamedWhitePoint* pWhitePointPtr = &pWhitePoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, NamedWhitePoint*, int>)@this->LpVtbl[19])(@this, pWhitePointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWhitePointKelvin(this ComPtr<IWICDevelopRaw> thisVtbl, uint WhitePointKelvin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, int>)@this->LpVtbl[20])(@this, WhitePointKelvin);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointKelvin(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pWhitePointKelvin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, int>)@this->LpVtbl[21])(@this, pWhitePointKelvin);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWhitePointKelvin(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pWhitePointKelvin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pWhitePointKelvinPtr = &pWhitePointKelvin)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, int>)@this->LpVtbl[21])(@this, pWhitePointKelvinPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, uint* pMaxKelvinTemp, ref uint pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, ref uint pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTempPtr, pKelvinTempStepValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, ref uint pMaxKelvinTemp, ref uint pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
        {
            fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTemp, pMaxKelvinTempPtr, pKelvinTempStepValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTemp, pKelvinTempStepValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pMinKelvinTemp, uint* pMaxKelvinTemp, ref uint pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
        {
            fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTemp, pKelvinTempStepValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pMinKelvinTemp, ref uint pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
        {
            fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTempPtr, pKelvinTempStepValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, ref uint pMinKelvinTemp, ref uint pMaxKelvinTemp, ref uint pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMinKelvinTempPtr = &pMinKelvinTemp)
        {
            fixed (uint* pMaxKelvinTempPtr = &pMaxKelvinTemp)
            {
                fixed (uint* pKelvinTempStepValuePtr = &pKelvinTempStepValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint*, uint*, uint*, int>)@this->LpVtbl[22])(@this, pMinKelvinTempPtr, pMaxKelvinTempPtr, pKelvinTempStepValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetContrast(this ComPtr<IWICDevelopRaw> thisVtbl, double Contrast)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[23])(@this, Contrast);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContrast(this ComPtr<IWICDevelopRaw> thisVtbl, double* pContrast)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[24])(@this, pContrast);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContrast(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pContrast)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pContrastPtr = &pContrast)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[24])(@this, pContrastPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGamma(this ComPtr<IWICDevelopRaw> thisVtbl, double Gamma)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[25])(@this, Gamma);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGamma(this ComPtr<IWICDevelopRaw> thisVtbl, double* pGamma)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[26])(@this, pGamma);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGamma(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pGamma)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pGammaPtr = &pGamma)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[26])(@this, pGammaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSharpness(this ComPtr<IWICDevelopRaw> thisVtbl, double Sharpness)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[27])(@this, Sharpness);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharpness(this ComPtr<IWICDevelopRaw> thisVtbl, double* pSharpness)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[28])(@this, pSharpness);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSharpness(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pSharpness)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pSharpnessPtr = &pSharpness)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[28])(@this, pSharpnessPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSaturation(this ComPtr<IWICDevelopRaw> thisVtbl, double Saturation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[29])(@this, Saturation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSaturation(this ComPtr<IWICDevelopRaw> thisVtbl, double* pSaturation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[30])(@this, pSaturation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSaturation(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pSaturation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pSaturationPtr = &pSaturation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[30])(@this, pSaturationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTint(this ComPtr<IWICDevelopRaw> thisVtbl, double Tint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[31])(@this, Tint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTint(this ComPtr<IWICDevelopRaw> thisVtbl, double* pTint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[32])(@this, pTint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTint(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pTint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pTintPtr = &pTint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[32])(@this, pTintPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNoiseReduction(this ComPtr<IWICDevelopRaw> thisVtbl, double NoiseReduction)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[33])(@this, NoiseReduction);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNoiseReduction(this ComPtr<IWICDevelopRaw> thisVtbl, double* pNoiseReduction)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[34])(@this, pNoiseReduction);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNoiseReduction(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pNoiseReduction)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pNoiseReductionPtr = &pNoiseReduction)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[34])(@this, pNoiseReductionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDestinationColorContext(this ComPtr<IWICDevelopRaw> thisVtbl, IWICColorContext* pColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICColorContext*, int>)@this->LpVtbl[35])(@this, pColorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDestinationColorContext(this ComPtr<IWICDevelopRaw> thisVtbl, ref IWICColorContext pColorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICColorContext* pColorContextPtr = &pColorContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICColorContext*, int>)@this->LpVtbl[35])(@this, pColorContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RawToneCurve* pToneCurve)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, int>)@this->LpVtbl[36])(@this, cbToneCurveSize, pToneCurve);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RawToneCurve pToneCurve)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, int>)@this->LpVtbl[36])(@this, cbToneCurveSize, pToneCurvePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, ref uint pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbActualToneCurveBufferSizePtr = &pcbActualToneCurveBufferSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, uint* pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurvePtr, pcbActualToneCurveBufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, ref RawToneCurve pToneCurve, ref uint pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RawToneCurve* pToneCurvePtr = &pToneCurve)
        {
            fixed (uint* pcbActualToneCurveBufferSizePtr = &pcbActualToneCurveBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, uint, RawToneCurve*, uint*, int>)@this->LpVtbl[37])(@this, cbToneCurveBufferSize, pToneCurvePtr, pcbActualToneCurveBufferSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRotation(this ComPtr<IWICDevelopRaw> thisVtbl, double Rotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double, int>)@this->LpVtbl[38])(@this, Rotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRotation(this ComPtr<IWICDevelopRaw> thisVtbl, double* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[39])(@this, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation(this ComPtr<IWICDevelopRaw> thisVtbl, ref double pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, double*, int>)@this->LpVtbl[39])(@this, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderMode(this ComPtr<IWICDevelopRaw> thisVtbl, RawRenderMode RenderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode, int>)@this->LpVtbl[40])(@this, RenderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderMode(this ComPtr<IWICDevelopRaw> thisVtbl, RawRenderMode* pRenderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode*, int>)@this->LpVtbl[41])(@this, pRenderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderMode(this ComPtr<IWICDevelopRaw> thisVtbl, ref RawRenderMode pRenderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RawRenderMode* pRenderModePtr = &pRenderMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, RawRenderMode*, int>)@this->LpVtbl[41])(@this, pRenderModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetNotificationCallback(this ComPtr<IWICDevelopRaw> thisVtbl, IWICDevelopRawNotificationCallback* pCallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)@this->LpVtbl[42])(@this, pCallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNotificationCallback(this ComPtr<IWICDevelopRaw> thisVtbl, ref IWICDevelopRawNotificationCallback pCallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICDevelopRawNotificationCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)@this->LpVtbl[42])(@this, pCallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDevelopRaw> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, uint* puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(puiWidth, ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> puiWidth, uint* puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), puiHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> puiWidth, Span<uint> puiHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref puiWidth.GetPinnableReference(), ref puiHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelFormat(this ComPtr<IWICDevelopRaw> thisVtbl, Span<Guid> pPixelFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelFormat(ref pPixelFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, double* pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(pDpiX, ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pDpiX, double* pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), pDpiY);
    }

    /// <summary>To be documented.</summary>
    public static int GetResolution(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pDpiX, Span<double> pDpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResolution(ref pDpiX.GetPinnableReference(), ref pDpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPalette(this ComPtr<IWICDevelopRaw> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(prc, cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, Span<byte> pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, ref pbBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyPixels(this ComPtr<IWICDevelopRaw> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> prc, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyPixels(in prc.GetPinnableReference(), cbStride, cbBufferSize, pbBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataQueryReader<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, ref ComPtr<TI0> ppIMetadataQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataQueryReader((IWICMetadataQueryReader**) ppIMetadataQueryReader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, uint* pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, IWICColorContext** ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorContexts<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, ref ComPtr<TI0> ppIColorContexts, ref uint pcActualCount) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetColorContexts(cCount, (IWICColorContext**) ppIColorContexts.GetAddressOf(), ref pcActualCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorContexts(this ComPtr<IWICDevelopRaw> thisVtbl, uint cCount, ref IWICColorContext* ppIColorContexts, Span<uint> pcActualCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorContexts(cCount, ref ppIColorContexts, ref pcActualCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetThumbnail<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, ref ComPtr<TI0> ppIThumbnail) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetThumbnail((IWICBitmapSource**) ppIThumbnail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int QueryRawCapabilitiesInfo(this ComPtr<IWICDevelopRaw> thisVtbl, Span<RawCapabilitiesInfo> pInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryRawCapabilitiesInfo(ref pInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetExposureCompensation(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pEV)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExposureCompensation(ref pEV.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, uint* pGreen, Span<uint> pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(pRed, pGreen, ref pBlue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, Span<uint> pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(pRed, ref pGreen.GetPinnableReference(), pBlue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pRed, Span<uint> pGreen, Span<uint> pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(pRed, ref pGreen.GetPinnableReference(), ref pBlue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pRed, uint* pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(ref pRed.GetPinnableReference(), pGreen, pBlue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pRed, uint* pGreen, Span<uint> pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(ref pRed.GetPinnableReference(), pGreen, ref pBlue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pRed, Span<uint> pGreen, uint* pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(ref pRed.GetPinnableReference(), ref pGreen.GetPinnableReference(), pBlue);
    }

    /// <summary>To be documented.</summary>
    public static int GetWhitePointRGB(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pRed, Span<uint> pGreen, Span<uint> pBlue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointRGB(ref pRed.GetPinnableReference(), ref pGreen.GetPinnableReference(), ref pBlue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetNamedWhitePoint(this ComPtr<IWICDevelopRaw> thisVtbl, Span<NamedWhitePoint> pWhitePoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNamedWhitePoint(ref pWhitePoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWhitePointKelvin(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pWhitePointKelvin)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWhitePointKelvin(ref pWhitePointKelvin.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, uint* pMaxKelvinTemp, Span<uint> pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(pMinKelvinTemp, pMaxKelvinTemp, ref pKelvinTempStepValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, Span<uint> pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(pMinKelvinTemp, ref pMaxKelvinTemp.GetPinnableReference(), pKelvinTempStepValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, uint* pMinKelvinTemp, Span<uint> pMaxKelvinTemp, Span<uint> pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(pMinKelvinTemp, ref pMaxKelvinTemp.GetPinnableReference(), ref pKelvinTempStepValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(ref pMinKelvinTemp.GetPinnableReference(), pMaxKelvinTemp, pKelvinTempStepValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pMinKelvinTemp, uint* pMaxKelvinTemp, Span<uint> pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(ref pMinKelvinTemp.GetPinnableReference(), pMaxKelvinTemp, ref pKelvinTempStepValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pMinKelvinTemp, Span<uint> pMaxKelvinTemp, uint* pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(ref pMinKelvinTemp.GetPinnableReference(), ref pMaxKelvinTemp.GetPinnableReference(), pKelvinTempStepValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetKelvinRangeInfo(this ComPtr<IWICDevelopRaw> thisVtbl, Span<uint> pMinKelvinTemp, Span<uint> pMaxKelvinTemp, Span<uint> pKelvinTempStepValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKelvinRangeInfo(ref pMinKelvinTemp.GetPinnableReference(), ref pMaxKelvinTemp.GetPinnableReference(), ref pKelvinTempStepValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContrast(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pContrast)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContrast(ref pContrast.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGamma(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pGamma)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGamma(ref pGamma.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSharpness(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pSharpness)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSharpness(ref pSharpness.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSaturation(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pSaturation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSaturation(ref pSaturation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTint(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pTint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTint(ref pTint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetNoiseReduction(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pNoiseReduction)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNoiseReduction(ref pNoiseReduction.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetDestinationColorContext<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, ComPtr<TI0> pColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetDestinationColorContext((IWICColorContext*) pColorContext.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetDestinationColorContext(this ComPtr<IWICDevelopRaw> thisVtbl, Span<IWICColorContext> pColorContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDestinationColorContext(ref pColorContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RawToneCurve> pToneCurve)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetToneCurve(cbToneCurveSize, in pToneCurve.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, RawToneCurve* pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetToneCurve(cbToneCurveBufferSize, pToneCurve, ref pcbActualToneCurveBufferSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, uint* pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetToneCurve(cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), pcbActualToneCurveBufferSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetToneCurve(this ComPtr<IWICDevelopRaw> thisVtbl, uint cbToneCurveBufferSize, Span<RawToneCurve> pToneCurve, Span<uint> pcbActualToneCurveBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetToneCurve(cbToneCurveBufferSize, ref pToneCurve.GetPinnableReference(), ref pcbActualToneCurveBufferSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation(this ComPtr<IWICDevelopRaw> thisVtbl, Span<double> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRotation(ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderMode(this ComPtr<IWICDevelopRaw> thisVtbl, Span<RawRenderMode> pRenderMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRenderMode(ref pRenderMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetNotificationCallback<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl, ComPtr<TI0> pCallback) where TI0 : unmanaged, IComVtbl<IWICDevelopRawNotificationCallback>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetNotificationCallback((IWICDevelopRawNotificationCallback*) pCallback.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetNotificationCallback(this ComPtr<IWICDevelopRaw> thisVtbl, Span<IWICDevelopRawNotificationCallback> pCallback)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetNotificationCallback(ref pCallback.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICDevelopRaw> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
