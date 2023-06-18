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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("26d709ac-f70b-4421-a96f-d2878fafb00d")]
    [NativeName("Name", "IMachineGlobalObjectTable")]
    public unsafe partial struct IMachineGlobalObjectTable : IComVtbl<IMachineGlobalObjectTable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("26d709ac-f70b-4421-a96f-d2878fafb00d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMachineGlobalObjectTable val)
            => Unsafe.As<IMachineGlobalObjectTable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMachineGlobalObjectTable
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
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterObject(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetObjectA(Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RevokeObject(MachineGlobalObjectTableRegistrationToken* token)
        {
            var @this = (IMachineGlobalObjectTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, token);
            return ret;
        }

    }
}
