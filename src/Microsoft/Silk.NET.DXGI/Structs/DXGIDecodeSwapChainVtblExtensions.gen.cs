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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PresentBuffer<TThis>(this TThis thisVtbl, uint BufferToPresent, uint SyncInterval, uint Flags) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, BufferToPresent, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTargetRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[5])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTargetRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[5])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDestSize<TThis>(this TThis thisVtbl, uint Width, uint Height) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, int>)@this->LpVtbl[6])(@this, Width, Height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[7])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[7])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTargetRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[8])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize<TThis>(this TThis thisVtbl, uint* pWidth, uint* pHeight) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidth, pHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize<TThis>(this TThis thisVtbl, uint* pWidth, ref uint pHeight) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pHeightPtr = &pHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidth, pHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize<TThis>(this TThis thisVtbl, ref uint pWidth, uint* pHeight) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pWidthPtr = &pWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidthPtr, pHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDestSize<TThis>(this TThis thisVtbl, ref uint pWidth, ref uint pHeight) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
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
    public static int SetColorSpace<TThis>(this TThis thisVtbl, MULTIPLANEOVERLAYYCbCrFLAGS ColorSpace) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS, int>)@this->LpVtbl[10])(@this, ColorSpace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MULTIPLANEOVERLAYYCbCrFLAGS GetColorSpace<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIDecodeSwapChain>
    {
        var @this = (IDXGIDecodeSwapChain*) thisVtbl.AsVtblPtr();
        MULTIPLANEOVERLAYYCbCrFLAGS ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS>)@this->LpVtbl[11])(@this);
        return ret;
    }

}
