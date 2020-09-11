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
    [NativeName("Name", "ID3D12DebugDevice1")]
    public unsafe partial struct ID3D12DebugDevice1
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DebugDevice1 val)
            => Unsafe.As<ID3D12DebugDevice1, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12DebugDevice1
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
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12DebugDevice1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12DebugDevice1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12DebugDevice1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, DebugDeviceParameterType, void*, uint, int>)LpVtbl[3])(@this, Type, pData, DataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDebugParameter<T0>(DebugDeviceParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12DebugDevice1*, DebugDeviceParameterType, T0*, uint, int>)LpVtbl[3])(@this, Type, pDataPtr, DataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, DebugDeviceParameterType, void*, uint, int>)LpVtbl[4])(@this, Type, pData, DataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDebugParameter<T0>(DebugDeviceParameterType Type, ref T0 pData, uint DataSize) where T0 : unmanaged
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12DebugDevice1*, DebugDeviceParameterType, T0*, uint, int>)LpVtbl[4])(@this, Type, pDataPtr, DataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReportLiveDeviceObjects(RldoFlags Flags)
        {
            fixed (ID3D12DebugDevice1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12DebugDevice1*, RldoFlags, int>)LpVtbl[5])(@this, Flags);
                return ret;
            }
        }

    }
}
