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

namespace Silk.NET.DXVA
{
    [Guid("a0cade0f-06d5-4cf4-a1c7-f3cdd725aa75")]
    [NativeName("Name", "IDirect3DDeviceManager9")]
    public unsafe partial struct IDirect3DDeviceManager9
    {
        public static readonly Guid Guid = new("a0cade0f-06d5-4cf4-a1c7-f3cdd725aa75");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDeviceManager9 val)
            => Unsafe.As<IDirect3DDeviceManager9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDeviceManager9
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
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResetDevice(Silk.NET.Direct3D9.IDirect3DDevice9* pDevice, uint resetToken)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)LpVtbl[3])(@this, pDevice, resetToken);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResetDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDevice, uint resetToken)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)LpVtbl[3])(@this, pDevicePtr, resetToken);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenDeviceHandle(void** phDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void**, int>)LpVtbl[4])(@this, phDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenDeviceHandle(ref void* phDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** phDevicePtr = &phDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void**, int>)LpVtbl[4])(@this, phDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CloseDeviceHandle(void* hDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, int>)LpVtbl[5])(@this, hDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CloseDeviceHandle<T0>(ref T0 hDevice) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, int>)LpVtbl[5])(@this, hDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TestDevice(void* hDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, int>)LpVtbl[6])(@this, hDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TestDevice<T0>(ref T0 hDevice) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, int>)LpVtbl[6])(@this, hDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice(void* hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, int fBlock)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)LpVtbl[7])(@this, hDevice, ppDevice, fBlock);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice(void* hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, int fBlock)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)LpVtbl[7])(@this, hDevice, ppDevicePtr, fBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice<T0>(ref T0 hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, int fBlock) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)LpVtbl[7])(@this, hDevicePtr, ppDevice, fBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice<T0>(ref T0 hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, int fBlock) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Silk.NET.Direct3D9.IDirect3DDevice9**, int, int>)LpVtbl[7])(@this, hDevicePtr, ppDevicePtr, fBlock);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnlockDevice(void* hDevice, int fSaveState)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, int, int>)LpVtbl[8])(@this, hDevice, fSaveState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockDevice<T0>(ref T0 hDevice, int fSaveState) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, int, int>)LpVtbl[8])(@this, hDevicePtr, fSaveState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, Guid* riid, void** ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)LpVtbl[9])(@this, hDevice, riid, ppService);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, Guid* riid, ref void* ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)LpVtbl[9])(@this, hDevice, riid, ppServicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, ref Guid riid, void** ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)LpVtbl[9])(@this, hDevice, riidPtr, ppService);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, ref Guid riid, ref void* ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppServicePtr = &ppService)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)LpVtbl[9])(@this, hDevice, riidPtr, ppServicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, Guid* riid, void** ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Guid*, void**, int>)LpVtbl[9])(@this, hDevicePtr, riid, ppService);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                fixed (void** ppServicePtr = &ppService)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Guid*, void**, int>)LpVtbl[9])(@this, hDevicePtr, riid, ppServicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, ref Guid riid, void** ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Guid*, void**, int>)LpVtbl[9])(@this, hDevicePtr, riidPtr, ppService);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, ref Guid riid, ref void* ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* hDevicePtr = &hDevice)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppServicePtr = &ppService)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDeviceManager9*, T0*, Guid*, void**, int>)LpVtbl[9])(@this, hDevicePtr, riidPtr, ppServicePtr);
                    }
                }
            }
            return ret;
        }

    }
}
