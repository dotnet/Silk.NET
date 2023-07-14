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
    [Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944")]
    [NativeName("Name", "IDWriteFont2")]
    public unsafe partial struct IDWriteFont2 : IComVtbl<IDWriteFont2>, IComVtbl<IDWriteFont1>, IComVtbl<IDWriteFont>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("29748ed6-8c9c-4a6a-be0b-d912e8538944");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFont1(IDWriteFont2 val)
            => Unsafe.As<IDWriteFont2, IDWriteFont1>(ref val);

        public static implicit operator IDWriteFont(IDWriteFont2 val)
            => Unsafe.As<IDWriteFont2, IDWriteFont>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFont2 val)
            => Unsafe.As<IDWriteFont2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFont2
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
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(IDWriteFontFamily** fontFamily)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFamily**, int>)@this->LpVtbl[3])(@this, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(ref IDWriteFontFamily* fontFamily)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFamily** fontFamilyPtr = &fontFamily)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFamily**, int>)@this->LpVtbl[3])(@this, fontFamilyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetWeight()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontWeight>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetStretch()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStretch>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetStyle()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStyle>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSymbolFont()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFaceNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[8])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFaceNames(ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[8])(@this, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStrings, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, ref int exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStrings, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, int* exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStringsPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, ref int exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[9])(@this, informationalStringID, informationalStringsPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontSimulations>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetMetrics(FontMetrics* fontMetrics)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics*, void>)@this->LpVtbl[11])(@this, fontMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetMetrics(ref FontMetrics fontMetrics)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FontMetrics* fontMetricsPtr = &fontMetrics)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics*, void>)@this->LpVtbl[11])(@this, fontMetricsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HasCharacter(uint unicodeValue, int* exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, int*, int>)@this->LpVtbl[12])(@this, unicodeValue, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HasCharacter(uint unicodeValue, ref int exists)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, int*, int>)@this->LpVtbl[12])(@this, unicodeValue, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFace**, int>)@this->LpVtbl[13])(@this, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFace**, int>)@this->LpVtbl[13])(@this, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPanose(Panose* panose)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Panose*, void>)@this->LpVtbl[15])(@this, panose);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetPanose(ref Panose panose)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Panose* panosePtr = &panose)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Panose*, void>)@this->LpVtbl[15])(@this, panosePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                fixed (uint* actualRangeCountPtr = &actualRangeCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[16])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMonospacedFont()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsColorFont()
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Silk.NET.Core.Bool32>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamily<TI0>(ref ComPtr<TI0> fontFamily) where TI0 : unmanaged, IComVtbl<IDWriteFontFamily>, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFamily((IDWriteFontFamily**) fontFamily.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFaceNames<TI0>(ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFaceNames((IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings<TI0>(InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInformationalStrings<TI0>(InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0>(ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace((IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFont2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
