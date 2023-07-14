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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionInkTrailDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionInkTrailDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionInkTrailDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrail(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[3])(@this, inkTrail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrail(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref IDCompositionDelegatedInkTrail* inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionDelegatedInkTrail** inkTrailPtr = &inkTrail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[3])(@this, inkTrailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Silk.NET.Core.Native.IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChain, inkTrail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Silk.NET.Core.Native.IUnknown* swapChain, ref IDCompositionDelegatedInkTrail* inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionDelegatedInkTrail** inkTrailPtr = &inkTrail)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChain, inkTrailPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref Silk.NET.Core.Native.IUnknown swapChain, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* swapChainPtr = &swapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChainPtr, inkTrail);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref Silk.NET.Core.Native.IUnknown swapChain, ref IDCompositionDelegatedInkTrail* inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* swapChainPtr = &swapChain)
        {
            fixed (IDCompositionDelegatedInkTrail** inkTrailPtr = &inkTrail)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChainPtr, inkTrailPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDelegatedInkTrail<TI0>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref ComPtr<TI0> inkTrail) where TI0 : unmanaged, IComVtbl<IDCompositionDelegatedInkTrail>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDelegatedInkTrail((IDCompositionDelegatedInkTrail**) inkTrail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateDelegatedInkTrailForSwapChain<TI0, TI1>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ComPtr<TI0> swapChain, ref ComPtr<TI1> inkTrail) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionDelegatedInkTrail>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDelegatedInkTrailForSwapChain((Silk.NET.Core.Native.IUnknown*) swapChain.Handle, (IDCompositionDelegatedInkTrail**) inkTrail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain<TI0>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ComPtr<TI0> swapChain, ref IDCompositionDelegatedInkTrail* inkTrail) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDelegatedInkTrailForSwapChain((Silk.NET.Core.Native.IUnknown*) swapChain.Handle, ref inkTrail);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> swapChain, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDelegatedInkTrailForSwapChain(ref swapChain.GetPinnableReference(), inkTrail);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDelegatedInkTrailForSwapChain<TI0>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, ref Silk.NET.Core.Native.IUnknown swapChain, ref ComPtr<TI0> inkTrail) where TI0 : unmanaged, IComVtbl<IDCompositionDelegatedInkTrail>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDelegatedInkTrailForSwapChain(ref swapChain, (IDCompositionDelegatedInkTrail**) inkTrail.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> swapChain, ref IDCompositionDelegatedInkTrail* inkTrail)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDelegatedInkTrailForSwapChain(ref swapChain.GetPinnableReference(), ref inkTrail);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionInkTrailDevice> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
