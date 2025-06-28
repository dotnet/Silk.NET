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

public unsafe static class MFHDCPStatusVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFHDCPStatus> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFHDCPStatus> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IMFHDCPStatus> thisVtbl, HdcpStatus* pStatus, int* pfStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatus, pfStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IMFHDCPStatus> thisVtbl, HdcpStatus* pStatus, ref int pfStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfStatusPtr = &pfStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatus, pfStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IMFHDCPStatus> thisVtbl, ref HdcpStatus pStatus, int* pfStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HdcpStatus* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr, pfStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Query(this ComPtr<IMFHDCPStatus> thisVtbl, ref HdcpStatus pStatus, ref int pfStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HdcpStatus* pStatusPtr = &pStatus)
        {
            fixed (int* pfStatusPtr = &pfStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr, pfStatusPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Set(this ComPtr<IMFHDCPStatus> thisVtbl, HdcpStatus status)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFHDCPStatus*, HdcpStatus, int>)@this->LpVtbl[4])(@this, status);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFHDCPStatus> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFHDCPStatus> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IMFHDCPStatus> thisVtbl, HdcpStatus* pStatus, Span<int> pfStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(pStatus, ref pfStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IMFHDCPStatus> thisVtbl, Span<HdcpStatus> pStatus, int* pfStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(ref pStatus.GetPinnableReference(), pfStatus);
    }

    /// <summary>To be documented.</summary>
    public static int Query(this ComPtr<IMFHDCPStatus> thisVtbl, Span<HdcpStatus> pStatus, Span<int> pfStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Query(ref pStatus.GetPinnableReference(), ref pfStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFHDCPStatus> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
