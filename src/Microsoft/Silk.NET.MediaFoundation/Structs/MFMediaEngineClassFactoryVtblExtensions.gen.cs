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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaEngineClassFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineClassFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineClassFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAttributes* pAttrPtr = &pAttr)
        {
            fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTimeRange(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, IMFMediaTimeRange** ppTimeRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTimeRange(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref IMFMediaTimeRange* ppTimeRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppTimeRangePtr = &ppTimeRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateError(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, IMFMediaError** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateError(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref IMFMediaError* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaError** ppErrorPtr = &ppError)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance(dwFlags, pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, IMFMediaEngine** ppPlayer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(dwFlags, ref pAttr.GetPinnableReference(), ppPlayer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInstance(dwFlags, ref pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, uint dwFlags, Span<IMFAttributes> pAttr, ref IMFMediaEngine* ppPlayer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInstance(dwFlags, ref pAttr.GetPinnableReference(), ref ppPlayer);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTimeRange<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref ComPtr<TI0> ppTimeRange) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTimeRange((IMFMediaTimeRange**) ppTimeRange.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateError<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateError((IMFMediaError**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
