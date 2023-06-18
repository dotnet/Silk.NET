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
    [Guid("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e")]
    [NativeName("Name", "IDXGIAdapter4")]
    public unsafe partial struct IDXGIAdapter4 : IComVtbl<IDXGIAdapter4>, IComVtbl<IDXGIAdapter3>, IComVtbl<IDXGIAdapter2>, IComVtbl<IDXGIAdapter1>, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGIAdapter3(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter3>(ref val);

        public static implicit operator IDXGIAdapter2(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter2>(ref val);

        public static implicit operator IDXGIAdapter1(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIAdapter(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, Silk.NET.DXGI.IDXGIAdapter>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIAdapter4
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
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumOutputs(uint Output, IDXGIOutput** ppOutput)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(AdapterDesc* pDesc)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckInterfaceSupport(Guid* InterfaceName, long* pUMDVersion)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc1(AdapterDesc1* pDesc)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc2(AdapterDesc2* pDesc)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterHardwareContentProtectionTeardownStatus(uint dwCookie)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[13])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryVideoMemoryInfo(uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVideoMemoryReservation(uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ulong Reservation)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, ulong, int>)@this->LpVtbl[15])(@this, NodeIndex, MemorySegmentGroup, Reservation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(void* hEvent, uint* pdwCookie)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterVideoMemoryBudgetChangeNotification(uint dwCookie)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[17])(@this, dwCookie);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc3(AdapterDesc3* pDesc)
        {
            var @this = (IDXGIAdapter4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, int>)@this->LpVtbl[18])(@this, pDesc);
            return ret;
        }

    }
}
