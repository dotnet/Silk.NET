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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1ColorContext1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ColorContext1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ColorContext1> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ColorSpace GetColorSpace(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorSpace ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorSpace>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetProfileSize(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, byte* profile, uint profileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profile, profileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, ref byte profile, uint profileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* profilePtr = &profile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profilePtr, profileSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profilePtr, profileSize);
        SilkMarshal.Free((nint)profilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ColorContextType GetColorContextType(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorContextType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorContextType>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.DXGI.ColorSpaceType GetDXGIColorSpace(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.DXGI.ColorSpaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Silk.NET.DXGI.ColorSpaceType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSimpleColorProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, SimpleColorProfile* simpleProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)@this->LpVtbl[9])(@this, simpleProfile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSimpleColorProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, ref SimpleColorProfile simpleProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SimpleColorProfile* simpleProfilePtr = &simpleProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)@this->LpVtbl[9])(@this, simpleProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1ColorContext1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1ColorContext1> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, Span<byte> profile, uint profileSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProfile(ref profile.GetPinnableReference(), profileSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetSimpleColorProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, Span<SimpleColorProfile> simpleProfile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSimpleColorProfile(ref simpleProfile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1ColorContext1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
