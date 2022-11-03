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
    [Guid("0adf7d52-929c-4e61-addb-ffed30de66ef")]
    [NativeName("Name", "ID3D12SharingContract")]
    public unsafe partial struct ID3D12SharingContract : IComVtbl<ID3D12SharingContract>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0adf7d52-929c-4e61-addb-ffed30de66ef");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12SharingContract val)
            => Unsafe.As<ID3D12SharingContract, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12SharingContract
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
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Present(ID3D12Resource* pResource, uint Subresource, nint window)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResource, Subresource, window);
        }

        /// <summary>To be documented.</summary>
        public readonly void Present(ref ID3D12Resource pResource, uint Subresource, nint window)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)@this->LpVtbl[3])(@this, pResourcePtr, Subresource, window);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFence, FenceValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void SharedFenceSignal(ref ID3D12Fence pFence, ulong FenceValue)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Fence* pFencePtr = &pFence)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginCapturableWork(Guid* guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guid);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginCapturableWork(ref Guid guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* guidPtr = &guid)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[5])(@this, guidPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndCapturableWork(Guid* guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guid);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndCapturableWork(ref Guid guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* guidPtr = &guid)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)@this->LpVtbl[6])(@this, guidPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void Present<TI0>(ComPtr<TI0> pResource, uint Subresource, nint window) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->Present((ID3D12Resource*) pResource.Handle, Subresource, window);
        }

        /// <summary>To be documented.</summary>
        public readonly void SharedFenceSignal<TI0>(ComPtr<TI0> pFence, ulong FenceValue) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SharedFenceSignal((ID3D12Fence*) pFence.Handle, FenceValue);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
