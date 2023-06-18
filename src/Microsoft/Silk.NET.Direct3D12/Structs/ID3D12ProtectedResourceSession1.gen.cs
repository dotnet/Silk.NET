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

namespace Silk.NET.Direct3D12
{
    [Guid("d6f12dd6-76fb-406e-8961-4296eefc0409")]
    [NativeName("Name", "ID3D12ProtectedResourceSession1")]
    public unsafe partial struct ID3D12ProtectedResourceSession1 : IComVtbl<ID3D12ProtectedResourceSession1>, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<ID3D12ProtectedSession>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d6f12dd6-76fb-406e-8961-4296eefc0409");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12ProtectedResourceSession(ID3D12ProtectedResourceSession1 val)
            => Unsafe.As<ID3D12ProtectedResourceSession1, ID3D12ProtectedResourceSession>(ref val);

        public static implicit operator ID3D12ProtectedSession(ID3D12ProtectedResourceSession1 val)
            => Unsafe.As<ID3D12ProtectedResourceSession1, ID3D12ProtectedSession>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12ProtectedResourceSession1 val)
            => Unsafe.As<ID3D12ProtectedResourceSession1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12ProtectedResourceSession1 val)
            => Unsafe.As<ID3D12ProtectedResourceSession1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12ProtectedResourceSession1 val)
            => Unsafe.As<ID3D12ProtectedResourceSession1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12ProtectedResourceSession1
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
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStatusFence(Guid* riid, void** ppFence)
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, Guid*, void**, int>)@this->LpVtbl[8])(@this, riid, ppFence);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProtectedSessionStatus GetSessionStatus()
        {
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProtectedSessionStatus ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedSessionStatus>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProtectedResourceSessionDesc GetDesc()
        {
            ProtectedResourceSessionDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProtectedResourceSessionDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedResourceSessionDesc*, ProtectedResourceSessionDesc*>)@this->LpVtbl[10])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProtectedResourceSessionDesc1 GetDesc1()
        {
            ProtectedResourceSessionDesc1 silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12ProtectedResourceSession1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProtectedResourceSessionDesc1* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ProtectedResourceSession1*, ProtectedResourceSessionDesc1*, ProtectedResourceSessionDesc1*>)@this->LpVtbl[11])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

    }
}
