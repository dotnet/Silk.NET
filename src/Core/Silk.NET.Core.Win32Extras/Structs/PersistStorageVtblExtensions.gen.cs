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

public unsafe static class PersistStorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPersistStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPersistStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassID(this ComPtr<IPersistStorage> thisVtbl, Guid* pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistStorage> thisVtbl, ref Guid pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClassIDPtr = &pClassID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsDirty(this ComPtr<IPersistStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitNew(this ComPtr<IPersistStorage> thisVtbl, IStorage* pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[5])(@this, pStg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitNew(this ComPtr<IPersistStorage> thisVtbl, ref IStorage pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[5])(@this, pStgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IPersistStorage> thisVtbl, IStorage* pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[6])(@this, pStg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistStorage> thisVtbl, ref IStorage pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[6])(@this, pStgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Save(this ComPtr<IPersistStorage> thisVtbl, IStorage* pStgSave, Silk.NET.Core.Bool32 fSameAsLoad)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pStgSave, fSameAsLoad);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistStorage> thisVtbl, ref IStorage pStgSave, Silk.NET.Core.Bool32 fSameAsLoad)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgSavePtr = &pStgSave)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, pStgSavePtr, fSameAsLoad);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SaveCompleted(this ComPtr<IPersistStorage> thisVtbl, IStorage* pStgNew)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[8])(@this, pStgNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted(this ComPtr<IPersistStorage> thisVtbl, ref IStorage pStgNew)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgNewPtr = &pStgNew)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, IStorage*, int>)@this->LpVtbl[8])(@this, pStgNewPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HandsOffStorage(this ComPtr<IPersistStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistStorage*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPersistStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistStorage> thisVtbl, Span<Guid> pClassID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassID(ref pClassID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InitNew<TI0>(this ComPtr<IPersistStorage> thisVtbl, ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitNew((IStorage*) pStg.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int InitNew(this ComPtr<IPersistStorage> thisVtbl, Span<IStorage> pStg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitNew(ref pStg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IPersistStorage> thisVtbl, ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((IStorage*) pStg.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IPersistStorage> thisVtbl, Span<IStorage> pStg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pStg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Save<TI0>(this ComPtr<IPersistStorage> thisVtbl, ComPtr<TI0> pStgSave, Silk.NET.Core.Bool32 fSameAsLoad) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Save((IStorage*) pStgSave.Handle, fSameAsLoad);
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IPersistStorage> thisVtbl, Span<IStorage> pStgSave, Silk.NET.Core.Bool32 fSameAsLoad)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Save(ref pStgSave.GetPinnableReference(), fSameAsLoad);
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted<TI0>(this ComPtr<IPersistStorage> thisVtbl, ComPtr<TI0> pStgNew) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SaveCompleted((IStorage*) pStgNew.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SaveCompleted(this ComPtr<IPersistStorage> thisVtbl, Span<IStorage> pStgNew)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SaveCompleted(ref pStgNew.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPersistStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
