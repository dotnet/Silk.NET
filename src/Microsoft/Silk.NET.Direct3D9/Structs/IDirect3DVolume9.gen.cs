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
    [Guid("24f416e6-1f67-4aa7-b88e-d33f6f3128a1")]
    [NativeName("Name", "IDirect3DVolume9")]
    public unsafe partial struct IDirect3DVolume9 : IComVtbl<IDirect3DVolume9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("24f416e6-1f67-4aa7-b88e-d33f6f3128a1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVolume9 val)
            => Unsafe.As<IDirect3DVolume9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVolume9
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
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(Guid* riid, void** ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppContainer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(Guid* riid, ref void* ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppContainerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(ref Guid riid, void** ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppContainer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(ref Guid riid, ref void* ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppContainerPtr = &ppContainer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppContainerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(VolumeDesc* pDesc)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref VolumeDesc pDesc)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VolumeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(LockedBox* pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolume, pBox, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(LockedBox* pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pBoxPtr = &pBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolume, pBoxPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(ref LockedBox pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolumePtr, pBox, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockBox(ref LockedBox pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                fixed (Box* pBoxPtr = &pBox)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolumePtr, pBoxPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockBox()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, int>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainer<TI0>(out ComPtr<TI0> ppContainer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppContainer = default;
            return @this->GetContainer(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppContainer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetContainer<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetContainer(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
