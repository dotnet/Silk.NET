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
    [Guid("d5f569d0-593b-101a-b569-08002b2dbf7a")]
    [NativeName("Name", "IPSFactoryBuffer")]
    public unsafe partial struct IPSFactoryBuffer : IComVtbl<IPSFactoryBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d5f569d0-593b-101a-b569-08002b2dbf7a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPSFactoryBuffer val)
            => Unsafe.As<IPSFactoryBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPSFactoryBuffer
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
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServer, ppStub);
            return ret;
        }

    }
}
