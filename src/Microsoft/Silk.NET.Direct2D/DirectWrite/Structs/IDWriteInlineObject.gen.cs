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

namespace Silk.NET.DirectWrite
{
    [Guid("8339fde3-106f-47ab-8373-1c6295eb10b3")]
    [NativeName("Name", "IDWriteInlineObject")]
    public unsafe partial struct IDWriteInlineObject : IComVtbl<IDWriteInlineObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8339fde3-106f-47ab-8373-1c6295eb10b3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteInlineObject val)
            => Unsafe.As<IDWriteInlineObject, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteInlineObject
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
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<T0>(ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<T0>(ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<T0>(ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (IDWriteTextRenderer* rendererPtr = &renderer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0>(ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (IDWriteTextRenderer* rendererPtr = &renderer)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* clientDrawingEffectPtr = &clientDrawingEffect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, rendererPtr, originX, originY, isSideways, isRightToLeft, clientDrawingEffectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetrics(InlineObjectMetrics* metrics)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, InlineObjectMetrics*, int>)@this->LpVtbl[4])(@this, metrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetrics(ref InlineObjectMetrics metrics)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InlineObjectMetrics* metricsPtr = &metrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, InlineObjectMetrics*, int>)@this->LpVtbl[4])(@this, metricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOverhangMetrics(OverhangMetrics* overhangs)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, OverhangMetrics*, int>)@this->LpVtbl[5])(@this, overhangs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOverhangMetrics(ref OverhangMetrics overhangs)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OverhangMetrics* overhangsPtr = &overhangs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, OverhangMetrics*, int>)@this->LpVtbl[5])(@this, overhangsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBreakConditions(BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBefore, breakConditionAfter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBreakConditions(BreakCondition* breakConditionBefore, ref BreakCondition breakConditionAfter)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BreakCondition* breakConditionAfterPtr = &breakConditionAfter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBefore, breakConditionAfterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBreakConditions(ref BreakCondition breakConditionBefore, BreakCondition* breakConditionAfter)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BreakCondition* breakConditionBeforePtr = &breakConditionBefore)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBeforePtr, breakConditionAfter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakConditions(ref BreakCondition breakConditionBefore, ref BreakCondition breakConditionAfter)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BreakCondition* breakConditionBeforePtr = &breakConditionBefore)
            {
                fixed (BreakCondition* breakConditionAfterPtr = &breakConditionAfter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBeforePtr, breakConditionAfterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<TI0, TI1>(void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<TI0>(void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<TI0>(void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(clientDrawingContext, ref renderer, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0, TI0, TI1>(ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI1> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0, TI0>(ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Core.Native.IUnknown clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY, isSideways, isRightToLeft, ref clientDrawingEffect);
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0, TI0>(ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ComPtr<TI0> clientDrawingEffect) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(ref clientDrawingContext, ref renderer, originX, originY, isSideways, isRightToLeft, (Silk.NET.Core.Native.IUnknown*) clientDrawingEffect.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
