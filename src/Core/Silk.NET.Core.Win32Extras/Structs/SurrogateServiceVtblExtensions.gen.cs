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

public unsafe static class SurrogateServiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ISurrogateService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ISurrogateService> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, IProcessLock* pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLock, pfApplicationAware);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, IProcessLock* pProcessLock, ref int pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLock, pfApplicationAwarePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, ref IProcessLock pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLockPtr, pfApplicationAware);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, ref IProcessLock pProcessLock, ref int pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
        {
            fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLockPtr, pfApplicationAwarePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, IProcessLock* pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLock, pfApplicationAware);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, IProcessLock* pProcessLock, ref int pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
        {
            fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLock, pfApplicationAwarePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, ref IProcessLock pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
        {
            fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLockPtr, pfApplicationAware);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Init(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, ref IProcessLock pProcessLock, ref int pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
        {
            fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
            {
                fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLockPtr, pfApplicationAwarePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ApplicationLaunch(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidApplID, ApplicationType appType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, ApplicationType, int>)@this->LpVtbl[4])(@this, rguidApplID, appType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ApplicationLaunch(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidApplID, ApplicationType appType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidApplIDPtr = &rguidApplID)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, ApplicationType, int>)@this->LpVtbl[4])(@this, rguidApplIDPtr, appType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ApplicationFree(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidApplID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, int>)@this->LpVtbl[5])(@this, rguidApplID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ApplicationFree(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidApplID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rguidApplIDPtr = &rguidApplID)
        {
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, int>)@this->LpVtbl[5])(@this, rguidApplIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CatalogRefresh(this ComPtr<ISurrogateService> thisVtbl, uint ulReserved)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint, int>)@this->LpVtbl[6])(@this, ulReserved);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ProcessShutdown(this ComPtr<ISurrogateService> thisVtbl, ShutdownType shutdownType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, ShutdownType, int>)@this->LpVtbl[7])(@this, shutdownType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ISurrogateService> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init<TI0>(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, ComPtr<TI0> pProcessLock, int* pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Init(rguidProcessID, (IProcessLock*) pProcessLock.Handle, pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, IProcessLock* pProcessLock, Span<int> pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(rguidProcessID, pProcessLock, ref pfApplicationAware.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init<TI0>(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, ComPtr<TI0> pProcessLock, ref int pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Init(rguidProcessID, (IProcessLock*) pProcessLock.Handle, ref pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, Span<IProcessLock> pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(rguidProcessID, ref pProcessLock.GetPinnableReference(), pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Guid* rguidProcessID, Span<IProcessLock> pProcessLock, Span<int> pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(rguidProcessID, ref pProcessLock.GetPinnableReference(), ref pfApplicationAware.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidProcessID, IProcessLock* pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(ref rguidProcessID.GetPinnableReference(), pProcessLock, pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init<TI0>(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, ComPtr<TI0> pProcessLock, int* pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Init(ref rguidProcessID, (IProcessLock*) pProcessLock.Handle, pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidProcessID, IProcessLock* pProcessLock, Span<int> pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(ref rguidProcessID.GetPinnableReference(), pProcessLock, ref pfApplicationAware.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Init<TI0>(this ComPtr<ISurrogateService> thisVtbl, ref Guid rguidProcessID, ComPtr<TI0> pProcessLock, ref int pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Init(ref rguidProcessID, (IProcessLock*) pProcessLock.Handle, ref pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Init(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidProcessID, Span<IProcessLock> pProcessLock, int* pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(ref rguidProcessID.GetPinnableReference(), ref pProcessLock.GetPinnableReference(), pfApplicationAware);
    }

    /// <summary>To be documented.</summary>
    public static int Init(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidProcessID, Span<IProcessLock> pProcessLock, Span<int> pfApplicationAware)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Init(ref rguidProcessID.GetPinnableReference(), ref pProcessLock.GetPinnableReference(), ref pfApplicationAware.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ApplicationLaunch(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidApplID, ApplicationType appType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ApplicationLaunch(ref rguidApplID.GetPinnableReference(), appType);
    }

    /// <summary>To be documented.</summary>
    public static int ApplicationFree(this ComPtr<ISurrogateService> thisVtbl, Span<Guid> rguidApplID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ApplicationFree(ref rguidApplID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ISurrogateService> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
