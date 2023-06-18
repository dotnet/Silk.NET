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
    [Guid("458e1fd1-b1b2-4750-a6e1-9c10f03bed92")]
    [NativeName("Name", "IDxcValidator2")]
    public unsafe partial struct IDxcValidator2 : IComVtbl<IDxcValidator2>, IComVtbl<IDxcValidator>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("458e1fd1-b1b2-4750-a6e1-9c10f03bed92");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcValidator(IDxcValidator2 val)
            => Unsafe.As<IDxcValidator2, IDxcValidator>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcValidator2 val)
            => Unsafe.As<IDxcValidator2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcValidator2
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
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
            return ret;
        }

    }
}
