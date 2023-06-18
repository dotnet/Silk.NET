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

public unsafe static class DCompositionVirtualSurfaceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVirtualSurface> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionVirtualSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionVirtualSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionVirtualSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<IDCompositionVirtualSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SuspendDraw(this ComPtr<IDCompositionVirtualSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResumeDraw(this ComPtr<IDCompositionVirtualSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionVirtualSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRect, clipRect, offsetX, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Resize(this ComPtr<IDCompositionVirtualSurface> thisVtbl, uint width, uint height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint, uint, int>)@this->LpVtbl[8])(@this, width, height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Trim(this ComPtr<IDCompositionVirtualSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* rectangles, uint count)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[9])(@this, rectangles, count);
        return ret;
    }

}
