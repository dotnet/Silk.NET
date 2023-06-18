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
        public readonly unsafe int GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRanges, fontAxisRangeCount);
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
        public readonly unsafe int CreateFontFaceReference(FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
        {
            var @this = (IDWriteFontResource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
            return ret;
        }

    }
}
