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
    public unsafe partial struct IDirect3DDeviceManager9 : IComVtbl<IDirect3DDeviceManager9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a0cade0f-06d5-4cf4-a1c7-f3cdd725aa75");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResetDevice(Silk.NET.Direct3D9.IDirect3DDevice9* pDevice, uint resetToken)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevice, resetToken);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResetDevice(ref Silk.NET.Direct3D9.IDirect3DDevice9 pDevice, uint resetToken)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevicePtr, resetToken);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenDeviceHandle(void** phDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenDeviceHandle(ref void* phDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** phDevicePtr = &phDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CloseDeviceHandle(void* hDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CloseDeviceHandle<T0>(ref T0 hDevice) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TestDevice(void* hDevice)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TestDevice<T0>(ref T0 hDevice) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice(void* hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevice, ppDevice, fBlock);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice(void* hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, Silk.NET.Core.Bool32 fBlock)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevice, ppDevicePtr, fBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice<T0>(ref T0 hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevice, fBlock);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockDevice<T0>(ref T0 hDevice, ref Silk.NET.Direct3D9.IDirect3DDevice9* ppDevice, Silk.NET.Core.Bool32 fBlock) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevicePtr, ppDevicePtr, fBlock);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnlockDevice(void* hDevice, Silk.NET.Core.Bool32 fSaveState)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, hDevice, fSaveState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockDevice<T0>(ref T0 hDevice, Silk.NET.Core.Bool32 fSaveState) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, hDevicePtr, fSaveState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, Guid* riid, void** ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppService);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService(void* hDevice, Guid* riid, ref void* ppService)
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppServicePtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riidPtr, ppService);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riidPtr, ppServicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, Guid* riid, void** ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riid, ppService);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, Guid* riid, ref void* ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                fixed (void** ppServicePtr = &ppService)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riid, ppServicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, ref Guid riid, void** ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riidPtr, ppService);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<T0>(ref T0 hDevice, ref Guid riid, ref void* ppService) where T0 : unmanaged
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hDevicePtr = &hDevice)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppServicePtr = &ppService)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevicePtr, riidPtr, ppServicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoService<TI0>(void* hDevice, out ComPtr<TI0> ppService) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppService = default;
            return @this->GetVideoService(hDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoService<T0, TI0>(ref T0 hDevice, out ComPtr<TI0> ppService) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppService = default;
            return @this->GetVideoService(ref hDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppService.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetVideoService<TI0>(void* hDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetVideoService(hDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetVideoService<T0, TI0>(ref T0 hDevice) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DDeviceManager9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetVideoService(ref hDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
