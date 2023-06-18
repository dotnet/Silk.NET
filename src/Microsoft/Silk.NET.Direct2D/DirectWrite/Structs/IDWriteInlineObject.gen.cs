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
        public readonly unsafe int GetMetrics(InlineObjectMetrics* metrics)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, InlineObjectMetrics*, int>)@this->LpVtbl[4])(@this, metrics);
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
        public readonly unsafe int GetBreakConditions(BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter)
        {
            var @this = (IDWriteInlineObject*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)@this->LpVtbl[6])(@this, breakConditionBefore, breakConditionAfter);
            return ret;
        }

    }
}
