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

public unsafe static class EnumOleUndoUnitsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IEnumOleUndoUnits> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IEnumOleUndoUnits> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, IOleUndoUnit** rgElt, uint* pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgElt, pcEltFetched);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, IOleUndoUnit** rgElt, ref uint pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcEltFetchedPtr = &pcEltFetched)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgElt, pcEltFetchedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, ref IOleUndoUnit* rgElt, uint* pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit** rgEltPtr = &rgElt)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgEltPtr, pcEltFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, ref IOleUndoUnit* rgElt, ref uint pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit** rgEltPtr = &rgElt)
        {
            fixed (uint* pcEltFetchedPtr = &pcEltFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)@this->LpVtbl[3])(@this, cElt, rgEltPtr, pcEltFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Skip(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, uint, int>)@this->LpVtbl[4])(@this, cElt);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IEnumOleUndoUnits> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumOleUndoUnits> thisVtbl, IEnumOleUndoUnits** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)@this->LpVtbl[6])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumOleUndoUnits> thisVtbl, ref IEnumOleUndoUnits* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)@this->LpVtbl[6])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IEnumOleUndoUnits> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumOleUndoUnits> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next<TI0>(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, ref ComPtr<TI0> rgElt, uint* pcEltFetched) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Next(cElt, (IOleUndoUnit**) rgElt.GetAddressOf(), pcEltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, IOleUndoUnit** rgElt, Span<uint> pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cElt, rgElt, ref pcEltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Next<TI0>(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, ref ComPtr<TI0> rgElt, ref uint pcEltFetched) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Next(cElt, (IOleUndoUnit**) rgElt.GetAddressOf(), ref pcEltFetched);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumOleUndoUnits> thisVtbl, uint cElt, ref IOleUndoUnit* rgElt, Span<uint> pcEltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(cElt, ref rgElt, ref pcEltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IEnumOleUndoUnits> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IEnumOleUndoUnits> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
