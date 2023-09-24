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

public unsafe static class RunnableObjectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRunnableObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRunnableObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRunningClass(this ComPtr<IRunnableObject> thisVtbl, Guid* lpClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, int>)@this->LpVtbl[3])(@this, lpClsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRunningClass(this ComPtr<IRunnableObject> thisVtbl, ref Guid lpClsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* lpClsidPtr = &lpClsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Guid*, int>)@this->LpVtbl[3])(@this, lpClsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Run(this ComPtr<IRunnableObject> thisVtbl, IBindCtx* pbc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, IBindCtx*, int>)@this->LpVtbl[4])(@this, pbc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Run(this ComPtr<IRunnableObject> thisVtbl, ref IBindCtx pbc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, IBindCtx*, int>)@this->LpVtbl[4])(@this, pbcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsRunning(this ComPtr<IRunnableObject> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRunning(this ComPtr<IRunnableObject> thisVtbl, Silk.NET.Core.Bool32 fLock, Silk.NET.Core.Bool32 fLastUnlockCloses)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, fLock, fLastUnlockCloses);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetContainedObject(this ComPtr<IRunnableObject> thisVtbl, Silk.NET.Core.Bool32 fContained)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunnableObject*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, fContained);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRunnableObject> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunnableObject> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetRunningClass(this ComPtr<IRunnableObject> thisVtbl, Span<Guid> lpClsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRunningClass(ref lpClsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Run<TI0>(this ComPtr<IRunnableObject> thisVtbl, ComPtr<TI0> pbc) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Run((IBindCtx*) pbc.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Run(this ComPtr<IRunnableObject> thisVtbl, Span<IBindCtx> pbc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Run(ref pbc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRunnableObject> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
