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

public unsafe static class ConnectionPointVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IConnectionPoint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IConnectionPoint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConnectionInterface(this ComPtr<IConnectionPoint> thisVtbl, Guid* pIID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, int>)@this->LpVtbl[3])(@this, pIID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetConnectionInterface(this ComPtr<IConnectionPoint> thisVtbl, ref Guid pIID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pIIDPtr = &pIID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Guid*, int>)@this->LpVtbl[3])(@this, pIIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConnectionPointContainer(this ComPtr<IConnectionPoint> thisVtbl, IConnectionPointContainer** ppCPC)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IConnectionPointContainer**, int>)@this->LpVtbl[4])(@this, ppCPC);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConnectionPointContainer(this ComPtr<IConnectionPoint> thisVtbl, ref IConnectionPointContainer* ppCPC)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IConnectionPointContainer** ppCPCPtr = &ppCPC)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IConnectionPointContainer**, int>)@this->LpVtbl[4])(@this, ppCPCPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IConnectionPoint> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkSink, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSink, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IConnectionPoint> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkSink, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSink, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IConnectionPoint> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkSink, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkSinkPtr = &pUnkSink)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSinkPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Advise(this ComPtr<IConnectionPoint> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkSink, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkSinkPtr = &pUnkSink)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[5])(@this, pUnkSinkPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unadvise(this ComPtr<IConnectionPoint> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, uint, int>)@this->LpVtbl[6])(@this, dwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumConnections(this ComPtr<IConnectionPoint> thisVtbl, IEnumConnections** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IEnumConnections**, int>)@this->LpVtbl[7])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumConnections(this ComPtr<IConnectionPoint> thisVtbl, ref IEnumConnections* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumConnections** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPoint*, IEnumConnections**, int>)@this->LpVtbl[7])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IConnectionPoint> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPoint> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetConnectionInterface(this ComPtr<IConnectionPoint> thisVtbl, Span<Guid> pIID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConnectionInterface(ref pIID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetConnectionPointContainer<TI0>(this ComPtr<IConnectionPoint> thisVtbl, ref ComPtr<TI0> ppCPC) where TI0 : unmanaged, IComVtbl<IConnectionPointContainer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetConnectionPointContainer((IConnectionPointContainer**) ppCPC.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise<TI0>(this ComPtr<IConnectionPoint> thisVtbl, ComPtr<TI0> pUnkSink, uint* pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((Silk.NET.Core.Native.IUnknown*) pUnkSink.Handle, pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IConnectionPoint> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkSink, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(pUnkSink, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Advise<TI0>(this ComPtr<IConnectionPoint> thisVtbl, ComPtr<TI0> pUnkSink, ref uint pdwCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Advise((Silk.NET.Core.Native.IUnknown*) pUnkSink.Handle, ref pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Advise(this ComPtr<IConnectionPoint> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkSink, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pUnkSink.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int Advise(this ComPtr<IConnectionPoint> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkSink, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Advise(ref pUnkSink.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumConnections<TI0>(this ComPtr<IConnectionPoint> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnections>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumConnections((IEnumConnections**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IConnectionPoint> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
