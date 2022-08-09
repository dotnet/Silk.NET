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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ModuleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, byte* pNamespace, ID3D11ModuleInstance** ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespace, ppModuleInstance);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, byte* pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespace, ppModuleInstancePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, ref byte pNamespace, ID3D11ModuleInstance** ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamespacePtr = &pNamespace)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, ref byte pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pNamespacePtr = &pNamespace)
        {
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pNamespace, ID3D11ModuleInstance** ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamespacePtr = (byte*) SilkMarshal.StringToPtr(pNamespace, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespacePtr, ppModuleInstance);
        SilkMarshal.Free((nint)pNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pNamespacePtr = (byte*) SilkMarshal.StringToPtr(pNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, int>)@this->LpVtbl[3])(@this, pNamespacePtr, ppModuleInstancePtr);
        }
        SilkMarshal.Free((nint)pNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TI0, TThis>(this TThis thisVtbl, byte* pNamespace, ref ComPtr<TI0> ppModuleInstance) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateInstance(pNamespace, (ID3D11ModuleInstance**) ppModuleInstance.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, Span<byte> pNamespace, ID3D11ModuleInstance** ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateInstance(ref pNamespace.GetPinnableReference(), ppModuleInstance);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0, TThis>(this TThis thisVtbl, ref byte pNamespace, ref ComPtr<TI0> ppModuleInstance) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateInstance(ref pNamespace, (ID3D11ModuleInstance**) ppModuleInstance.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInstance<TThis>(this TThis thisVtbl, Span<byte> pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateInstance(ref pNamespace.GetPinnableReference(), ref ppModuleInstance);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInstance<TI0, TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pNamespace, ref ComPtr<TI0> ppModuleInstance) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateInstance(pNamespace, (ID3D11ModuleInstance**) ppModuleInstance.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Module>
    {
        var @this = (ID3D11Module*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
