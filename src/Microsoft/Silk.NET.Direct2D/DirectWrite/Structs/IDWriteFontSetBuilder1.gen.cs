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
    [Guid("3ff7715f-3cdc-4dc6-9b72-ec5621dccafd")]
    [NativeName("Name", "IDWriteFontSetBuilder1")]
    public unsafe partial struct IDWriteFontSetBuilder1 : IComVtbl<IDWriteFontSetBuilder1>, IComVtbl<IDWriteFontSetBuilder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3ff7715f-3cdc-4dc6-9b72-ec5621dccafd");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontSetBuilder(IDWriteFontSetBuilder1 val)
            => Unsafe.As<IDWriteFontSetBuilder1, IDWriteFontSetBuilder>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontSetBuilder1 val)
            => Unsafe.As<IDWriteFontSetBuilder1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontSetBuilder1
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
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontSet(IDWriteFontSet* fontSet)
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontFile(IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFontSetBuilder1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFile);
            return ret;
        }

    }
}
