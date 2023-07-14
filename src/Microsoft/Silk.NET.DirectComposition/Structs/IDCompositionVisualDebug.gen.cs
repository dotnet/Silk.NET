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

namespace Silk.NET.DirectComposition
{
    [Guid("fed2b808-5eb4-43a0-aea3-35f65280f91b")]
    [NativeName("Name", "IDCompositionVisualDebug")]
    public unsafe partial struct IDCompositionVisualDebug : IComVtbl<IDCompositionVisualDebug>, IComVtbl<IDCompositionVisual2>, IComVtbl<IDCompositionVisual>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fed2b808-5eb4-43a0-aea3-35f65280f91b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDCompositionVisual2(IDCompositionVisualDebug val)
            => Unsafe.As<IDCompositionVisualDebug, IDCompositionVisual2>(ref val);

        public static implicit operator IDCompositionVisual(IDCompositionVisualDebug val)
            => Unsafe.As<IDCompositionVisualDebug, IDCompositionVisual>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionVisualDebug val)
            => Unsafe.As<IDCompositionVisualDebug, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionVisualDebug
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOffsetX(float offsetX)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)@this->LpVtbl[4])(@this, offsetX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOffsetY(float offsetY)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)@this->LpVtbl[6])(@this, offsetY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform(Silk.NET.Maths.Matrix3X2<float>* matrix)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransform(ref Silk.NET.Maths.Matrix3X2<float> matrix)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* matrixPtr = &matrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransformParent(IDCompositionVisual* visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransformParent(ref IDCompositionVisual visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffect(IDCompositionEffect* effect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffect(ref IDCompositionEffect effect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionEffect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BitmapInterpolationMode, int>)@this->LpVtbl[11])(@this, interpolationMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBorderMode(BorderMode borderMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BorderMode, int>)@this->LpVtbl[12])(@this, borderMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClip(Silk.NET.Maths.Rectangle<float>* rect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClip(ref Silk.NET.Maths.Rectangle<float> rect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<float>* rectPtr = &rect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetContent(Silk.NET.Core.Native.IUnknown* content)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, content);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetContent(ref Silk.NET.Core.Native.IUnknown content)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* contentPtr = &content)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, contentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visualPtr, insertAbove, referenceVisual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVisual(ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visualPtr, insertAbove, referenceVisualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveVisual(IDCompositionVisual* visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveVisual(ref IDCompositionVisual visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAllVisuals()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompositeMode(CompositeMode compositeMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, CompositeMode, int>)@this->LpVtbl[19])(@this, compositeMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOpacityMode(OpacityMode mode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, OpacityMode, int>)@this->LpVtbl[20])(@this, mode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackFaceVisibility(BackfaceVisibility visibility)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BackfaceVisibility, int>)@this->LpVtbl[21])(@this, visibility);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableHeatMap(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[22])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableHeatMap(ref Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[22])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisableHeatMap()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableRedrawRegions()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisableRedrawRegions()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransformParent<TI0>(ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTransformParent((IDCompositionVisual*) visual.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffect<TI0>(ComPtr<TI0> effect) where TI0 : unmanaged, IComVtbl<IDCompositionEffect>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetEffect((IDCompositionEffect*) effect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetContent<TI0>(ComPtr<TI0> content) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetContent((Silk.NET.Core.Native.IUnknown*) content.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVisual<TI0, TI1>(ComPtr<TI0> visual, Silk.NET.Core.Bool32 insertAbove, ComPtr<TI1> referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI1>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddVisual((IDCompositionVisual*) visual.Handle, insertAbove, (IDCompositionVisual*) referenceVisual.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVisual<TI0>(ComPtr<TI0> visual, Silk.NET.Core.Bool32 insertAbove, ref IDCompositionVisual referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddVisual((IDCompositionVisual*) visual.Handle, insertAbove, ref referenceVisual);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVisual<TI0>(ref IDCompositionVisual visual, Silk.NET.Core.Bool32 insertAbove, ComPtr<TI0> referenceVisual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddVisual(ref visual, insertAbove, (IDCompositionVisual*) referenceVisual.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveVisual<TI0>(ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RemoveVisual((IDCompositionVisual*) visual.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
