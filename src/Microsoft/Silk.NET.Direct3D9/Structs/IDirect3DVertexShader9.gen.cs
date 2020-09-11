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
    [NativeName("Name", "IDirect3DVertexShader9")]
    public unsafe partial struct IDirect3DVertexShader9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVertexShader9 val)
            => Unsafe.As<IDirect3DVertexShader9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DVertexShader9
        (
            uint version = default,
            void** lpVtbl = default
        )
        {
            Version = version;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Version")]
        public uint Version;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DVertexShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DVertexShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DVertexShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DVertexShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DVertexShader9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DVertexShader9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DVertexShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDirect3DVertexShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFunction(void* arg0, uint* pSizeOfData)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DVertexShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFunction(void* arg0, ref uint pSizeOfData)
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* cdecl<IDirect3DVertexShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFunction<T0>(ref T0 arg0, uint* pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (T0* arg0Ptr = &arg0)
                {
                    ret = ((delegate* cdecl<IDirect3DVertexShader9*, T0*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFunction<T0>(ref T0 arg0, ref uint pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DVertexShader9* @this = &this)
            {
                int ret = default;
                fixed (T0* arg0Ptr = &arg0)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* cdecl<IDirect3DVertexShader9*, T0*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfDataPtr);
                    }
                }
                return ret;
            }
        }

    }
}
