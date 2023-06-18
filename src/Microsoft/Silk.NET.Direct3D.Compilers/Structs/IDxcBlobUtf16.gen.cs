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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("a3f84eab-0faa-497e-a39c-ee6ed60b2d84")]
    [NativeName("Name", "IDxcBlobUtf16")]
    public unsafe partial struct IDxcBlobUtf16 : IComVtbl<IDxcBlobUtf16>, IComVtbl<IDxcBlobEncoding>, IComVtbl<IDxcBlob>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a3f84eab-0faa-497e-a39c-ee6ed60b2d84");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcBlobEncoding(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, IDxcBlobEncoding>(ref val);

        public static implicit operator IDxcBlob(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, IDxcBlob>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcBlobUtf16
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
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetBufferPointer()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, void*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetBufferSize()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe char* GetStringPointer()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            char* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, char*>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetStringLength()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)@this->LpVtbl[7])(@this);
            return ret;
        }

    }
}
