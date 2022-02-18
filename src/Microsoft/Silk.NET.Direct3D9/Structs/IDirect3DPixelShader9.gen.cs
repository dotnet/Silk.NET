// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Direct3D9
{
    [Guid("6d3bdbdc-5b02-4415-b852-ce5e8bccb289")]
    [NativeName("Name", "IDirect3DPixelShader9")]
    public unsafe partial struct IDirect3DPixelShader9
    {
        public static readonly Guid Guid = new("6d3bdbdc-5b02-4415-b852-ce5e8bccb289");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DPixelShader9 val)
            => Unsafe.As<IDirect3DPixelShader9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DPixelShader9
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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFunction(void* arg0, uint* pSizeOfData)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFunction(void* arg0, ref uint pSizeOfData)
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0, pSizeOfDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFunction<T0>(ref T0 arg0, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* arg0Ptr = &arg0)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFunction<T0>(ref T0 arg0, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DPixelShader9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* arg0Ptr = &arg0)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DPixelShader9*, void*, uint*, int>)LpVtbl[4])(@this, arg0Ptr, pSizeOfDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
