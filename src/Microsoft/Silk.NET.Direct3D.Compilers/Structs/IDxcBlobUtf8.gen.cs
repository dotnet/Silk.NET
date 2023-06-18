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
    [Guid("3da636c9-ba71-4024-a301-30cbf125305b")]
    [NativeName("Name", "IDxcBlobUtf8")]
    public unsafe partial struct IDxcBlobUtf8 : IComVtbl<IDxcBlobUtf8>, IComVtbl<IDxcBlobEncoding>, IComVtbl<IDxcBlob>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3da636c9-ba71-4024-a301-30cbf125305b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcBlobEncoding(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, IDxcBlobEncoding>(ref val);

        public static implicit operator IDxcBlob(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, IDxcBlob>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcBlobUtf8
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
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetBufferPointer()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, void*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetBufferSize()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, nuint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetStringPointer()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, byte*>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetStringLength()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, nuint>)@this->LpVtbl[7])(@this);
            return ret;
        }

    }
}
