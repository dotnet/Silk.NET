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
    [Guid("6924ea0c-c3cd-4826-b10a-f64f4ed927c1")]
    [NativeName("Name", "IDStorageFactory")]
    public unsafe partial struct IDStorageFactory : IComVtbl<IDStorageFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6924ea0c-c3cd-4826-b10a-f64f4ed927c1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageFactory val)
            => Unsafe.As<IDStorageFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageFactory
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
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueueDesc* desc, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugFlags(uint flags)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, void>)@this->LpVtbl[6])(@this, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStagingBufferSize(uint size)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, int>)@this->LpVtbl[7])(@this, size);
            return ret;
        }

    }
}
