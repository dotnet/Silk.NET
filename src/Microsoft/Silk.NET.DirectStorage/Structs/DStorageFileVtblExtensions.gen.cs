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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageFileVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Close<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageFile*, void>)@this->LpVtbl[3])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileInformation<TThis>(this TThis thisVtbl, Silk.NET.Core.Win32Extras.ByHandleFileInformation* info) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)@this->LpVtbl[4])(@this, info);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileInformation<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Win32Extras.ByHandleFileInformation info) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.ByHandleFileInformation* infoPtr = &info)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFile*, Silk.NET.Core.Win32Extras.ByHandleFileInformation*, int>)@this->LpVtbl[4])(@this, infoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFileInformation<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Win32Extras.ByHandleFileInformation> info) where TThis : IComVtbl<IDStorageFile>
    {
        var @this = (IDStorageFile*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFileInformation(ref info.GetPinnableReference());
    }

}
