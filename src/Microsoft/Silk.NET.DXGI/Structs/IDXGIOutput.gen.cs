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

namespace Silk.NET.DXGI
{
    [Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
    [NativeName("Name", "IDXGIOutput")]
    public unsafe partial struct IDXGIOutput : IComVtbl<IDXGIOutput>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ae02eedb-c735-4690-8d52-5a8dc20213aa");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIOutput val)
            => Unsafe.As<IDXGIOutput, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutput val)
            => Unsafe.As<IDXGIOutput, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutput
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
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(OutputDesc* pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref OutputDesc pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutputDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForVBlank()
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, int>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TakeOwnership(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Bool32 Exclusive)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevice, Exclusive);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Bool32 Exclusive)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevicePtr, Exclusive);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseOwnership()
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutput*, void>)@this->LpVtbl[12])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControlCapabilities(GammaControlCapabilities* pGammaCaps)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControlCapabilities(ref GammaControlCapabilities pGammaCaps)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGammaControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] GammaControl* pArray)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGammaControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GammaControl pArray)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDisplaySurface(Silk.NET.DXGI.IDXGISurface* pScanoutSurface)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface(ref Silk.NET.DXGI.IDXGISurface pScanoutSurface)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData(Silk.NET.DXGI.IDXGISurface* pDestination)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestination);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData(ref Silk.NET.DXGI.IDXGISurface pDestination)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* pDestinationPtr = &pDestination)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestinationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(in pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(in pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership<TI0>(ComPtr<TI0> pDevice, Silk.NET.Core.Bool32 Exclusive) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TakeOwnership((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Exclusive);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface<TI0>(ComPtr<TI0> pScanoutSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetDisplaySurface((Silk.NET.DXGI.IDXGISurface*) pScanoutSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData<TI0>(ComPtr<TI0> pDestination) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplaySurfaceData((Silk.NET.DXGI.IDXGISurface*) pDestination.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
