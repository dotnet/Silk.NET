// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    public unsafe partial struct ID3D12SharingContract
    {
        public static readonly Guid Guid = new("0adf7d52-929c-4e61-addb-ffed30de66ef");

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
            ret = ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Present(ID3D12Resource* pResource, uint Subresource, nint window)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)LpVtbl[3])(@this, pResource, Subresource, window);
        }

        /// <summary>To be documented.</summary>
        public readonly void Present(ref ID3D12Resource pResource, uint Subresource, nint window)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)LpVtbl[3])(@this, pResourcePtr, Subresource, window);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)LpVtbl[4])(@this, pFence, FenceValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void SharedFenceSignal(ref ID3D12Fence pFence, ulong FenceValue)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Fence* pFencePtr = &pFence)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)LpVtbl[4])(@this, pFencePtr, FenceValue);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginCapturableWork(Guid* guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void>)LpVtbl[5])(@this, guid);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginCapturableWork(ref Guid guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* guidPtr = &guid)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void>)LpVtbl[5])(@this, guidPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndCapturableWork(Guid* guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void>)LpVtbl[6])(@this, guid);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndCapturableWork(ref Guid guid)
        {
            var @this = (ID3D12SharingContract*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* guidPtr = &guid)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12SharingContract*, Guid*, void>)LpVtbl[6])(@this, guidPtr);
            }
        }

    }
}
