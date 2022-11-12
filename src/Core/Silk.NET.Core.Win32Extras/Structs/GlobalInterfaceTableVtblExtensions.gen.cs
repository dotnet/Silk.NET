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

public unsafe static class GlobalInterfaceTableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IGlobalInterfaceTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IGlobalInterfaceTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, ref Guid riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riidPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, ref Guid riid, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riidPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnk, Guid* riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riid, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnk, Guid* riid, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riid, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnk, ref Guid riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riidPtr, pdwCookie);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnk, ref Guid riid, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkPtr = &pUnk)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnkPtr, riidPtr, pdwCookiePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, int>)@this->LpVtbl[4])(@this, dwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, ComPtr<TI0> pUnk, Guid* riid, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, riid, pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(pUnk, riid, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, ComPtr<TI0> pUnk, Guid* riid, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, riid, ref pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Span<Guid> riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(pUnk, ref riid.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, ComPtr<TI0> pUnk, ref Guid riid, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, ref riid, pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Span<Guid> riid, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(pUnk, ref riid.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterInterfaceInGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, ComPtr<TI0> pUnk, ref Guid riid, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterInterfaceInGlobal((Silk.NET.Core.Native.IUnknown*) pUnk.Handle, ref riid, ref pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnk, Guid* riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(ref pUnk.GetPinnableReference(), riid, pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnk, Guid* riid, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(ref pUnk.GetPinnableReference(), riid, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnk, Span<Guid> riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(ref pUnk.GetPinnableReference(), ref riid.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnk, Span<Guid> riid, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterInterfaceInGlobal(ref pUnk.GetPinnableReference(), ref riid.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInterfaceFromGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetInterfaceFromGlobal(dwCookie, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInterfaceFromGlobal(dwCookie, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInterfaceFromGlobal(dwCookie, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetInterfaceFromGlobal<TI0>(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetInterfaceFromGlobal(dwCookie, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
