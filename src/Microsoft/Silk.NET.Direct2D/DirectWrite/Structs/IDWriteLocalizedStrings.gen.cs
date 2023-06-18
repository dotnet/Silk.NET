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
    [Guid("08256209-099a-4b34-b86d-c22b110e7771")]
    [NativeName("Name", "IDWriteLocalizedStrings")]
    public unsafe partial struct IDWriteLocalizedStrings : IComVtbl<IDWriteLocalizedStrings>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("08256209-099a-4b34-b86d-c22b110e7771");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteLocalizedStrings val)
            => Unsafe.As<IDWriteLocalizedStrings, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteLocalizedStrings
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
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCount()
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindLocaleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint* index, int* exists)
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, index, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleNameLength(uint index, uint* length)
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[5])(@this, index, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint index, char* localeName, uint size)
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[6])(@this, index, localeName, size);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStringLength(uint index, uint* length)
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[7])(@this, index, length);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetString(uint index, char* stringBuffer, uint size)
        {
            var @this = (IDWriteLocalizedStrings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[8])(@this, index, stringBuffer, size);
            return ret;
        }

    }
}
