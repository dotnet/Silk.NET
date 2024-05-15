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

public unsafe static class OleUndoManagerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IOleUndoManager> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IOleUndoManager> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IOleUndoManager> thisVtbl, IOleParentUndoUnit* pPUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, int>)@this->LpVtbl[3])(@this, pPUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Open(this ComPtr<IOleUndoManager> thisVtbl, ref IOleParentUndoUnit pPUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, int>)@this->LpVtbl[3])(@this, pPUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<IOleUndoManager> thisVtbl, IOleParentUndoUnit* pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, pPUU, fCommit);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IOleUndoManager> thisVtbl, ref IOleParentUndoUnit pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleParentUndoUnit* pPUUPtr = &pPUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleParentUndoUnit*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[4])(@this, pPUUPtr, fCommit);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Add(this ComPtr<IOleUndoManager> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[5])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Add(this ComPtr<IOleUndoManager> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[5])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOpenParentState(this ComPtr<IOleUndoManager> thisVtbl, uint* pdwState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint*, int>)@this->LpVtbl[6])(@this, pdwState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOpenParentState(this ComPtr<IOleUndoManager> thisVtbl, ref uint pdwState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwStatePtr = &pdwState)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, uint*, int>)@this->LpVtbl[6])(@this, pdwStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DiscardFrom(this ComPtr<IOleUndoManager> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[7])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DiscardFrom(this ComPtr<IOleUndoManager> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[7])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UndoTo(this ComPtr<IOleUndoManager> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[8])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UndoTo(this ComPtr<IOleUndoManager> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[8])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RedoTo(this ComPtr<IOleUndoManager> thisVtbl, IOleUndoUnit* pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUU);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RedoTo(this ComPtr<IOleUndoManager> thisVtbl, ref IOleUndoUnit pUU)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IOleUndoUnit* pUUPtr = &pUU)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IOleUndoUnit*, int>)@this->LpVtbl[9])(@this, pUUPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumUndoable(this ComPtr<IOleUndoManager> thisVtbl, IEnumOleUndoUnits** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[10])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumUndoable(this ComPtr<IOleUndoManager> thisVtbl, ref IEnumOleUndoUnits* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[10])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumRedoable(this ComPtr<IOleUndoManager> thisVtbl, IEnumOleUndoUnits** ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[11])(@this, ppEnum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumRedoable(this ComPtr<IOleUndoManager> thisVtbl, ref IEnumOleUndoUnits* ppEnum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumOleUndoUnits** ppEnumPtr = &ppEnum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, IEnumOleUndoUnits**, int>)@this->LpVtbl[11])(@this, ppEnumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastUndoDescription(this ComPtr<IOleUndoManager> thisVtbl, char** pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[12])(@this, pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastUndoDescription(this ComPtr<IOleUndoManager> thisVtbl, ref char* pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrPtr = &pBstr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[12])(@this, pBstrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastRedoDescription(this ComPtr<IOleUndoManager> thisVtbl, char** pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[13])(@this, pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastRedoDescription(this ComPtr<IOleUndoManager> thisVtbl, ref char* pBstr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrPtr = &pBstr)
        {
            ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, char**, int>)@this->LpVtbl[13])(@this, pBstrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Enable(this ComPtr<IOleUndoManager> thisVtbl, Silk.NET.Core.Bool32 fEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IOleUndoManager*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[14])(@this, fEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IOleUndoManager> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IOleUndoManager> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int Open<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pPUU) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Open((IOleParentUndoUnit*) pPUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Open(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleParentUndoUnit> pPUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(ref pPUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Close<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pPUU, Silk.NET.Core.Bool32 fCommit) where TI0 : unmanaged, IComVtbl<IOleParentUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Close((IOleParentUndoUnit*) pPUU.Handle, fCommit);
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleParentUndoUnit> pPUU, Silk.NET.Core.Bool32 fCommit)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Close(ref pPUU.GetPinnableReference(), fCommit);
    }

    /// <summary>To be documented.</summary>
    public static int Add<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Add((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Add(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Add(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetOpenParentState(this ComPtr<IOleUndoManager> thisVtbl, Span<uint> pdwState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetOpenParentState(ref pdwState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DiscardFrom<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DiscardFrom((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int DiscardFrom(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DiscardFrom(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UndoTo<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UndoTo((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UndoTo(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UndoTo(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RedoTo<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ComPtr<TI0> pUU) where TI0 : unmanaged, IComVtbl<IOleUndoUnit>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RedoTo((IOleUndoUnit*) pUU.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RedoTo(this ComPtr<IOleUndoManager> thisVtbl, Span<IOleUndoUnit> pUU)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RedoTo(ref pUU.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumUndoable<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumUndoable((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int EnumRedoable<TI0>(this ComPtr<IOleUndoManager> thisVtbl, ref ComPtr<TI0> ppEnum) where TI0 : unmanaged, IComVtbl<IEnumOleUndoUnits>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumRedoable((IEnumOleUndoUnits**) ppEnum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastUndoDescription(this ComPtr<IOleUndoManager> thisVtbl, string[] pBstrSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
        var ret = @this->GetLastUndoDescription(pBstr);
        SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
        SilkMarshal.Free((nint) pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastRedoDescription(this ComPtr<IOleUndoManager> thisVtbl, string[] pBstrSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstr = (char**) SilkMarshal.StringArrayToPtr(pBstrSa);
        var ret = @this->GetLastRedoDescription(pBstr);
        SilkMarshal.CopyPtrToStringArray((nint) pBstr, pBstrSa);
        SilkMarshal.Free((nint) pBstr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IOleUndoManager> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
