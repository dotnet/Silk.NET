// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("7f91ce67-090c-4bb7-b78e-ed8ff2e31da0")]
    [NativeName("Name", "ID3D12VersionedRootSignatureDeserializer")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VersionedRootSignatureDeserializer val)
            => Unsafe.As<ID3D12VersionedRootSignatureDeserializer, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VersionedRootSignatureDeserializer
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, VersionedRootSignatureDesc** ppDesc)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, D3DRootSignatureVersion, VersionedRootSignatureDesc**, int>)LpVtbl[3])(@this, convertToVersion, ppDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRootSignatureDescAtVersion(D3DRootSignatureVersion convertToVersion, ref VersionedRootSignatureDesc* ppDesc)
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VersionedRootSignatureDesc** ppDescPtr = &ppDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, D3DRootSignatureVersion, VersionedRootSignatureDesc**, int>)LpVtbl[3])(@this, convertToVersion, ppDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe VersionedRootSignatureDesc* GetUnconvertedRootSignatureDesc()
        {
            var @this = (ID3D12VersionedRootSignatureDeserializer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                VersionedRootSignatureDesc* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VersionedRootSignatureDeserializer*, VersionedRootSignatureDesc*>)LpVtbl[4])(@this);
            return ret;
        }

    }
}
