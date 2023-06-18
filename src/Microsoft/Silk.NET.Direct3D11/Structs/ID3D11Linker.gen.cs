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

namespace Silk.NET.Direct3D11
{
    [Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e")]
    [NativeName("Name", "ID3D11Linker")]
    public unsafe partial struct ID3D11Linker : IComVtbl<ID3D11Linker>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Linker val)
            => Unsafe.As<ID3D11Linker, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Linker
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
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UseLibrary(ID3D11ModuleInstance* pLibraryMI)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMI);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)@this->LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
            return ret;
        }

    }
}
