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
    [Guid("4556be70-3abd-4f70-90be-421780a6f515")]
    [NativeName("Name", "IDWriteGdiInterop1")]
    public unsafe partial struct IDWriteGdiInterop1 : IComVtbl<IDWriteGdiInterop1>, IComVtbl<IDWriteGdiInterop>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4556be70-3abd-4f70-90be-421780a6f515");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteGdiInterop(IDWriteGdiInterop1 val)
            => Unsafe.As<IDWriteGdiInterop1, IDWriteGdiInterop>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteGdiInterop1 val)
            => Unsafe.As<IDWriteGdiInterop1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteGdiInterop1
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
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFont** font)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(IDWriteFont* font, void* logFont, int* isSystemFont)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT(IDWriteFontFace* font, void* logFont)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceFromHdc(nint hdc, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapRenderTarget(nint hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSignature(IDWriteFont* font, void* fontSignature)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, font, fontSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFontsByLOGFONT([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteGdiInterop1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSet, filteredSet);
            return ret;
        }

    }
}
