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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class PerPropertyBrowsingVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPerPropertyBrowsing> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPerPropertyBrowsing> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayString(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, char** pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, char**, int>)@this->LpVtbl[3])(@this, dispID, pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayString(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, ref char* pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrPtr = &pBstr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, char**, int>)@this->LpVtbl[3])(@this, dispID, pBstrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapPropertyToPage(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, Guid* pClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, Guid*, int>)@this->LpVtbl[4])(@this, dispID, pClsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapPropertyToPage(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, ref Guid pClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, Guid*, int>)@this->LpVtbl[4])(@this, dispID, pClsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, CALPOLESTR* pCaStringsOut, CADWORD* pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOut, pCaCookiesOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, CALPOLESTR* pCaStringsOut, ref CADWORD pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CADWORD* pCaCookiesOutPtr = &pCaCookiesOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOut, pCaCookiesOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, ref CALPOLESTR pCaStringsOut, CADWORD* pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CALPOLESTR* pCaStringsOutPtr = &pCaStringsOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOutPtr, pCaCookiesOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, ref CALPOLESTR pCaStringsOut, ref CADWORD pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CALPOLESTR* pCaStringsOutPtr = &pCaStringsOut)
        {
            fixed (CADWORD* pCaCookiesOutPtr = &pCaCookiesOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, CALPOLESTR*, CADWORD*, int>)@this->LpVtbl[5])(@this, dispID, pCaStringsOutPtr, pCaCookiesOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedValue(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, uint dwCookie, Variant* pVarOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, uint, Variant*, int>)@this->LpVtbl[6])(@this, dispID, dwCookie, pVarOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPredefinedValue(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, uint dwCookie, ref Variant pVarOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarOutPtr = &pVarOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPerPropertyBrowsing*, int, uint, Variant*, int>)@this->LpVtbl[6])(@this, dispID, dwCookie, pVarOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPerPropertyBrowsing> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPerPropertyBrowsing> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayString(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, string[] pBstrSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
        var ret = @this->GetDisplayString(dispID, pBstr);
        SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
        SilkMarshal.Free((nint) pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapPropertyToPage(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, Span<Guid> pClsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapPropertyToPage(dispID, ref pClsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, CALPOLESTR* pCaStringsOut, Span<CADWORD> pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPredefinedStrings(dispID, pCaStringsOut, ref pCaCookiesOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, Span<CALPOLESTR> pCaStringsOut, CADWORD* pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPredefinedStrings(dispID, ref pCaStringsOut.GetPinnableReference(), pCaCookiesOut);
    }

    /// <summary>To be documented.</summary>
    public static int GetPredefinedStrings(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, Span<CALPOLESTR> pCaStringsOut, Span<CADWORD> pCaCookiesOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPredefinedStrings(dispID, ref pCaStringsOut.GetPinnableReference(), ref pCaCookiesOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPredefinedValue(this ComPtr<IPerPropertyBrowsing> thisVtbl, int dispID, uint dwCookie, Span<Variant> pVarOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPredefinedValue(dispID, dwCookie, ref pVarOut.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPerPropertyBrowsing> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
