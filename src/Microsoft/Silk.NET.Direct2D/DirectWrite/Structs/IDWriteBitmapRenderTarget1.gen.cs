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
    [Guid("791e8298-3ef3-4230-9880-c9bdecc42064")]
    [NativeName("Name", "IDWriteBitmapRenderTarget1")]
    public unsafe partial struct IDWriteBitmapRenderTarget1 : IComVtbl<IDWriteBitmapRenderTarget1>, IComVtbl<IDWriteBitmapRenderTarget>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("791e8298-3ef3-4230-9880-c9bdecc42064");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteBitmapRenderTarget(IDWriteBitmapRenderTarget1 val)
            => Unsafe.As<IDWriteBitmapRenderTarget1, IDWriteBitmapRenderTarget>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteBitmapRenderTarget1 val)
            => Unsafe.As<IDWriteBitmapRenderTarget1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteBitmapRenderTarget1
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
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nint GetMemoryDC()
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, nint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetPixelsPerDip()
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelsPerDip(float pixelsPerDip)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float, int>)@this->LpVtbl[6])(@this, pixelsPerDip);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(Matrix* transform)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Matrix*, int>)@this->LpVtbl[7])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCurrentTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Matrix*, int>)@this->LpVtbl[8])(@this, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(Silk.NET.Maths.Vector2D<int>* size)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Resize(uint width, uint height)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint, uint, int>)@this->LpVtbl[10])(@this, width, height);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TextAntialiasMode GetTextAntialiasMode()
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAntialiasMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, TextAntialiasMode>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAntialiasMode(TextAntialiasMode antialiasMode)
        {
            var @this = (IDWriteBitmapRenderTarget1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, TextAntialiasMode, int>)@this->LpVtbl[12])(@this, antialiasMode);
            return ret;
        }

    }
}
