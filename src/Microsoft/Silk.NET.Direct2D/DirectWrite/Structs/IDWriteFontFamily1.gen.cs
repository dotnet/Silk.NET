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
    [Guid("da20d8ef-812a-4c43-9802-62ec4abd7adf")]
    [NativeName("Name", "IDWriteFontFamily1")]
    public unsafe partial struct IDWriteFontFamily1 : IComVtbl<IDWriteFontFamily1>, IComVtbl<IDWriteFontFamily>, IComVtbl<IDWriteFontList>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("da20d8ef-812a-4c43-9802-62ec4abd7adf");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFamily(IDWriteFontFamily1 val)
            => Unsafe.As<IDWriteFontFamily1, IDWriteFontFamily>(ref val);

        public static implicit operator IDWriteFontList(IDWriteFontFamily1 val)
            => Unsafe.As<IDWriteFontFamily1, IDWriteFontList>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFamily1 val)
            => Unsafe.As<IDWriteFontFamily1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFamily1
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
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontCount()
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFont(uint index, IDWriteFont** font)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFont(uint index, ref IDWriteFont* font)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, fontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFamilyNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFamilyNames(ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFirstMatchingFont(FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFont** matchingFont)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFirstMatchingFont(FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFont* matchingFont)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** matchingFontPtr = &matchingFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts(FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFontList** matchingFonts)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFonts);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts(FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFontList* matchingFonts)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontList** matchingFontsPtr = &matchingFonts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFontsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetFontLocality(uint listIndex)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, Locality>)@this->LpVtbl[9])(@this, listIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[11])(@this, listIndex, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily1*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[11])(@this, listIndex, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontCollection<TI0>(ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFont<TI0>(uint index, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFont(index, (IDWriteFont**) font.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFamilyNames<TI0>(ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFamilyNames((IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFirstMatchingFont<TI0>(FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFirstMatchingFont(weight, stretch, style, (IDWriteFont**) matchingFont.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMatchingFonts<TI0>(FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFonts) where TI0 : unmanaged, IComVtbl<IDWriteFontList>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMatchingFonts(weight, stretch, style, (IDWriteFontList**) matchingFonts.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFaceReference<TI0>(uint listIndex, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFaceReference(listIndex, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFamily1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
