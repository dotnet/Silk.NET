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

public unsafe static class OleParentUndoUnitVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IOleParentUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IOleParentUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Do(this ComPtr<IOleParentUndoUnit> thisVtbl, IOleUndoManager* pUndoManager)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManager);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Do(this ComPtr<IOleParentUndoUnit> thisVtbl, ref IOleUndoManager pUndoManager)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoManager* pUndoManagerPtr = &pUndoManager)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoManager*, int>)@this->LpVtbl[3])(@this, pUndoManagerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IOleParentUndoUnit> thisVtbl, char** pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription(this ComPtr<IOleParentUndoUnit> thisVtbl, ref char* pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrPtr = &pBstr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, char**, int>)@this->LpVtbl[4])(@this, pBstrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, Guid* pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, Guid* pClsid, ref int plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* plIDPtr = &plID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsid, plIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, ref Guid pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plID);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, ref Guid pClsid, ref int plID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClsidPtr = &pClsid)
        {
            fixed (int* plIDPtr = &plID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, Guid*, int*, int>)@this->LpVtbl[5])(@this, pClsidPtr, plIDPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OnNextAdd(this ComPtr<IOleParentUndoUnit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IOleParentUndoUnit> thisVtbl, IOleParentUndoUnit* pPUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleParentUndoUnit*, int>)@this->LpVtbl[7])(@this, pPUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Open(this ComPtr<IOleParentUndoUnit> thisVtbl, ref IOleParentUndoUnit pPUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleParentUndoUnit*, int>)@this->LpVtbl[7])(@this, pPUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<IOleParentUndoUnit> thisVtbl, IOleParentUndoUnit* pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, pPUU, fCommit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IOleParentUndoUnit> thisVtbl, ref IOleParentUndoUnit pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, pPUUPtr, fCommit);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Add(this ComPtr<IOleParentUndoUnit> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Add(this ComPtr<IOleParentUndoUnit> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindUnit(this ComPtr<IOleParentUndoUnit> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoUnit*, int>)@this->LpVtbl[10])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindUnit(this ComPtr<IOleParentUndoUnit> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, IOleUndoUnit*, int>)@this->LpVtbl[10])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParentState(this ComPtr<IOleParentUndoUnit> thisVtbl, uint* pdwState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, uint*, int>)@this->LpVtbl[11])(@this, pdwState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetParentState(this ComPtr<IOleParentUndoUnit> thisVtbl, ref uint pdwState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwStatePtr = &pdwState)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleParentUndoUnit*, uint*, int>)@this->LpVtbl[11])(@this, pdwStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Do<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, ComPtr<TI0> pUndoManager) where TI0 : unmanaged, IComVtbl<IOleUndoManager>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Do((IOleUndoManager*) pUndoManager.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Do(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<IOleUndoManager> pUndoManager)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Do(ref pUndoManager.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDescription(this ComPtr<IOleParentUndoUnit> thisVtbl, string[] pBstrSa)
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
    public static unsafe int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, Guid* pClsid, Span<int> plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(pClsid, ref plID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<Guid> pClsid, int* plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(ref pClsid.GetPinnableReference(), plID);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnitType(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<Guid> pClsid, Span<int> plID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnitType(ref pClsid.GetPinnableReference(), ref plID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Open<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, ComPtr<TI0> pPUU) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Open((IOleParentUndoUnit*) pPUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Open(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<IOleParentUndoUnit> pPUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(ref pPUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Close<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, ComPtr<TI0> pPUU, Silk.NET.Core.Bool32 fCommit) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Close((IOleParentUndoUnit*) pPUU.Handle, fCommit);
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<IOleParentUndoUnit> pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Close(ref pPUU.GetPinnableReference(), fCommit);
    }

    /// <summary>To be documented.</summary>
    public static int Add<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Add((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Add(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Add(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindUnit<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindUnit((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FindUnit(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindUnit(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParentState(this ComPtr<IOleParentUndoUnit> thisVtbl, Span<uint> pdwState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParentState(ref pdwState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IOleParentUndoUnit> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
