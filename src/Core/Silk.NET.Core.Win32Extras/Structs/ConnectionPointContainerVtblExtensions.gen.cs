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

public unsafe static class ConnectionPointContainerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IConnectionPointContainer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IConnectionPointContainer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumConnectionPoints(this ComPtr<IConnectionPointContainer> thisVtbl, IEnumConnectionPoints** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, IEnumConnectionPoints**, int>)@this->LpVtbl[3])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumConnectionPoints(this ComPtr<IConnectionPointContainer> thisVtbl, ref IEnumConnectionPoints* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumConnectionPoints** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, IEnumConnectionPoints**, int>)@this->LpVtbl[3])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, Guid* riid, IConnectionPoint** ppCP)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riid, ppCP);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, Guid* riid, ref IConnectionPoint* ppCP)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IConnectionPoint** ppCPPtr = &ppCP)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riid, ppCPPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, ref Guid riid, IConnectionPoint** ppCP)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riidPtr, ppCP);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, ref Guid riid, ref IConnectionPoint* ppCP)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (IConnectionPoint** ppCPPtr = &ppCP)
            {
                ret = ((delegate* unmanaged[Cdecl]<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)@this->LpVtbl[4])(@this, riidPtr, ppCPPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IConnectionPointContainer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int EnumConnectionPoints<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnectionPoints>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumConnectionPoints((IEnumConnectionPoints**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int FindConnectionPoint<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl, out ComPtr<TI0> ppCP) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCP = default;
        return @this->FindConnectionPoint(SilkMarshal.GuidPtrOf<TI0>(), (IConnectionPoint**) ppCP.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, Span<Guid> riid, IConnectionPoint** ppCP)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindConnectionPoint(ref riid.GetPinnableReference(), ppCP);
    }

    /// <summary>To be documented.</summary>
    public static int FindConnectionPoint<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl, ref Guid riid, ref ComPtr<TI0> ppCP) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindConnectionPoint(ref riid, (IConnectionPoint**) ppCP.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindConnectionPoint(this ComPtr<IConnectionPointContainer> thisVtbl, Span<Guid> riid, ref IConnectionPoint* ppCP)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindConnectionPoint(ref riid.GetPinnableReference(), ref ppCP);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> FindConnectionPoint<TI0>(this ComPtr<IConnectionPointContainer> thisVtbl) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->FindConnectionPoint(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
