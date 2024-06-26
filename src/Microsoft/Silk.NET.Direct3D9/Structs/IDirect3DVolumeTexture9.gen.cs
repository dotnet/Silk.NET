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
    [Guid("2518526c-e789-4111-a7b9-47ef328d13e6")]
    [NativeName("Name", "IDirect3DVolumeTexture9")]
    public unsafe partial struct IDirect3DVolumeTexture9 : IComVtbl<IDirect3DVolumeTexture9>, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<IDirect3DResource9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2518526c-e789-4111-a7b9-47ef328d13e6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirect3DBaseTexture9(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, IDirect3DBaseTexture9>(ref val);

        public static implicit operator IDirect3DResource9(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, IDirect3DResource9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVolumeTexture9
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
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetPriority(uint PriorityNew)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPriority()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PreLoad()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly Resourcetype GetType()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Resourcetype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Resourcetype>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetLOD(uint LODNew)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[11])(@this, LODNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLOD()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLevelCount()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutoGenFilterType(Texturefiltertype FilterType)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype, int>)@this->LpVtbl[14])(@this, FilterType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Texturefiltertype GetAutoGenFilterType()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Texturefiltertype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMipSubLevels()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[16])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLevelDesc(uint Level, VolumeDesc* pDesc)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)@this->LpVtbl[17])(@this, Level, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLevelDesc(uint Level, ref VolumeDesc pDesc)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VolumeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)@this->LpVtbl[17])(@this, Level, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVolumeLevel(uint Level, IDirect3DVolume9** ppVolumeLevel)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)@this->LpVtbl[18])(@this, Level, ppVolumeLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVolumeLevel(uint Level, ref IDirect3DVolume9* ppVolumeLevel)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DVolume9** ppVolumeLevelPtr = &ppVolumeLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)@this->LpVtbl[18])(@this, Level, ppVolumeLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(uint Level, LockedBox* pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolume, pBox, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(uint Level, LockedBox* pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pBoxPtr = &pBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolume, pBoxPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(uint Level, ref LockedBox pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolumePtr, pBox, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockBox(uint Level, ref LockedBox pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                fixed (Box* pBoxPtr = &pBox)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolumePtr, pBoxPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockBox(uint Level)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, int>)@this->LpVtbl[20])(@this, Level);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDirtyBox([Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDirtyBox)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)@this->LpVtbl[21])(@this, pDirtyBox);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDirtyBox([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDirtyBox)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pDirtyBoxPtr = &pDirtyBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)@this->LpVtbl[21])(@this, pDirtyBoxPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVolumeLevel<TI0>(uint Level, ref ComPtr<TI0> ppVolumeLevel) where TI0 : unmanaged, IComVtbl<IDirect3DVolume9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetVolumeLevel(Level, (IDirect3DVolume9**) ppVolumeLevel.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
