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
    [Guid("7c073ef2-a7f4-4045-8c32-8ab8ae640f90")]
    [NativeName("Name", "IDWriteFontSet3")]
    public unsafe partial struct IDWriteFontSet3 : IComVtbl<IDWriteFontSet3>, IComVtbl<IDWriteFontSet2>, IComVtbl<IDWriteFontSet1>, IComVtbl<IDWriteFontSet>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7c073ef2-a7f4-4045-8c32-8ab8ae640f90");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontSet2(IDWriteFontSet3 val)
            => Unsafe.As<IDWriteFontSet3, IDWriteFontSet2>(ref val);

        public static implicit operator IDWriteFontSet1(IDWriteFontSet3 val)
            => Unsafe.As<IDWriteFontSet3, IDWriteFontSet1>(ref val);

        public static implicit operator IDWriteFontSet(IDWriteFontSet3 val)
            => Unsafe.As<IDWriteFontSet3, IDWriteFontSet>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontSet3 val)
            => Unsafe.As<IDWriteFontSet3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontSet3
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
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontCount()
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, int* exists, IDWriteLocalizedStrings** values)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, values);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, uint* propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(uint listIndex, IDWriteFontResource** fontResource)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(uint listIndex, IDWriteFontFace5** fontFace)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetFontLocality(uint listIndex)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, Locality>)@this->LpVtbl[25])(@this, listIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetExpirationEvent()
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, void*>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSourceType GetFontSourceType(uint fontIndex)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSourceType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, FontSourceType>)@this->LpVtbl[27])(@this, fontIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontSourceNameLength(uint listIndex)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, uint>)@this->LpVtbl[28])(@this, listIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSourceName(uint listIndex, char* stringBuffer, uint stringBufferSize)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, char*, uint, int>)@this->LpVtbl[29])(@this, listIndex, stringBuffer, stringBufferSize);
            return ret;
        }

    }
}
