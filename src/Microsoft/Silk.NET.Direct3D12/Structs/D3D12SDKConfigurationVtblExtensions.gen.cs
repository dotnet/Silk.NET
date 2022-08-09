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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12SDKConfigurationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSDKVersion<TThis>(this TThis thisVtbl, uint SDKVersion, byte* SDKPath) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion<TThis>(this TThis thisVtbl, uint SDKVersion, ref byte SDKPath) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion<TThis>(this TThis thisVtbl, uint SDKVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion<TThis>(this TThis thisVtbl, uint SDKVersion, Span<byte> SDKPath) where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetSDKVersion(SDKVersion, ref SDKPath.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12SDKConfiguration>
    {
        var @this = (ID3D12SDKConfiguration*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
