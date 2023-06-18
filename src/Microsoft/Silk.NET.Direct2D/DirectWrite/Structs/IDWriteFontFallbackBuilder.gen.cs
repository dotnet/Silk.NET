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
    [Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de")]
    [NativeName("Name", "IDWriteFontFallbackBuilder")]
    public unsafe partial struct IDWriteFontFallbackBuilder : IComVtbl<IDWriteFontFallbackBuilder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fd882d06-8aba-4fb8-b849-8be8b73e14de");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFallbackBuilder val)
            => Unsafe.As<IDWriteFontFallbackBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFallbackBuilder
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
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMappings(IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallback);
            return ret;
        }

    }
}
