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

public unsafe static class DCompositionVisualVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetX(this ComPtr<IDCompositionVisual> thisVtbl, float offsetX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)@this->LpVtbl[4])(@this, offsetX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetY(this ComPtr<IDCompositionVisual> thisVtbl, float offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)@this->LpVtbl[6])(@this, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<IDCompositionVisual> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* matrixPtr = &matrix)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransformParent(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransformParent(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionVisual visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual* visualPtr = &visual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffect(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionEffect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEffect(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionEffect effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionEffect* effectPtr = &effect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBitmapInterpolationMode(this ComPtr<IDCompositionVisual> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BitmapInterpolationMode, int>)@this->LpVtbl[11])(@this, interpolationMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBorderMode(this ComPtr<IDCompositionVisual> thisVtbl, BorderMode borderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BorderMode, int>)@this->LpVtbl[12])(@this, borderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClip(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Maths.Rectangle<float>* rect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClip(this ComPtr<IDCompositionVisual> thisVtbl, ref Silk.NET.Maths.Rectangle<float> rect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<float>* rectPtr = &rect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetContent(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Core.Native.IUnknown* content)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, content);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetContent(this ComPtr<IDCompositionVisual> thisVtbl, ref Silk.NET.Core.Native.IUnknown content)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* contentPtr = &content)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, contentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual* visualPtr = &visual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visualPtr, insertAbove, referenceVisual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual* visualPtr = &visual)
        {
            fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visualPtr, insertAbove, referenceVisualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveVisual(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionVisual visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual* visualPtr = &visual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllVisuals(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, int>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCompositeMode(this ComPtr<IDCompositionVisual> thisVtbl, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, CompositeMode, int>)@this->LpVtbl[19])(@this, compositeMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<IDCompositionVisual> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> matrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTransform(ref matrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTransformParent<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetTransformParent((IDCompositionVisual*) visual.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetTransformParent(this ComPtr<IDCompositionVisual> thisVtbl, Span<IDCompositionVisual> visual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTransformParent(ref visual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetEffect<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<IDCompositionEffect>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetEffect((IDCompositionEffect*) effect.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetEffect(this ComPtr<IDCompositionVisual> thisVtbl, Span<IDCompositionEffect> effect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEffect(ref effect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClip(this ComPtr<IDCompositionVisual> thisVtbl, Span<Silk.NET.Maths.Rectangle<float>> rect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetClip(ref rect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetContent<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> content) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetContent((Silk.NET.Core.Native.IUnknown*) content.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetContent(this ComPtr<IDCompositionVisual> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> content)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetContent(ref content.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddVisual<TI0, TI1>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> visual, Silk.NET.Core.Bool32 insertAbove, ComPtr<TI1> referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddVisual((IDCompositionVisual*) visual.Handle, insertAbove, (IDCompositionVisual*) referenceVisual.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, Span<IDCompositionVisual> referenceVisual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddVisual(visual, insertAbove, ref referenceVisual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddVisual<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddVisual((IDCompositionVisual*) visual.Handle, insertAbove, ref referenceVisual);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, Span<IDCompositionVisual> visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddVisual(ref visual.GetPinnableReference(), insertAbove, referenceVisual);
    }

    /// <summary>To be documented.</summary>
    public static int AddVisual<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, ComPtr<TI0> referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddVisual(ref visual, insertAbove, (IDCompositionVisual*) referenceVisual.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, Span<IDCompositionVisual> visual, Silk.NET.Core.Bool32 insertAbove, Span<IDCompositionVisual> referenceVisual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddVisual(ref visual.GetPinnableReference(), insertAbove, ref referenceVisual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveVisual<TI0>(this ComPtr<IDCompositionVisual> thisVtbl, ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveVisual((IDCompositionVisual*) visual.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveVisual(this ComPtr<IDCompositionVisual> thisVtbl, Span<IDCompositionVisual> visual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveVisual(ref visual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionVisual> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
