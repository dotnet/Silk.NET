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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe int GetFontFaceReference(uint listIndex, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReferencePtr);
            }
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
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, existsPtr);
                    }
                }
            }
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
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFace(ref IDWriteFontFace fontFace, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, existsPtr);
                    }
                }
            }
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
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, int* exists, ref IDWriteLocalizedStrings* values)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** valuesPtr = &values)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, valuesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, ref int exists, IDWriteLocalizedStrings** values)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, values);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, ref int exists, ref IDWriteLocalizedStrings* values)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                fixed (IDWriteLocalizedStrings** valuesPtr = &values)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, valuesPtr);
                }
            }
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
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, ref uint propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty property, uint* propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertyPtr = &property)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty property, ref uint propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertyPtr = &property)
            {
                fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCountPtr);
                }
            }
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
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSetPtr);
                }
            }
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
        public readonly unsafe int GetFirstFontResources(ref IDWriteFontSet1* filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSetPtr);
            }
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
        public readonly unsafe int GetFilteredFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref IDWriteFontSet1* filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, propertiesPtr, propertyCount, selectAnyProperty, filteredFontSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref IDWriteFontSet1* filteredFontSet)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, propertiesPtr, propertyCount, selectAnyProperty, filteredFontSetPtr);
                }
            }
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
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, ref uint actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualIndexCountPtr = &actualIndexCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, uint* actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* indicesPtr = &indices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, ref uint actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* indicesPtr = &indices)
            {
                fixed (uint* actualIndexCountPtr = &actualIndexCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, ref uint actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (uint* actualIndexCountPtr = &actualIndexCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, uint* actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (uint* indicesPtr = &indices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilteredFontIndices([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, ref uint actualIndexCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (uint* indicesPtr = &indices)
                {
                    fixed (uint* actualIndexCountPtr = &actualIndexCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCountPtr);
                    }
                }
            }
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
        public readonly unsafe int GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, ref uint actualFontAxisRangeCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualFontAxisRangeCountPtr = &actualFontAxisRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisRanges(ref FontAxisRange fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRangesPtr, maxFontAxisRangeCount, actualFontAxisRangeCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontAxisRanges(ref FontAxisRange fontAxisRanges, uint maxFontAxisRangeCount, ref uint actualFontAxisRangeCount)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                fixed (uint* actualFontAxisRangeCountPtr = &actualFontAxisRangeCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRangesPtr, maxFontAxisRangeCount, actualFontAxisRangeCountPtr);
                }
            }
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
        public readonly unsafe int CreateFontResource(uint listIndex, ref IDWriteFontResource* fontResource)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontResource** fontResourcePtr = &fontResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResourcePtr);
            }
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
        public readonly unsafe int CreateFontFace(uint listIndex, ref IDWriteFontFace5* fontFace)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFacePtr);
            }
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

        /// <summary>To be documented.</summary>
        public readonly int GetFontSourceName(uint listIndex, ref char stringBuffer, uint stringBufferSize)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* stringBufferPtr = &stringBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, char*, uint, int>)@this->LpVtbl[29])(@this, listIndex, stringBufferPtr, stringBufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontSourceName(uint listIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string stringBuffer, uint stringBufferSize)
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var stringBufferPtr = (byte*) SilkMarshal.StringToPtr(stringBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet3*, uint, byte*, uint, int>)@this->LpVtbl[29])(@this, listIndex, stringBufferPtr, stringBufferSize);
            SilkMarshal.Free((nint)stringBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFaceReference<TI0>(uint listIndex, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFaceReference(listIndex, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFace<TI0>(ComPtr<TI0> fontFace, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues<TI0>(uint listIndex, FontPropertyID propertyId, int* exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPropertyValues(listIndex, propertyId, exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyValues<TI0>(uint listIndex, FontPropertyID propertyId, ref int exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPropertyValues(listIndex, propertyId, ref exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMatchingFonts(properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMatchingFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMatchingFonts(in properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFirstFontResources<TI0>(ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFirstFontResources((IDWriteFontSet1**) filteredFontSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilteredFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFilteredFonts(properties, propertyCount, selectAnyProperty, (IDWriteFontSet1**) filteredFontSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilteredFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFilteredFonts(in properties, propertyCount, selectAnyProperty, (IDWriteFontSet1**) filteredFontSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontResource<TI0>(uint listIndex, ref ComPtr<TI0> fontResource) where TI0 : unmanaged, IComVtbl<IDWriteFontResource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontResource(listIndex, (IDWriteFontResource**) fontResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0>(uint listIndex, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(listIndex, (IDWriteFontFace5**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
