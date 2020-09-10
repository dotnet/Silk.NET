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
    [NativeName("Name", "ID3D12StateObjectProperties")]
    public unsafe partial struct ID3D12StateObjectProperties
    {
        public ID3D12StateObjectProperties
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
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetShaderIdentifier(char* pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                void* ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportName);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetShaderIdentifier(ref char pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                void* ret = default;
                fixed (char* pExportNamePtr = &pExportName)
                {
                    ret = ((delegate* cdecl<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetShaderIdentifier(string pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                void* ret = default;
            var pExportNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pExportName);
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, byte*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            Marshal.FreeHGlobal((IntPtr)pExportNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ulong GetShaderStackSize(char* pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportName);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetShaderStackSize(ref char pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                ulong ret = default;
                fixed (char* pExportNamePtr = &pExportName)
                {
                    ret = ((delegate* cdecl<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetShaderStackSize(string pExportName)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                ulong ret = default;
            var pExportNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pExportName);
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, byte*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            Marshal.FreeHGlobal((IntPtr)pExportNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetPipelineStackSize()
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D12StateObjectProperties*, ulong>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void SetPipelineStackSize(ulong PipelineStackSizeInBytes)
        {
            fixed (ID3D12StateObjectProperties* @this = &this)
            {
                ((delegate* cdecl<ID3D12StateObjectProperties*, ulong, void>)LpVtbl[6])(@this, PipelineStackSizeInBytes);
            }
        }

    }
}
