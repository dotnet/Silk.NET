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
    [Guid("cfdbd83f-9e06-4fda-8ea5-69042137f49b")]
    [NativeName("Name", "IDStorageQueue")]
    public unsafe partial struct IDStorageQueue : IComVtbl<IDStorageQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("cfdbd83f-9e06-4fda-8ea5-69042137f49b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageQueue val)
            => Unsafe.As<IDStorageQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageQueue
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
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] Request* request)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)@this->LpVtbl[3])(@this, request);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueStatus(IDStorageStatusArray* statusArray, uint index)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSignal(Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void Submit()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void CancelRequestsWithTag(ulong mask, ulong value)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void Close()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetErrorEvent()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void*>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RetrieveErrorRecord(ErrorRecord* record)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Query(QueueInfo* info)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
        }

    }
}
