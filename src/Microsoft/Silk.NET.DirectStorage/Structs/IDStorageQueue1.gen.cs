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

namespace Silk.NET.DirectStorage
{
    [Guid("dd2f482c-5eff-41e8-9c9e-d2374b278128")]
    [NativeName("Name", "IDStorageQueue1")]
    public unsafe partial struct IDStorageQueue1 : IComVtbl<IDStorageQueue1>, IComVtbl<IDStorageQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dd2f482c-5eff-41e8-9c9e-d2374b278128");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDStorageQueue(IDStorageQueue1 val)
            => Unsafe.As<IDStorageQueue1, IDStorageQueue>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageQueue1 val)
            => Unsafe.As<IDStorageQueue1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageQueue1
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
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] Request* request)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Request*, void>)@this->LpVtbl[3])(@this, request);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueStatus(IDStorageStatusArray* statusArray, uint index)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSignal(Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void Submit()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void CancelRequestsWithTag(ulong mask, ulong value)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void Close()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetErrorEvent()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void*>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RetrieveErrorRecord(ErrorRecord* record)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Query(QueueInfo* info)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSetEvent(void* handle)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void*, void>)@this->LpVtbl[12])(@this, handle);
        }

    }
}
