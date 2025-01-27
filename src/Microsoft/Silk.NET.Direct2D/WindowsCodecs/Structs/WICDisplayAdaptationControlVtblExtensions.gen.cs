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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICDisplayAdaptationControlVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICDisplayAdaptationControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICDisplayAdaptationControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Guid* pguidDstFormat, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormat, pfIsSupported);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Guid* pguidDstFormat, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIsSupportedPtr = &pfIsSupported)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormat, pfIsSupportedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, ref Guid pguidDstFormat, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormatPtr, pfIsSupported);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, ref Guid pguidDstFormat, ref int pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidDstFormatPtr = &pguidDstFormat)
        {
            fixed (int* pfIsSupportedPtr = &pfIsSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, Guid*, int*, int>)@this->LpVtbl[3])(@this, pguidDstFormatPtr, pfIsSupportedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDisplayMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, float fLuminanceInNits)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float, int>)@this->LpVtbl[4])(@this, fLuminanceInNits);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, float* pfLuminanceInNits)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float*, int>)@this->LpVtbl[5])(@this, pfLuminanceInNits);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, ref float pfLuminanceInNits)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pfLuminanceInNitsPtr = &pfLuminanceInNits)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICDisplayAdaptationControl*, float*, int>)@this->LpVtbl[5])(@this, pfLuminanceInNitsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Guid* pguidDstFormat, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportChangingMaxLuminance(pguidDstFormat, ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Span<Guid> pguidDstFormat, int* pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportChangingMaxLuminance(ref pguidDstFormat.GetPinnableReference(), pfIsSupported);
    }

    /// <summary>To be documented.</summary>
    public static int DoesSupportChangingMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Span<Guid> pguidDstFormat, Span<int> pfIsSupported)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DoesSupportChangingMaxLuminance(ref pguidDstFormat.GetPinnableReference(), ref pfIsSupported.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMaxLuminance(this ComPtr<IWICDisplayAdaptationControl> thisVtbl, Span<float> pfLuminanceInNits)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayMaxLuminance(ref pfLuminanceInNits.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICDisplayAdaptationControl> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
