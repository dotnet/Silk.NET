// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12DebugCommandList2")]
    public unsafe partial struct ID3D12DebugCommandList2
    {
        public static implicit operator ID3D12DebugCommandList(ID3D12DebugCommandList2 val)
            => Unsafe.As<ID3D12DebugCommandList2, ID3D12DebugCommandList>(ref val);

        public readonly ref ID3D12DebugCommandList AsDebugCommandList()
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                return ref *(ID3D12DebugCommandList*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DebugCommandList2 val)
            => Unsafe.As<ID3D12DebugCommandList2, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12DebugCommandList2
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
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12DebugCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12DebugCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12DebugCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, int>)LpVtbl[3])(@this, pResource, Subresource, State);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AssertResourceState(ref ID3D12Resource pResource, uint Subresource, uint State)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, int>)LpVtbl[3])(@this, pResourcePtr, Subresource, State);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFeatureMask(DebugFeature Mask)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugFeature, int>)LpVtbl[4])(@this, Mask);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public DebugFeature GetFeatureMask()
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                DebugFeature ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugFeature>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)LpVtbl[6])(@this, Type, pData, DataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDebugParameter<T0>(DebugCommandListParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugCommandListParameterType, T0*, uint, int>)LpVtbl[6])(@this, Type, pDataPtr, DataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugCommandListParameterType, void*, uint, int>)LpVtbl[7])(@this, Type, pData, DataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDebugParameter<T0>(DebugCommandListParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged
        {
            fixed (ID3D12DebugCommandList2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12DebugCommandList2*, DebugCommandListParameterType, T0*, uint, int>)LpVtbl[7])(@this, Type, pDataPtr, DataSize);
                }
                return ret;
            }
        }

    }
}
