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
    [Guid("514039c6-4617-4064-bf8b-92ea83e506e0")]
    [NativeName("Name", "IDWriteFontCollection2")]
    public unsafe partial struct IDWriteFontCollection2 : IComVtbl<IDWriteFontCollection2>, IComVtbl<IDWriteFontCollection1>, IComVtbl<IDWriteFontCollection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("514039c6-4617-4064-bf8b-92ea83e506e0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontCollection1(IDWriteFontCollection2 val)
            => Unsafe.As<IDWriteFontCollection2, IDWriteFontCollection1>(ref val);

        public static implicit operator IDWriteFontCollection(IDWriteFontCollection2 val)
            => Unsafe.As<IDWriteFontCollection2, IDWriteFontCollection>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontCollection2 val)
            => Unsafe.As<IDWriteFontCollection2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontCollection2
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
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyCount()
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontSet**, int>)@this->LpVtbl[7])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatchingFonts([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValues, fontAxisValueCount, fontList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontFamilyModel GetFontFamilyModel()
        {
            var @this = (IDWriteFontCollection2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontFamilyModel ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, FontFamilyModel>)@this->LpVtbl[11])(@this);
            return ret;
        }

    }
}
