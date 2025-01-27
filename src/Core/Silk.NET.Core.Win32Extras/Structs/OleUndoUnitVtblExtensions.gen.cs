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

public unsafe static class OleUndoUnitVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IOleUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IOleUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Do(this ComPtr<IOleUndoUnit> thisVtbl, IOleUndoManager* pUndoManager)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManager);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Do(this ComPtr<IOleUndoUnit> thisVtbl, ref IOleUndoManager pUndoManager)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoManager* pUndoManagerPtr = &pUndoManager)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManagerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IOleUndoUnit> thisVtbl, char** pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IOleUndoUnit> thisVtbl, ref char* pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrPtr = &pBstr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, Guid* pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, Guid* pClsid, ref int plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* plIDPtr = &plID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, ref Guid pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plID);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, ref Guid pClsid, ref int plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            fixed (int* plIDPtr = &plID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plIDPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OnNextAdd(this ComPtr<IOleUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoUnit*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IOleUndoUnit> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoUnit> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Do<TI0>(this ComPtr<IOleUndoUnit> thisVtbl, ComPtr<TI0> pUndoManager) where TI0 : unmanaged, IComVtbl<IOleUndoManager>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Do((IOleUndoManager*) pUndoManager.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Do(this ComPtr<IOleUndoUnit> thisVtbl, Span<IOleUndoManager> pUndoManager)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Do(ref pUndoManager.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDescription(this ComPtr<IOleUndoUnit> thisVtbl, string[] pBstrSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
        var ret = @this->GetDescription(pBstr);
        SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
        SilkMarshal.Free((nint) pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, Guid* pClsid, Span<int> plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(pClsid, ref plID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, Span<Guid> pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(ref pClsid.GetPinnableReference(), plID);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnitType(this ComPtr<IOleUndoUnit> thisVtbl, Span<Guid> pClsid, Span<int> plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(ref pClsid.GetPinnableReference(), ref plID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IOleUndoUnit> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
