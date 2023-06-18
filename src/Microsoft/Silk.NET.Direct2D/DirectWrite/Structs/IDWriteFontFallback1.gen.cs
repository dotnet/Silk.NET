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
    [Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77")]
    [NativeName("Name", "IDWriteFontFallback1")]
    public unsafe partial struct IDWriteFontFallback1 : IComVtbl<IDWriteFontFallback1>, IComVtbl<IDWriteFontFallback>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2397599d-dd0d-4681-bd6a-f4f31eaade77");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFallback(IDWriteFontFallback1 val)
            => Unsafe.As<IDWriteFontFallback1, IDWriteFontFallback>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFallback1 val)
            => Unsafe.As<IDWriteFontFallback1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFallback1
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
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            return ret;
        }

    }
}
