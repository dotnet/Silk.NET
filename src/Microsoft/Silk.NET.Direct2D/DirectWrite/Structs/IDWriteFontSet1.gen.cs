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
    [Guid("7e9fda85-6c92-4053-bc47-7ae3530db4d3")]
    [NativeName("Name", "IDWriteFontSet1")]
    public unsafe partial struct IDWriteFontSet1 : IComVtbl<IDWriteFontSet1>, IComVtbl<IDWriteFontSet>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7e9fda85-6c92-4053-bc47-7ae3530db4d3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontSet(IDWriteFontSet1 val)
            => Unsafe.As<IDWriteFontSet1, IDWriteFontSet>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontSet1 val)
            => Unsafe.As<IDWriteFontSet1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontSet1
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
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontCount()
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, int* exists, IDWriteLocalizedStrings** values)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, values);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, uint* propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(uint listIndex, IDWriteFontResource** fontResource)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(uint listIndex, IDWriteFontFace5** fontFace)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetFontLocality(uint listIndex)
        {
            var @this = (IDWriteFontSet1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, Locality>)@this->LpVtbl[25])(@this, listIndex);
            return ret;
        }

    }
}
