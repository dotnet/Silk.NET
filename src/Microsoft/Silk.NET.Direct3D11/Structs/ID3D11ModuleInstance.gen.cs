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

namespace Silk.NET.Direct3D11
{
    [Guid("469e07f7-045a-48d5-aa12-68a478cdf75d")]
    [NativeName("Name", "ID3D11ModuleInstance")]
    public unsafe partial struct ID3D11ModuleInstance
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ModuleInstance val)
            => Unsafe.As<ID3D11ModuleInstance, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ModuleInstance
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
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BindConstantBufferByName(byte* pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindConstantBufferByName(ref byte pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindConstantBufferByName(string pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BindResourceByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResourceByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResourceByName(string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BindSamplerByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindSamplerByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindSamplerByName(string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BindUnorderedAccessViewByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindUnorderedAccessViewByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindUnorderedAccessViewByName(string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BindResourceAsUnorderedAccessViewByName(byte* pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName(ref byte pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pSrvNamePtr = &pSrvName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName(string pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pSrvNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pSrvName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pSrvNamePtr);
            return ret;
        }

    }
}
