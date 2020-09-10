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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11ModuleInstance")]
    public unsafe partial struct ID3D11ModuleInstance
    {
        public ID3D11ModuleInstance
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
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BindConstantBufferByName(byte* pName, uint uDstSlot, uint cbDstOffset)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindConstantBufferByName(ref byte pName, uint uDstSlot, uint cbDstOffset)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindConstantBufferByName(string pName, uint uDstSlot, uint cbDstOffset)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BindResourceByName(byte* pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pName, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResourceByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResourceByName(string pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BindSamplerByName(byte* pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pName, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindSamplerByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindSamplerByName(string pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BindUnorderedAccessViewByName(byte* pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pName, uDstSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindUnorderedAccessViewByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (byte* pNamePtr = &pName)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindUnorderedAccessViewByName(string pName, uint uDstSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
            var pNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pName);
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BindResourceAsUnorderedAccessViewByName(byte* pSrvName, uint uDstUavSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResourceAsUnorderedAccessViewByName(ref byte pSrvName, uint uDstUavSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
                fixed (byte* pSrvNamePtr = &pSrvName)
                {
                    ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BindResourceAsUnorderedAccessViewByName(string pSrvName, uint uDstUavSlot, uint uCount)
        {
            fixed (ID3D11ModuleInstance* @this = &this)
            {
                int ret = default;
            var pSrvNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pSrvName);
                ret = ((delegate* cdecl<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            Marshal.FreeHGlobal((IntPtr)pSrvNamePtr);
                return ret;
            }
        }

    }
}
