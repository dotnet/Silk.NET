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
    [Guid("53585141-d9f8-4095-8321-d73cf6bd116b")]
    [NativeName("Name", "IDWriteFontSet")]
    public unsafe partial struct IDWriteFontSet : IComVtbl<IDWriteFontSet>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("53585141-d9f8-4095-8321-d73cf6bd116b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontSet val)
            => Unsafe.As<IDWriteFontSet, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontSet
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
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontCount()
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(uint listIndex, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFaceReference(ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(IDWriteFontFace* fontFace, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, uint* listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, uint* listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace(ref IDWriteFontFace fontFace, ref uint listIndex, int* exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFace(ref IDWriteFontFace fontFace, ref uint listIndex, ref int exists)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* listIndexPtr = &listIndex)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, int* exists, IDWriteLocalizedStrings** values)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, values);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, int* exists, ref IDWriteLocalizedStrings* values)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** valuesPtr = &values)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, valuesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, ref int exists, IDWriteLocalizedStrings** values)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, values);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues(uint listIndex, FontPropertyID propertyId, ref int exists, ref IDWriteLocalizedStrings* values)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                fixed (IDWriteLocalizedStrings** valuesPtr = &values)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, valuesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, uint* propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, ref uint propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty property, uint* propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertyPtr = &property)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyOccurrenceCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty property, ref uint propertyOccurrenceCount)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertyPtr = &property)
            {
                fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, IDWriteFontSet** filteredSet)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontProperty* propertiesPtr = &properties)
            {
                fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFaceReference<TI0>(uint listIndex, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFaceReference(listIndex, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFaceReference<TI0>(ComPtr<TI0> fontFaceReference, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFontFace<TI0>(ComPtr<TI0> fontFace, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFontFace<TI0>(ComPtr<TI0> fontFace, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyValues<TI0>(uint listIndex, FontPropertyID propertyId, int* exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPropertyValues(listIndex, propertyId, exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyValues<TI0>(uint listIndex, FontPropertyID propertyId, ref int exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPropertyValues(listIndex, propertyId, ref exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMatchingFonts(properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMatchingFonts<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMatchingFonts(in properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontSet*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
