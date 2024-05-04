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
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDxcIncludeHandler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcIncludeHandler> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, IDxcBlob** ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, ref IDxcBlob* ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, IDxcBlob** ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pFilenamePtr = &pFilename)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, ref IDxcBlob* ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, IDxcBlob** ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
        SilkMarshal.Free((nint)pFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref IDxcBlob* ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IDxcIncludeHandler> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcIncludeHandler> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource<TI0>(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadSource(pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFilename, IDxcBlob** ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadSource(in pFilename.GetPinnableReference(), ppIncludeSource);
    }

    /// <summary>To be documented.</summary>
    public static int LoadSource<TI0>(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadSource(in pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadSource(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pFilename, ref IDxcBlob* ppIncludeSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadSource(in pFilename.GetPinnableReference(), ref ppIncludeSource);
    }

    /// <summary>To be documented.</summary>
    public static int LoadSource<TI0>(this ComPtr<IDxcIncludeHandler> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadSource(pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcIncludeHandler> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
