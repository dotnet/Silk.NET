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

public unsafe static class RunningObjectTableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRunningObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRunningObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, IMoniker* pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectName, pdwRegister);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, IMoniker* pmkObjectName, ref uint pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwRegisterPtr = &pdwRegister)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectName, pdwRegisterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, ref IMoniker pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectNamePtr, pdwRegister);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            fixed (uint* pdwRegisterPtr = &pdwRegister)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObject, pmkObjectNamePtr, pdwRegisterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, IMoniker* pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectName, pdwRegister);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, IMoniker* pmkObjectName, ref uint pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
        {
            fixed (uint* pdwRegisterPtr = &pdwRegister)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectName, pdwRegisterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ref IMoniker pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
        {
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectNamePtr, pdwRegister);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkObjectPtr = &punkObject)
        {
            fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
            {
                fixed (uint* pdwRegisterPtr = &pdwRegister)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Silk.NET.Core.Native.IUnknown*, IMoniker*, uint*, int>)@this->LpVtbl[3])(@this, grfFlags, punkObjectPtr, pmkObjectNamePtr, pdwRegisterPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Revoke(this ComPtr<IRunningObjectTable> thisVtbl, uint dwRegister)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, int>)@this->LpVtbl[4])(@this, dwRegister);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, int>)@this->LpVtbl[5])(@this, pmkObjectName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, int>)@this->LpVtbl[5])(@this, pmkObjectNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName, Silk.NET.Core.Native.IUnknown** ppunkObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectName, ppunkObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppunkObjectPtr = &ppunkObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectName, ppunkObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName, Silk.NET.Core.Native.IUnknown** ppunkObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectNamePtr, ppunkObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppunkObjectPtr = &ppunkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pmkObjectNamePtr, ppunkObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NoteChangeTime(this ComPtr<IRunningObjectTable> thisVtbl, uint dwRegister, Filetime* pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Filetime*, int>)@this->LpVtbl[7])(@this, dwRegister, pfiletime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int NoteChangeTime(this ComPtr<IRunningObjectTable> thisVtbl, uint dwRegister, ref Filetime pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pfiletimePtr = &pfiletime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, uint, Filetime*, int>)@this->LpVtbl[7])(@this, dwRegister, pfiletimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName, Filetime* pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectName, pfiletime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName, ref Filetime pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pfiletimePtr = &pfiletime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectName, pfiletimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName, Filetime* pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectNamePtr, pfiletime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName, ref Filetime pfiletime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkObjectNamePtr = &pmkObjectName)
        {
            fixed (Filetime* pfiletimePtr = &pfiletime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IMoniker*, Filetime*, int>)@this->LpVtbl[8])(@this, pmkObjectNamePtr, pfiletimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumRunning(this ComPtr<IRunningObjectTable> thisVtbl, IEnumMoniker** ppenumMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IEnumMoniker**, int>)@this->LpVtbl[9])(@this, ppenumMoniker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumRunning(this ComPtr<IRunningObjectTable> thisVtbl, ref IEnumMoniker* ppenumMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumMoniker** ppenumMonikerPtr = &ppenumMoniker)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRunningObjectTable*, IEnumMoniker**, int>)@this->LpVtbl[9])(@this, ppenumMonikerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRunningObjectTable> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register<TI0, TI1>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ComPtr<TI0> punkObject, ComPtr<TI1> pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, (IMoniker*) pmkObjectName.Handle, pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, IMoniker* pmkObjectName, Span<uint> pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, punkObject, pmkObjectName, ref pdwRegister.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Register<TI0, TI1>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ComPtr<TI0> punkObject, ComPtr<TI1> pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, (IMoniker*) pmkObjectName.Handle, ref pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, Span<IMoniker> pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, punkObject, ref pmkObjectName.GetPinnableReference(), pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ComPtr<TI0> punkObject, ref IMoniker pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, ref pmkObjectName, pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Silk.NET.Core.Native.IUnknown* punkObject, Span<IMoniker> pmkObjectName, Span<uint> pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, punkObject, ref pmkObjectName.GetPinnableReference(), ref pdwRegister.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Register<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ComPtr<TI0> punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, (Silk.NET.Core.Native.IUnknown*) punkObject.Handle, ref pmkObjectName, ref pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Span<Silk.NET.Core.Native.IUnknown> punkObject, IMoniker* pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, ref punkObject.GetPinnableReference(), pmkObjectName, pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ComPtr<TI0> pmkObjectName, uint* pdwRegister) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, ref punkObject, (IMoniker*) pmkObjectName.Handle, pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Span<Silk.NET.Core.Native.IUnknown> punkObject, IMoniker* pmkObjectName, Span<uint> pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, ref punkObject.GetPinnableReference(), pmkObjectName, ref pdwRegister.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Register<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, ref Silk.NET.Core.Native.IUnknown punkObject, ComPtr<TI0> pmkObjectName, ref uint pdwRegister) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Register(grfFlags, ref punkObject, (IMoniker*) pmkObjectName.Handle, ref pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Span<Silk.NET.Core.Native.IUnknown> punkObject, Span<IMoniker> pmkObjectName, uint* pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, ref punkObject.GetPinnableReference(), ref pmkObjectName.GetPinnableReference(), pdwRegister);
    }

    /// <summary>To be documented.</summary>
    public static int Register(this ComPtr<IRunningObjectTable> thisVtbl, uint grfFlags, Span<Silk.NET.Core.Native.IUnknown> punkObject, Span<IMoniker> pmkObjectName, Span<uint> pdwRegister)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Register(grfFlags, ref punkObject.GetPinnableReference(), ref pmkObjectName.GetPinnableReference(), ref pdwRegister.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ComPtr<TI0> pmkObjectName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning((IMoniker*) pmkObjectName.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning(this ComPtr<IRunningObjectTable> thisVtbl, Span<IMoniker> pmkObjectName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(ref pmkObjectName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectA<TI0, TI1>(this ComPtr<IRunningObjectTable> thisVtbl, ComPtr<TI0> pmkObjectName, ref ComPtr<TI1> ppunkObject) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectA((IMoniker*) pmkObjectName.Handle, (Silk.NET.Core.Native.IUnknown**) ppunkObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ComPtr<TI0> pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectA((IMoniker*) pmkObjectName.Handle, ref ppunkObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, Span<IMoniker> pmkObjectName, Silk.NET.Core.Native.IUnknown** ppunkObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref pmkObjectName.GetPinnableReference(), ppunkObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetObjectA<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ref IMoniker pmkObjectName, ref ComPtr<TI0> ppunkObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetObjectA(ref pmkObjectName, (Silk.NET.Core.Native.IUnknown**) ppunkObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IRunningObjectTable> thisVtbl, Span<IMoniker> pmkObjectName, ref Silk.NET.Core.Native.IUnknown* ppunkObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetObjectA(ref pmkObjectName.GetPinnableReference(), ref ppunkObject);
    }

    /// <summary>To be documented.</summary>
    public static int NoteChangeTime(this ComPtr<IRunningObjectTable> thisVtbl, uint dwRegister, Span<Filetime> pfiletime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->NoteChangeTime(dwRegister, ref pfiletime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ComPtr<TI0> pmkObjectName, Filetime* pfiletime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IMoniker*) pmkObjectName.Handle, pfiletime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, IMoniker* pmkObjectName, Span<Filetime> pfiletime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(pmkObjectName, ref pfiletime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ComPtr<TI0> pmkObjectName, ref Filetime pfiletime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IMoniker*) pmkObjectName.Handle, ref pfiletime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, Span<IMoniker> pmkObjectName, Filetime* pfiletime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pmkObjectName.GetPinnableReference(), pfiletime);
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange(this ComPtr<IRunningObjectTable> thisVtbl, Span<IMoniker> pmkObjectName, Span<Filetime> pfiletime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pmkObjectName.GetPinnableReference(), ref pfiletime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumRunning<TI0>(this ComPtr<IRunningObjectTable> thisVtbl, ref ComPtr<TI0> ppenumMoniker) where TI0 : unmanaged, IComVtbl<IEnumMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumRunning((IEnumMoniker**) ppenumMoniker.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRunningObjectTable> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
