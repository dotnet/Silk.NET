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
    [Guid("bc66d368-7373-4943-8757-fc87dc79e476")]
    [NativeName("Name", "ID3D12VirtualizationGuestDevice")]
    public unsafe partial struct ID3D12VirtualizationGuestDevice : IComVtbl<ID3D12VirtualizationGuestDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bc66d368-7373-4943-8757-fc87dc79e476");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VirtualizationGuestDevice val)
            => Unsafe.As<ID3D12VirtualizationGuestDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VirtualizationGuestDevice
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
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ShareWithHost(ID3D12DeviceChild* pObject, void** pHandle)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObject, pHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFenceFd(ID3D12Fence* pFence, ulong FenceValue, int* pFenceFd)
        {
            var @this = (ID3D12VirtualizationGuestDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFence, FenceValue, pFenceFd);
            return ret;
        }

    }
}
