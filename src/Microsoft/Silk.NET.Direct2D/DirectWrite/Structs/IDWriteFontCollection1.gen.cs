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
    [Guid("53585141-d9f8-4095-8321-d73cf6bd116c")]
    [NativeName("Name", "IDWriteFontCollection1")]
    public unsafe partial struct IDWriteFontCollection1 : IComVtbl<IDWriteFontCollection1>, IComVtbl<IDWriteFontCollection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("53585141-d9f8-4095-8321-d73cf6bd116c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontCollection(IDWriteFontCollection1 val)
            => Unsafe.As<IDWriteFontCollection1, IDWriteFontCollection>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontCollection1 val)
            => Unsafe.As<IDWriteFontCollection1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontCollection1
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
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyCount()
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFontCollection1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, IDWriteFontSet**, int>)@this->LpVtbl[7])(@this, fontSet);
            return ret;
        }

    }
}
