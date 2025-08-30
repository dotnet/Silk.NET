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

public unsafe static class D3D12SDKConfiguration1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12SDKConfiguration1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12SDKConfiguration1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSDKVersion(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Guid* riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riid, ppvFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Guid* riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvFactoryPtr = &ppvFactory)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riid, ppvFactoryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, ref Guid riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riidPtr, ppvFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, ref Guid riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvFactoryPtr = &ppvFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riidPtr, ppvFactoryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, Guid* riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, Guid* riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            fixed (void** ppvFactoryPtr = &ppvFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactoryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, ref Guid riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, ref Guid riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* SDKPathPtr = &SDKPath)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvFactoryPtr = &ppvFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactoryPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Guid* riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactory);
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Guid* riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        fixed (void** ppvFactoryPtr = &ppvFactory)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactoryPtr);
        }
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, ref Guid riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactory);
        }
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, ref Guid riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvFactoryPtr = &ppvFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactoryPtr);
            }
        }
        SilkMarshal.Free((nint)SDKPathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void FreeUnusedSDKs(this ComPtr<ID3D12SDKConfiguration1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, void>)@this->LpVtbl[5])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSDKVersion(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> SDKPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSDKVersion(SDKVersion, in SDKPath.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvFactory = default;
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Span<Guid> riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, ref riid.GetPinnableReference(), ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Span<Guid> riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, ref riid.GetPinnableReference(), ref ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> SDKPath, Guid* riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, in SDKPath.GetPinnableReference(), riid, ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvFactory = default;
        return @this->CreateDeviceFactory(SDKVersion, in SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> SDKPath, Guid* riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, in SDKPath.GetPinnableReference(), riid, ref ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> SDKPath, Span<Guid> riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, in SDKPath.GetPinnableReference(), ref riid.GetPinnableReference(), ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> SDKPath, Span<Guid> riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, in SDKPath.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvFactory = default;
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Span<Guid> riid, void** ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, ref riid.GetPinnableReference(), ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceFactory(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Span<Guid> riid, ref void* ppvFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDeviceFactory(SDKVersion, SDKPath, ref riid.GetPinnableReference(), ref ppvFactory);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, SDKPath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, in SDKPath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDeviceFactory<TI0>(this ComPtr<ID3D12SDKConfiguration1> thisVtbl, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, SDKPath, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
