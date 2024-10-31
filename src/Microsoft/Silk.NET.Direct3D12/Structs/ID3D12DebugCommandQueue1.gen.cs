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
    [Guid("16be35a2-bfd6-49f2-bcae-eaae4aff862d")]
    [NativeName("Name", "ID3D12DebugCommandQueue1")]
    public unsafe partial struct ID3D12DebugCommandQueue1 : IComVtbl<ID3D12DebugCommandQueue1>, IComVtbl<ID3D12DebugCommandQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("16be35a2-bfd6-49f2-bcae-eaae4aff862d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12DebugCommandQueue(ID3D12DebugCommandQueue1 val)
            => Unsafe.As<ID3D12DebugCommandQueue1, ID3D12DebugCommandQueue>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DebugCommandQueue1 val)
            => Unsafe.As<ID3D12DebugCommandQueue1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DebugCommandQueue1
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
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this, pResource, Subresource, State);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 AssertResourceState(ref ID3D12Resource pResource, uint Subresource, uint State)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, State);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AssertResourceAccess(ID3D12Resource* pResource, uint Subresource, BarrierAccess Access)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierAccess, void>)@this->LpVtbl[4])(@this, pResource, Subresource, Access);
        }

        /// <summary>To be documented.</summary>
        public readonly void AssertResourceAccess(ref ID3D12Resource pResource, uint Subresource, BarrierAccess Access)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierAccess, void>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, Access);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AssertTextureLayout(ID3D12Resource* pResource, uint Subresource, BarrierLayout Layout)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierLayout, void>)@this->LpVtbl[5])(@this, pResource, Subresource, Layout);
        }

        /// <summary>To be documented.</summary>
        public readonly void AssertTextureLayout(ref ID3D12Resource pResource, uint Subresource, BarrierLayout Layout)
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue1*, ID3D12Resource*, uint, BarrierLayout, void>)@this->LpVtbl[5])(@this, pResourcePtr, Subresource, Layout);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 AssertResourceState<TI0>(ComPtr<TI0> pResource, uint Subresource, uint State) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AssertResourceState((ID3D12Resource*) pResource.Handle, Subresource, State);
        }

        /// <summary>To be documented.</summary>
        public readonly void AssertResourceAccess<TI0>(ComPtr<TI0> pResource, uint Subresource, BarrierAccess Access) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AssertResourceAccess((ID3D12Resource*) pResource.Handle, Subresource, Access);
        }

        /// <summary>To be documented.</summary>
        public readonly void AssertTextureLayout<TI0>(ComPtr<TI0> pResource, uint Subresource, BarrierLayout Layout) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AssertTextureLayout((ID3D12Resource*) pResource.Handle, Subresource, Layout);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DebugCommandQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
