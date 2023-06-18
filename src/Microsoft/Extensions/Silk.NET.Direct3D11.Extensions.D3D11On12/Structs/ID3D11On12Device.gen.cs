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
    [Guid("85611e73-70a9-490e-9614-a9e302777904")]
    [NativeName("Name", "ID3D11On12Device")]
    public unsafe partial struct ID3D11On12Device : IComVtbl<ID3D11On12Device>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("85611e73-70a9-490e-9614-a9e302777904");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11On12Device val)
            => Unsafe.As<ID3D11On12Device, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11On12Device
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
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResources, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AcquireWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResources, NumResources);
        }

    }
}
