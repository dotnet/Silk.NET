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
    [Guid("cfee3140-1157-47ca-8b85-31bfcf3f2d0e")]
    [NativeName("Name", "IDWriteStringList")]
    public unsafe partial struct IDWriteStringList : IComVtbl<IDWriteStringList>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("cfee3140-1157-47ca-8b85-31bfcf3f2d0e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteStringList val)
            => Unsafe.As<IDWriteStringList, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteStringList
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
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCount()
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleNameLength(uint listIndex, uint* length)
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[4])(@this, listIndex, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint listIndex, char* localeName, uint size)
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, listIndex, localeName, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStringLength(uint listIndex, uint* length)
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)@this->LpVtbl[6])(@this, listIndex, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetString(uint listIndex, char* stringBuffer, uint stringBufferSize)
        {
            var @this = (IDWriteStringList*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, char*, uint, int>)@this->LpVtbl[7])(@this, listIndex, stringBuffer, stringBufferSize);
            return ret;
        }

    }
}
