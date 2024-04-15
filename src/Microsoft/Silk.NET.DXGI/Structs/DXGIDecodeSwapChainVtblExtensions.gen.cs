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

namespace Silk.NET.DXGI;

public unsafe static class DXGIDecodeSwapChainVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PresentBuffer(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint BufferToPresent, uint SyncInterval, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, BufferToPresent, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint Width, uint Height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, int>)@this->LpVtbl[6])(@this, Width, Height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[7])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[7])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[8])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[8])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint* pWidth, uint* pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidth, pHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint* pWidth, ref uint pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pHeightPtr = &pHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidth, pHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref uint pWidth, uint* pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pWidthPtr = &pWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidthPtr, pHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, ref uint pWidth, ref uint pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pWidthPtr = &pWidth)
        {
            fixed (uint* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidthPtr, pHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColorSpace(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, MULTIPLANEOVERLAYYCbCrFLAGS ColorSpace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS, int>)@this->LpVtbl[10])(@this, ColorSpace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MULTIPLANEOVERLAYYCbCrFLAGS GetColorSpace(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        MULTIPLANEOVERLAYYCbCrFLAGS ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceRect(in pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTargetRect(in pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSourceRect(ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTargetRect(ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint* pWidth, Span<uint> pHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestSize(pWidth, ref pHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<uint> pWidth, uint* pHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestSize(ref pWidth.GetPinnableReference(), pHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Span<uint> pWidth, Span<uint> pHeight)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestSize(ref pWidth.GetPinnableReference(), ref pHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIDecodeSwapChain> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
