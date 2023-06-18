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
    [Guid("0d47c6c9-e61a-4706-93b4-68bfe3f4aa4a")]
    [NativeName("Name", "IDStorageCustomDecompressionQueue1")]
    public unsafe partial struct IDStorageCustomDecompressionQueue1 : IComVtbl<IDStorageCustomDecompressionQueue1>, IComVtbl<IDStorageCustomDecompressionQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0d47c6c9-e61a-4706-93b4-68bfe3f4aa4a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDStorageCustomDecompressionQueue(IDStorageCustomDecompressionQueue1 val)
            => Unsafe.As<IDStorageCustomDecompressionQueue1, IDStorageCustomDecompressionQueue>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageCustomDecompressionQueue1 val)
            => Unsafe.As<IDStorageCustomDecompressionQueue1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageCustomDecompressionQueue1
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
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetEvent()
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, void*>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequests(uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[4])(@this, maxRequests, requests, numRequests);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRequestResults(uint numResults, CustomDecompressionResult* results)
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, uint, CustomDecompressionResult*, int>)@this->LpVtbl[5])(@this, numResults, results);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequests1(GetRequestFlags flags, uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue1*, GetRequestFlags, uint, CustomDecompressionRequest*, uint*, int>)@this->LpVtbl[6])(@this, flags, maxRequests, requests, numRequests);
            return ret;
        }

    }
}
