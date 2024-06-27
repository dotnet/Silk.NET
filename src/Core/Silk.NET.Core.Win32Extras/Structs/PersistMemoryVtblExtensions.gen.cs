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

public unsafe static class PersistMemoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPersistMemory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPersistMemory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassID(this ComPtr<IPersistMemory> thisVtbl, Guid* pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistMemory> thisVtbl, ref Guid pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClassIDPtr = &pClassID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsDirty(this ComPtr<IPersistMemory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IPersistMemory> thisVtbl, void* pMem, uint cbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, uint, int>)@this->LpVtbl[5])(@this, pMem, cbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load<T0>(this ComPtr<IPersistMemory> thisVtbl, ref T0 pMem, uint cbSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pMemPtr = &pMem)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, uint, int>)@this->LpVtbl[5])(@this, pMemPtr, cbSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Save(this ComPtr<IPersistMemory> thisVtbl, void* pMem, Silk.NET.Core.Bool32 fClearDirty, uint cbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, Silk.NET.Core.Bool32, uint, int>)@this->LpVtbl[6])(@this, pMem, fClearDirty, cbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save<T0>(this ComPtr<IPersistMemory> thisVtbl, ref T0 pMem, Silk.NET.Core.Bool32 fClearDirty, uint cbSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pMemPtr = &pMem)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, void*, Silk.NET.Core.Bool32, uint, int>)@this->LpVtbl[6])(@this, pMemPtr, fClearDirty, cbSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeMax(this ComPtr<IPersistMemory> thisVtbl, uint* pCbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint*, int>)@this->LpVtbl[7])(@this, pCbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IPersistMemory> thisVtbl, ref uint pCbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCbSizePtr = &pCbSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, uint*, int>)@this->LpVtbl[7])(@this, pCbSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitNew(this ComPtr<IPersistMemory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPersistMemory*, int>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPersistMemory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPersistMemory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IPersistMemory> thisVtbl, Span<Guid> pClassID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassID(ref pClassID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load<T0>(this ComPtr<IPersistMemory> thisVtbl, Span<T0> pMem, uint cbSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pMem.GetPinnableReference(), cbSize);
    }

    /// <summary>To be documented.</summary>
    public static int Save<T0>(this ComPtr<IPersistMemory> thisVtbl, Span<T0> pMem, Silk.NET.Core.Bool32 fClearDirty, uint cbSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Save(ref pMem.GetPinnableReference(), fClearDirty, cbSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IPersistMemory> thisVtbl, Span<uint> pCbSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeMax(ref pCbSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPersistMemory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
