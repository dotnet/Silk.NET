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
    [Guid("068346e8-aaec-4b84-add7-137f513f77a1")]
    [NativeName("Name", "IDXGIOutput6")]
    public unsafe partial struct IDXGIOutput6 : IComVtbl<IDXGIOutput6>, IComVtbl<IDXGIOutput5>, IComVtbl<IDXGIOutput4>, IComVtbl<IDXGIOutput3>, IComVtbl<IDXGIOutput2>, IComVtbl<IDXGIOutput1>, IComVtbl<IDXGIOutput>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("068346e8-aaec-4b84-add7-137f513f77a1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIOutput5(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput5>(ref val);

        public static implicit operator IDXGIOutput4(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput4>(ref val);

        public static implicit operator IDXGIOutput3(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput3>(ref val);

        public static implicit operator IDXGIOutput2(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput2>(ref val);

        public static implicit operator IDXGIOutput1(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput1>(ref val);

        public static implicit operator IDXGIOutput(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, IDXGIOutput>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutput6 val)
            => Unsafe.As<IDXGIOutput6, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutput6
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
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(OutputDesc* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref OutputDesc pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutputDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForVBlank()
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, int>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TakeOwnership(Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Bool32 Exclusive)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevice, Exclusive);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership(ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Bool32 Exclusive)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevicePtr, Exclusive);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseOwnership()
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, void>)@this->LpVtbl[12])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControlCapabilities(GammaControlCapabilities* pGammaCaps)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControlCapabilities(ref GammaControlCapabilities pGammaCaps)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGammaControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] GammaControl* pArray)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGammaControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GammaControl pArray)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDisplaySurface(Silk.NET.DXGI.IDXGISurface* pScanoutSurface)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface(ref Silk.NET.DXGI.IDXGISurface pScanoutSurface)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData(Silk.NET.DXGI.IDXGISurface* pDestination)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestination);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData(ref Silk.NET.DXGI.IDXGISurface pDestination)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* pDestinationPtr = &pDestination)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestinationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestination);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData1(ref IDXGIResource pDestination)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pDestinationPtr = &pDestination)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestinationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplication);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 SupportsOverlays()
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                fixed (uint* pFlagsPtr = &pFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                fixed (uint* pFlagsPtr = &pFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplicationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplication);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplicationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplicationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplication);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
                {
                    fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplicationPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc1(OutputDesc1* pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc1*, int>)@this->LpVtbl[27])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc1(ref OutputDesc1 pDesc)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutputDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc1*, int>)@this->LpVtbl[27])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckHardwareCompositionSupport(uint* pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)@this->LpVtbl[28])(@this, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckHardwareCompositionSupport(ref uint pFlags)
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)@this->LpVtbl[28])(@this, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(in pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode(in pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership<TI0>(ComPtr<TI0> pDevice, Silk.NET.Core.Bool32 Exclusive) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TakeOwnership((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Exclusive);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface<TI0>(ComPtr<TI0> pScanoutSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetDisplaySurface((Silk.NET.DXGI.IDXGISurface*) pScanoutSurface.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData<TI0>(ComPtr<TI0> pDestination) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplaySurfaceData((Silk.NET.DXGI.IDXGISurface*) pDestination.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode1(pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode1(pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode1(in pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FindClosestMatchingMode1(in pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData1<TI0>(ComPtr<TI0> pDestination) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplaySurfaceData1((IDXGIResource*) pDestination.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int DuplicateOutput<TI0, TI1>(ComPtr<TI0> pDevice, ref ComPtr<TI1> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI1>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput<TI0>(ComPtr<TI0> pDevice, ref IDXGIOutputDuplication* ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref ppOutputDuplication);
        }

        /// <summary>To be documented.</summary>
        public readonly int DuplicateOutput<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, ref ComPtr<TI0> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput(ref pDevice, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport<TI0>(Silk.NET.DXGI.Format EnumFormat, ComPtr<TI0> pConcernedDevice, uint* pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckOverlaySupport(EnumFormat, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, pFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlaySupport<TI0>(Silk.NET.DXGI.Format EnumFormat, ComPtr<TI0> pConcernedDevice, ref uint pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckOverlaySupport(EnumFormat, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, ref pFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport<TI0>(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ComPtr<TI0> pConcernedDevice, uint* pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, pFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlayColorSpaceSupport<TI0>(Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ComPtr<TI0> pConcernedDevice, ref uint pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, ref pFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, ref ComPtr<TI1> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI1>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, SupportedFormatsCount, pSupportedFormats, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1<TI0>(ComPtr<TI0> pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, SupportedFormatsCount, pSupportedFormats, ref ppOutputDuplication);
        }

        /// <summary>To be documented.</summary>
        public readonly int DuplicateOutput1<TI0, TI1>(ComPtr<TI0> pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, ref ComPtr<TI1> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI1>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, SupportedFormatsCount, in pSupportedFormats, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1<TI0>(ComPtr<TI0> pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Flags, SupportedFormatsCount, in pSupportedFormats, ref ppOutputDuplication);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput1<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Format* pSupportedFormats, ref ComPtr<TI0> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1(ref pDevice, Flags, SupportedFormatsCount, pSupportedFormats, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int DuplicateOutput1<TI0>(ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Format pSupportedFormats, ref ComPtr<TI0> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DuplicateOutput1(ref pDevice, Flags, SupportedFormatsCount, in pSupportedFormats, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGIOutput6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
