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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12
{
    [Guid("dc90f331-4740-43fa-866e-67f12cb58223")]
    [NativeName("Name", "ID3D11On12Device2")]
    public unsafe partial struct ID3D11On12Device2 : IComVtbl<ID3D11On12Device2>, IComVtbl<ID3D11On12Device1>, IComVtbl<ID3D11On12Device>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dc90f331-4740-43fa-866e-67f12cb58223");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11On12Device1(ID3D11On12Device2 val)
            => Unsafe.As<ID3D11On12Device2, ID3D11On12Device1>(ref val);

        public static implicit operator ID3D11On12Device(ID3D11On12Device2 val)
            => Unsafe.As<ID3D11On12Device2, ID3D11On12Device>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11On12Device2 val)
            => Unsafe.As<ID3D11On12Device2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11On12Device2
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
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResources, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AcquireWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResources, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetD3D12Device(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnwrapUnderlyingResource(ID3D11Resource* pResource11, Silk.NET.Direct3D12.ID3D12CommandQueue* pCommandQueue, Guid* riid, void** ppvResource12)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource*, Silk.NET.Direct3D12.ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pResource11, pCommandQueue, riid, ppvResource12);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReturnUnderlyingResource(ID3D11Resource* pResource11, uint NumSync, ulong* pSignalValues, Silk.NET.Direct3D12.ID3D12Fence** ppFences)
        {
            var @this = (ID3D11On12Device2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device2*, ID3D11Resource*, uint, ulong*, Silk.NET.Direct3D12.ID3D12Fence**, int>)@this->LpVtbl[8])(@this, pResource11, NumSync, pSignalValues, ppFences);
            return ret;
        }

    }
}
