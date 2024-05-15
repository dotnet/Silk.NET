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

public unsafe static class EnumConnectionsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IEnumConnections> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IEnumConnections> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, ConnectData* rgcd, uint* pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint, ConnectData*, uint*, int>)@this->LpVtbl[3])(@this, cConnections, rgcd, pcFetched);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, ConnectData* rgcd, ref uint pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcFetchedPtr = &pcFetched)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint, ConnectData*, uint*, int>)@this->LpVtbl[3])(@this, cConnections, rgcd, pcFetchedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, ref ConnectData rgcd, uint* pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ConnectData* rgcdPtr = &rgcd)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint, ConnectData*, uint*, int>)@this->LpVtbl[3])(@this, cConnections, rgcdPtr, pcFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, ref ConnectData rgcd, ref uint pcFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ConnectData* rgcdPtr = &rgcd)
        {
            fixed (uint* pcFetchedPtr = &pcFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint, ConnectData*, uint*, int>)@this->LpVtbl[3])(@this, cConnections, rgcdPtr, pcFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Skip(this ComPtr<IEnumConnections> thisVtbl, uint cConnections)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, uint, int>)@this->LpVtbl[4])(@this, cConnections);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IEnumConnections> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumConnections> thisVtbl, IEnumConnections** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, IEnumConnections**, int>)@this->LpVtbl[6])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumConnections> thisVtbl, ref IEnumConnections* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumConnections** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumConnections*, IEnumConnections**, int>)@this->LpVtbl[6])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IEnumConnections> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumConnections> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, ConnectData* rgcd, Span<uint> pcFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cConnections, rgcd, ref pcFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, Span<ConnectData> rgcd, uint* pcFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cConnections, ref rgcd.GetPinnableReference(), pcFetched);
    }

    /// <summary>To be documented.</summary>
    public static int Next(this ComPtr<IEnumConnections> thisVtbl, uint cConnections, Span<ConnectData> rgcd, Span<uint> pcFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cConnections, ref rgcd.GetPinnableReference(), ref pcFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IEnumConnections> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumConnections>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((IEnumConnections**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IEnumConnections> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
