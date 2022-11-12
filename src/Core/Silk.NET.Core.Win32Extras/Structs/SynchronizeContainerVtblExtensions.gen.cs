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

public unsafe static class SynchronizeContainerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISynchronizeContainer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISynchronizeContainer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSynchronize(this ComPtr<ISynchronizeContainer> thisVtbl, ISynchronize* pSync)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, ISynchronize*, int>)@this->LpVtbl[3])(@this, pSync);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddSynchronize(this ComPtr<ISynchronizeContainer> thisVtbl, ref ISynchronize pSync)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISynchronize* pSyncPtr = &pSync)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, ISynchronize*, int>)@this->LpVtbl[3])(@this, pSyncPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WaitMultiple(this ComPtr<ISynchronizeContainer> thisVtbl, uint dwFlags, uint dwTimeOut, ISynchronize** ppSync)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, uint, uint, ISynchronize**, int>)@this->LpVtbl[4])(@this, dwFlags, dwTimeOut, ppSync);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WaitMultiple(this ComPtr<ISynchronizeContainer> thisVtbl, uint dwFlags, uint dwTimeOut, ref ISynchronize* ppSync)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ISynchronize** ppSyncPtr = &ppSync)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISynchronizeContainer*, uint, uint, ISynchronize**, int>)@this->LpVtbl[4])(@this, dwFlags, dwTimeOut, ppSyncPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ISynchronizeContainer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISynchronizeContainer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AddSynchronize<TI0>(this ComPtr<ISynchronizeContainer> thisVtbl, ComPtr<TI0> pSync) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSynchronize((ISynchronize*) pSync.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddSynchronize(this ComPtr<ISynchronizeContainer> thisVtbl, Span<ISynchronize> pSync)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSynchronize(ref pSync.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WaitMultiple<TI0>(this ComPtr<ISynchronizeContainer> thisVtbl, uint dwFlags, uint dwTimeOut, ref ComPtr<TI0> ppSync) where TI0 : unmanaged, IComVtbl<ISynchronize>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WaitMultiple(dwFlags, dwTimeOut, (ISynchronize**) ppSync.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ISynchronizeContainer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
