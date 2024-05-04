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

public unsafe static class DCompositionSurfaceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffsetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** updateObjectPtr = &updateObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** updateObjectPtr = &updateObject)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** updateObjectPtr = &updateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** updateObjectPtr = &updateObject)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffsetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (void** updateObjectPtr = &updateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (void** updateObjectPtr = &updateObject)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffsetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffsetPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<IDCompositionSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SuspendDraw(this ComPtr<IDCompositionSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResumeDraw(this ComPtr<IDCompositionSurface> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRect, clipRect, offsetX, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* clipRectPtr = &clipRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRect, clipRectPtr, offsetX, offsetY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* scrollRectPtr = &scrollRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRectPtr, clipRect, offsetX, offsetY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* scrollRectPtr = &scrollRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* clipRectPtr = &clipRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRectPtr, clipRectPtr, offsetX, offsetY);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionSurface> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionSurface> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw<TI0>(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref ComPtr<TI0> updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDraw(updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, iid, updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw<TI0>(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref ComPtr<TI0> updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDraw(updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), ref updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, ref void* updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, iid, ref updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Span<Guid> iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, ref iid.GetPinnableReference(), updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Span<Guid> iid, void** updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, ref iid.GetPinnableReference(), updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Span<Guid> iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, ref iid.GetPinnableReference(), ref updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Span<Guid> iid, ref void* updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(updateRect, ref iid.GetPinnableReference(), ref updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), iid, updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw<TI0>(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref ComPtr<TI0> updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDraw(in updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Guid* iid, void** updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), iid, updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BeginDraw<TI0>(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> updateRect, ref ComPtr<TI0> updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginDraw(in updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), ref updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), iid, ref updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Guid* iid, ref void* updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), iid, ref updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Span<Guid> iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), ref iid.GetPinnableReference(), updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Span<Guid> iid, void** updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), ref iid.GetPinnableReference(), updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Span<Guid> iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), ref iid.GetPinnableReference(), ref updateObject, updateOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginDraw(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> updateRect, Span<Guid> iid, ref void* updateObject, Span<Silk.NET.Maths.Vector2D<int>> updateOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginDraw(in updateRect.GetPinnableReference(), ref iid.GetPinnableReference(), ref updateObject, ref updateOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Scroll(scrollRect, in clipRect.GetPinnableReference(), offsetX, offsetY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Scroll(in scrollRect.GetPinnableReference(), clipRect, offsetX, offsetY);
    }

    /// <summary>To be documented.</summary>
    public static int Scroll(this ComPtr<IDCompositionSurface> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> clipRect, int offsetX, int offsetY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Scroll(in scrollRect.GetPinnableReference(), in clipRect.GetPinnableReference(), offsetX, offsetY);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionSurface> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
