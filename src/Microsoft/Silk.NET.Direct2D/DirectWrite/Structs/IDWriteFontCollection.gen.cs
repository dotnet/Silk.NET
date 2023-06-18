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
    [Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc")]
    [NativeName("Name", "IDWriteFontCollection")]
    public unsafe partial struct IDWriteFontCollection : IComVtbl<IDWriteFontCollection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a84cee02-3eea-4eee-a827-87c1a02a0fcc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontCollection val)
            => Unsafe.As<IDWriteFontCollection, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontCollection
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
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyCount()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
            return ret;
        }

    }
}
