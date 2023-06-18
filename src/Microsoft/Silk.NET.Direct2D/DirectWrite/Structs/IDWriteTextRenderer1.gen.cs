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
    [Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1")]
    [NativeName("Name", "IDWriteTextRenderer1")]
    public unsafe partial struct IDWriteTextRenderer1 : IComVtbl<IDWriteTextRenderer1>, IComVtbl<IDWriteTextRenderer>, IComVtbl<IDWritePixelSnapping>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d3e0e934-22a0-427e-aae4-7d9574b59db1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextRenderer(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, IDWriteTextRenderer>(ref val);

        public static implicit operator IDWritePixelSnapping(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, IDWritePixelSnapping>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextRenderer1 val)
            => Unsafe.As<IDWriteTextRenderer1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextRenderer1
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
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, int* isDisabled)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
        {
            var @this = (IDWriteTextRenderer1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
            return ret;
        }

    }
}
