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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcIncludeHandlerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, char* pFilename, IDxcBlob** ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, char* pFilename, ref IDxcBlob* ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, ref char pFilename, IDxcBlob** ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFilenamePtr = &pFilename)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, ref char pFilename, ref IDxcBlob* ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFilenamePtr = &pFilename)
        {
            fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, IDxcBlob** ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
        SilkMarshal.Free((nint)pFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref IDxcBlob* ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
        fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
        }
        SilkMarshal.Free((nint)pFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, Span<char> pFilename, IDxcBlob** ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadSource(ref pFilename.GetPinnableReference(), ppIncludeSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TThis>(this TThis thisVtbl, Span<char> pFilename, ref IDxcBlob* ppIncludeSource) where TThis : IComVtbl<IDxcIncludeHandler>
    {
        var @this = (IDxcIncludeHandler*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadSource(ref pFilename.GetPinnableReference(), ref ppIncludeSource);
    }

}
