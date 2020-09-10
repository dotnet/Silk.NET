// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12SharingContract")]
    public unsafe partial struct ID3D12SharingContract
    {
        public ID3D12SharingContract
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12SharingContract*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12SharingContract*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12SharingContract*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void Present(ID3D12Resource* pResource, uint Subresource, IntPtr window)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                ((delegate* cdecl<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void>)LpVtbl[3])(@this, pResource, Subresource, window);
            }
        }

        /// <summary>To be added.</summary>
        public void Present(ref ID3D12Resource pResource, uint Subresource, IntPtr window)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void>)LpVtbl[3])(@this, pResourcePtr, Subresource, window);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                ((delegate* cdecl<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)LpVtbl[4])(@this, pFence, FenceValue);
            }
        }

        /// <summary>To be added.</summary>
        public void SharedFenceSignal(ref ID3D12Fence pFence, ulong FenceValue)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                fixed (ID3D12Fence* pFencePtr = &pFence)
                {
                    ((delegate* cdecl<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)LpVtbl[4])(@this, pFencePtr, FenceValue);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginCapturableWork(Guid* guid)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                ((delegate* cdecl<ID3D12SharingContract*, Guid*, void>)LpVtbl[5])(@this, guid);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginCapturableWork(ref Guid guid)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                fixed (Guid* guidPtr = &guid)
                {
                    ((delegate* cdecl<ID3D12SharingContract*, Guid*, void>)LpVtbl[5])(@this, guidPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EndCapturableWork(Guid* guid)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                ((delegate* cdecl<ID3D12SharingContract*, Guid*, void>)LpVtbl[6])(@this, guid);
            }
        }

        /// <summary>To be added.</summary>
        public void EndCapturableWork(ref Guid guid)
        {
            fixed (ID3D12SharingContract* @this = &this)
            {
                fixed (Guid* guidPtr = &guid)
                {
                    ((delegate* cdecl<ID3D12SharingContract*, Guid*, void>)LpVtbl[6])(@this, guidPtr);
                }
            }
        }

    }
}
