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

namespace Silk.NET.Direct3D12
{
    [Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71")]
    [NativeName("Name", "ID3D12DeviceRemovedExtendedData")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedData : IComVtbl<ID3D12DeviceRemovedExtendedData>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("98931d33-5ae8-4791-aa3c-1a73a2934e71");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceRemovedExtendedData val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedData, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceRemovedExtendedData
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
            var @this = (ID3D12DeviceRemovedExtendedData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceRemovedExtendedData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceRemovedExtendedData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAutoBreadcrumbsOutput(DredAutoBreadcrumbsOutput* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPageFaultAllocationOutput(DredPageFaultOutput* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutput);
            return ret;
        }

    }
}
