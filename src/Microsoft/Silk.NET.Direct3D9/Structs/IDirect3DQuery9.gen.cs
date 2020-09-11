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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3DQuery9")]
    public unsafe partial struct IDirect3DQuery9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DQuery9 val)
            => Unsafe.As<IDirect3DQuery9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DQuery9
        (
            Querytype type = default,
            uint dataSize = default,
            void** lpVtbl = default
        )
        {
            Type = type;
            DataSize = dataSize;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "D3DQUERYTYPE")]
        [NativeName("Type.Name", "D3DQUERYTYPE")]
        [NativeName("Name", "Type")]
        public Querytype Type;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DQuery9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDirect3DQuery9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public Querytype GetType()
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                Querytype ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, Querytype>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetDataSize()
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, uint>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Issue(uint dwIssueFlags)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, uint, int>)LpVtbl[6])(@this, dwIssueFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetData(void* pData, uint dwSize, uint dwGetDataFlags)
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DQuery9*, void*, uint, uint, int>)LpVtbl[7])(@this, pData, dwSize, dwGetDataFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetData<T0>(ref T0 pData, uint dwSize, uint dwGetDataFlags) where T0 : unmanaged
        {
            fixed (IDirect3DQuery9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDirect3DQuery9*, T0*, uint, uint, int>)LpVtbl[7])(@this, pDataPtr, dwSize, dwGetDataFlags);
                }
                return ret;
            }
        }

    }
}
