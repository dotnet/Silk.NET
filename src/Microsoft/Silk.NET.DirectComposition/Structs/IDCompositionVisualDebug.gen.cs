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
    [NativeName("Name", "IDCompositionVisualDebug")]
    public unsafe partial struct IDCompositionVisualDebug
    {
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
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOffsetX(float offsetX)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)LpVtbl[3])(@this, offsetX);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOffsetY(float offsetY)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)LpVtbl[4])(@this, offsetY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransform(Silk.NET.Maths.Matrix3X2<float>* matrix)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Matrix3X2<float>*, int>)LpVtbl[5])(@this, matrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransform(ref Silk.NET.Maths.Matrix3X2<float> matrix)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* matrixPtr = &matrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Matrix3X2<float>*, int>)LpVtbl[5])(@this, matrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTransformParent(IDCompositionVisual* visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)LpVtbl[6])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTransformParent(ref IDCompositionVisual visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)LpVtbl[6])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffect(IDCompositionEffect* effect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)LpVtbl[7])(@this, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffect(ref IDCompositionEffect effect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionEffect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)LpVtbl[7])(@this, effectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BitmapInterpolationMode, int>)LpVtbl[8])(@this, interpolationMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBorderMode(BorderMode borderMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BorderMode, int>)LpVtbl[9])(@this, borderMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClip(Silk.NET.Maths.Rectangle<float>* rect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[10])(@this, rect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClip(ref Silk.NET.Maths.Rectangle<float> rect)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<float>* rectPtr = &rect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Rectangle<float>*, int>)LpVtbl[10])(@this, rectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetContent(Silk.NET.Core.Native.IUnknown* content)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[11])(@this, content);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetContent(ref Silk.NET.Core.Native.IUnknown content)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* contentPtr = &content)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[11])(@this, contentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(IDCompositionVisual* visual, int insertAbove, IDCompositionVisual* referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int, IDCompositionVisual*, int>)LpVtbl[12])(@this, visual, insertAbove, referenceVisual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(IDCompositionVisual* visual, int insertAbove, ref IDCompositionVisual referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int, IDCompositionVisual*, int>)LpVtbl[12])(@this, visual, insertAbove, referenceVisualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVisual(ref IDCompositionVisual visual, int insertAbove, IDCompositionVisual* referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int, IDCompositionVisual*, int>)LpVtbl[12])(@this, visualPtr, insertAbove, referenceVisual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVisual(ref IDCompositionVisual visual, int insertAbove, ref IDCompositionVisual referenceVisual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                fixed (IDCompositionVisual* referenceVisualPtr = &referenceVisual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int, IDCompositionVisual*, int>)LpVtbl[12])(@this, visualPtr, insertAbove, referenceVisualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveVisual(IDCompositionVisual* visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)LpVtbl[13])(@this, visual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveVisual(ref IDCompositionVisual visual)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDCompositionVisual* visualPtr = &visual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)LpVtbl[13])(@this, visualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAllVisuals()
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompositeMode(CompositeMode compositeMode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, CompositeMode, int>)LpVtbl[15])(@this, compositeMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOpacityMode(OpacityMode mode)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, OpacityMode, int>)LpVtbl[16])(@this, mode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackFaceVisibility(BackfaceVisibility visibility)
        {
            var @this = (IDCompositionVisualDebug*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BackfaceVisibility, int>)LpVtbl[17])(@this, visibility);
            return ret;
        }

    }
}
