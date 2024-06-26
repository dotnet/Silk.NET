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
    [Guid("1f803a76-6871-48e8-987f-b975551c50f2")]
    [NativeName("Name", "IDWriteFontResource")]
    public unsafe partial struct IDWriteFontResource : IComVtbl<IDWriteFontResource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1f803a76-6871-48e8-987f-b975551c50f2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontResource val)
            => Unsafe.As<IDWriteFontResource, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontResource
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
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFile(IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)@this->LpVtbl[3])(@this, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFile(ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)@this->LpVtbl[3])(@this, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFaceIndex()
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontAxisCount()
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefaultFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)@this->LpVtbl[6])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefaultFontAxisValues(ref FontAxisValue fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)@this->LpVtbl[6])(@this, fontAxisValuesPtr, fontAxisValueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRanges, fontAxisRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontAxisRanges(ref FontAxisRange fontAxisRanges, uint fontAxisRangeCount)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRangesPtr, fontAxisRangeCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontAxisAttributes GetFontAxisAttributes(uint axisIndex)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontAxisAttributes ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, FontAxisAttributes>)@this->LpVtbl[8])(@this, axisIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisNames(uint axisIndex, IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, axisIndex, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisNames(uint axisIndex, ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, axisIndex, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAxisValueNameCount(uint axisIndex)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint>)@this->LpVtbl[10])(@this, axisIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisValueNames(uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRange, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisValueNames(uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRange, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisValueNames(uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisRange* fontAxisRangePtr = &fontAxisRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRangePtr, names);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisValueNames(uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisRange* fontAxisRangePtr = &fontAxisRange)
            {
                fixed (IDWriteLocalizedStrings** namesPtr = &names)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRangePtr, namesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVariations()
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Silk.NET.Core.Bool32>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFace5* fontFace)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFace);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFace5* fontFace)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFaceReference1* fontFaceReference)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference1** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFaceReference);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFaceReference1* fontFaceReference)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (IDWriteFontFaceReference1** fontFaceReferencePtr = &fontFaceReference)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFaceReferencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFile<TI0>(ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFile((IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAxisNames<TI0>(uint axisIndex, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAxisNames(axisIndex, (IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAxisValueNames<TI0>(uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAxisValueNames(axisIndex, axisValueIndex, fontAxisRange, (IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAxisValueNames<TI0>(uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetAxisValueNames(axisIndex, axisValueIndex, ref fontAxisRange, (IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace<TI0>(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontSimulations, fontAxisValues, fontAxisValueCount, (IDWriteFontFace5**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0>(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontSimulations, in fontAxisValues, fontAxisValueCount, (IDWriteFontFace5**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference<TI0>(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(fontSimulations, fontAxisValues, fontAxisValueCount, (IDWriteFontFaceReference1**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFaceReference<TI0>(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(fontSimulations, in fontAxisValues, fontAxisValueCount, (IDWriteFontFaceReference1**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
