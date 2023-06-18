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
    [Guid("0000013d-0000-0000-c000-000000000046")]
    [NativeName("Name", "IClientSecurity")]
    public unsafe partial struct IClientSecurity : IComVtbl<IClientSecurity>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000013d-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IClientSecurity val)
            => Unsafe.As<IClientSecurity, Silk.NET.Core.Native.IUnknown>(ref val);

        public IClientSecurity
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
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy(Silk.NET.Core.Native.IUnknown* pProxy, Silk.NET.Core.Native.IUnknown** ppCopy)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxy, ppCopy);
            return ret;
        }

    }
}
