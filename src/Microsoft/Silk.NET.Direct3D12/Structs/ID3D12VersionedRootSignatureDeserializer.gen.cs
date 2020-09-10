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
    [NativeName("Name", "ID3D12VersionedRootSignatureDeserializer")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public ID3D12VersionedRootSignatureDeserializer
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
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, VersionedRootSignatureDesc** ppDesc)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, D3DRootSignatureVersion, VersionedRootSignatureDesc**, int>)LpVtbl[3])(@this, convertToVersion, ppDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, ref VersionedRootSignatureDesc* ppDesc)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                int ret = default;
                fixed (VersionedRootSignatureDesc** ppDescPtr = &ppDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, D3DRootSignatureVersion, VersionedRootSignatureDesc**, int>)LpVtbl[3])(@this, convertToVersion, ppDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe VersionedRootSignatureDesc* GetUnconvertedRootSignatureDesc()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* @this = &this)
            {
                VersionedRootSignatureDesc* ret = default;
                ret = ((delegate* cdecl<ID3D12VersionedRootSignatureDeserializer*, VersionedRootSignatureDesc*>)LpVtbl[4])(@this);
                return ret;
            }
        }

    }
}
