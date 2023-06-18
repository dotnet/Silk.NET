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
    [Guid("1edd9491-9853-4299-898f-6432983b6f3a")]
    [NativeName("Name", "IDWriteGdiInterop")]
    public unsafe partial struct IDWriteGdiInterop : IComVtbl<IDWriteGdiInterop>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1edd9491-9853-4299-898f-6432983b6f3a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteGdiInterop val)
            => Unsafe.As<IDWriteGdiInterop, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteGdiInterop
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
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFont** font)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(IDWriteFont* font, void* logFont, int* isSystemFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT(IDWriteFontFace* font, void* logFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceFromHdc(nint hdc, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapRenderTarget(nint hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTarget);
            return ret;
        }

    }
}
