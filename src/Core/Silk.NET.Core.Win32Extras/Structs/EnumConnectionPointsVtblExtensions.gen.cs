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

public unsafe static class EnumConnectionPointsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IEnumConnectionPoints> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IEnumConnectionPoints> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, IConnectionPoint** ppCP, uint* pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCP, pcFetched);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, IConnectionPoint** ppCP, ref uint pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcFetchedPtr = &pcFetched)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCP, pcFetchedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, ref IConnectionPoint* ppCP, uint* pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IConnectionPoint** ppCPPtr = &ppCP)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCPPtr, pcFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, ref IConnectionPoint* ppCP, ref uint pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IConnectionPoint** ppCPPtr = &ppCP)
        {
            fixed (uint* pcFetchedPtr = &pcFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)@this->LpVtbl[3])(@this, cConnections, ppCPPtr, pcFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Skip(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, uint, int>)@this->LpVtbl[4])(@this, cConnections);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IEnumConnectionPoints> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumConnectionPoints> thisVtbl, IEnumConnectionPoints** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)@this->LpVtbl[6])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumConnectionPoints> thisVtbl, ref IEnumConnectionPoints* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumConnectionPoints** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)@this->LpVtbl[6])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IEnumConnectionPoints> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnectionPoints> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<TI0>(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, ref ComPtr<TI0> ppCP, uint* pcFetched) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Next(cConnections, (IConnectionPoint**) ppCP.GetAddressOf(), pcFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, IConnectionPoint** ppCP, Span<uint> pcFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cConnections, ppCP, ref pcFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Next<TI0>(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, ref ComPtr<TI0> ppCP, ref uint pcFetched) where TI0 : unmanaged, IComVtbl<IConnectionPoint>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Next(cConnections, (IConnectionPoint**) ppCP.GetAddressOf(), ref pcFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnectionPoints> thisVtbl, uint cConnections, ref IConnectionPoint* ppCP, Span<uint> pcFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cConnections, ref ppCP, ref pcFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IEnumConnectionPoints> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnectionPoints>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((IEnumConnectionPoints**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IEnumConnectionPoints> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
