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

public unsafe static class PersistStreamInitVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPersistStreamInit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPersistStreamInit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassID(this ComPtr<IPersistStreamInit> thisVtbl, Guid* pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistStreamInit> thisVtbl, ref Guid pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClassIDPtr = &pClassID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsDirty(this ComPtr<IPersistStreamInit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IPersistStreamInit> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistStreamInit> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Save(this ComPtr<IPersistStreamInit> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStm, fClearDirty);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistStreamInit> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStmPtr, fClearDirty);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeMax(this ComPtr<IPersistStreamInit> thisVtbl, ulong* pCbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, ulong*, int>)@this->LpVtbl[7])(@this, pCbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IPersistStreamInit> thisVtbl, ref ulong pCbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pCbSizePtr = &pCbSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, ulong*, int>)@this->LpVtbl[7])(@this, pCbSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitNew(this ComPtr<IPersistStreamInit> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStreamInit*, int>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPersistStreamInit> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStreamInit> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistStreamInit> thisVtbl, Span<Guid> pClassID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassID(ref pClassID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IPersistStreamInit> thisVtbl, ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistStreamInit> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pStm.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Save<TI0>(this ComPtr<IPersistStreamInit> thisVtbl, ComPtr<TI0> pStm, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Save((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, fClearDirty);
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistStreamInit> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Save(ref pStm.GetPinnableReference(), fClearDirty);
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IPersistStreamInit> thisVtbl, Span<ulong> pCbSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeMax(ref pCbSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPersistStreamInit> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
