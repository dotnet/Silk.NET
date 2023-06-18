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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11VideoProcessorEnumerator1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorContentDesc(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, VideoProcessorContentDesc* pContentDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorContentDesc*, int>)@this->LpVtbl[7])(@this, pContentDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoProcessorFormat(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format Format, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[8])(@this, Format, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, VideoProcessorCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorCaps*, int>)@this->LpVtbl[9])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorRateConversionCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, VideoProcessorRateConversionCaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, VideoProcessorRateConversionCaps*, int>)@this->LpVtbl[10])(@this, TypeIndex, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorCustomRate(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, uint, VideoProcessorCustomRate*, int>)@this->LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoProcessorFilterRange(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)@this->LpVtbl[12])(@this, Filter, pRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckVideoProcessorFormatConversion(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format InputFormat, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Silk.NET.DXGI.Format OutputFormat, Silk.NET.DXGI.ColorSpaceType OutputColorSpace, int* pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, int*, int>)@this->LpVtbl[13])(@this, InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
        return ret;
    }

}
