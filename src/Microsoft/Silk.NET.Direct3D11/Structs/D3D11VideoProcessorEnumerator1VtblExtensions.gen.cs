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
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe void GetDevice(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref ID3D11Device* ppDevice)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Device** ppDevicePtr = &ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
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
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
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
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
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
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
            }
        }
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
    public static int GetVideoProcessorContentDesc(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref VideoProcessorContentDesc pContentDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorContentDesc* pContentDescPtr = &pContentDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorContentDesc*, int>)@this->LpVtbl[7])(@this, pContentDescPtr);
        }
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
    public static int CheckVideoProcessorFormat(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format Format, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[8])(@this, Format, pFlagsPtr);
        }
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
    public static int GetVideoProcessorCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref VideoProcessorCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorCaps*, int>)@this->LpVtbl[9])(@this, pCapsPtr);
        }
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
    public static int GetVideoProcessorRateConversionCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, ref VideoProcessorRateConversionCaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorRateConversionCaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, VideoProcessorRateConversionCaps*, int>)@this->LpVtbl[10])(@this, TypeIndex, pCapsPtr);
        }
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
    public static int GetVideoProcessorCustomRate(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, uint CustomRateIndex, ref VideoProcessorCustomRate pRate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorCustomRate* pRatePtr = &pRate)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, uint, VideoProcessorCustomRate*, int>)@this->LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRatePtr);
        }
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
    public static int GetVideoProcessorFilterRange(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, VideoProcessorFilter Filter, ref VideoProcessorFilterRange pRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessorFilterRange* pRangePtr = &pRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)@this->LpVtbl[12])(@this, Filter, pRangePtr);
        }
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

    /// <summary>To be documented.</summary>
    public static int CheckVideoProcessorFormatConversion(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format InputFormat, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Silk.NET.DXGI.Format OutputFormat, Silk.NET.DXGI.ColorSpaceType OutputColorSpace, ref int pSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pSupportedPtr = &pSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, int*, int>)@this->LpVtbl[13])(@this, InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetDevice<TI0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorContentDesc(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<VideoProcessorContentDesc> pContentDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessorContentDesc(ref pContentDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoProcessorFormat(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format Format, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoProcessorFormat(Format, ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Span<VideoProcessorCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessorCaps(ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorRateConversionCaps(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, Span<VideoProcessorRateConversionCaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessorRateConversionCaps(TypeIndex, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorCustomRate(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, uint TypeIndex, uint CustomRateIndex, Span<VideoProcessorCustomRate> pRate)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessorCustomRate(TypeIndex, CustomRateIndex, ref pRate.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoProcessorFilterRange(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, VideoProcessorFilter Filter, Span<VideoProcessorFilterRange> pRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoProcessorFilterRange(Filter, ref pRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckVideoProcessorFormatConversion(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl, Silk.NET.DXGI.Format InputFormat, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Silk.NET.DXGI.Format OutputFormat, Silk.NET.DXGI.ColorSpaceType OutputColorSpace, Span<int> pSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckVideoProcessorFormatConversion(InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, ref pSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11VideoProcessorEnumerator1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
