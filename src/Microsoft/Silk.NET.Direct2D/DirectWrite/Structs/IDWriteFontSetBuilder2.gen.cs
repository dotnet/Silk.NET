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
    [Guid("ee5ba612-b131-463c-8f4f-3189b9401e45")]
    [NativeName("Name", "IDWriteFontSetBuilder2")]
    public unsafe partial struct IDWriteFontSetBuilder2 : IComVtbl<IDWriteFontSetBuilder2>, IComVtbl<IDWriteFontSetBuilder1>, IComVtbl<IDWriteFontSetBuilder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ee5ba612-b131-463c-8f4f-3189b9401e45");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontSetBuilder1(IDWriteFontSetBuilder2 val)
            => Unsafe.As<IDWriteFontSetBuilder2, IDWriteFontSetBuilder1>(ref val);

        public static implicit operator IDWriteFontSetBuilder(IDWriteFontSetBuilder2 val)
            => Unsafe.As<IDWriteFontSetBuilder2, IDWriteFontSetBuilder>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontSetBuilder2 val)
            => Unsafe.As<IDWriteFontSetBuilder2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontSetBuilder2
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
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontSet(IDWriteFontSet* fontSet)
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFontFile(IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFont(IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
        {
            var @this = (IDWriteFontSetBuilder2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
            return ret;
        }

    }
}
