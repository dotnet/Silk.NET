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

namespace Silk.NET.Direct3D9
{
    [Guid("ff24beee-da21-4beb-98b5-d2f899f98af9")]
    [NativeName("Name", "IDirect3DAuthenticatedChannel9")]
    public unsafe partial struct IDirect3DAuthenticatedChannel9 : IComVtbl<IDirect3DAuthenticatedChannel9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ff24beee-da21-4beb-98b5-d2f899f98af9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DAuthenticatedChannel9 val)
            => Unsafe.As<IDirect3DAuthenticatedChannel9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DAuthenticatedChannel9
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
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificateSize(uint* pCertificateSize)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)@this->LpVtbl[3])(@this, pCertificateSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)@this->LpVtbl[4])(@this, CertifacteSize, ppCertificate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateKeyExchange(uint DataSize, void* pData)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)@this->LpVtbl[5])(@this, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)@this->LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Configure(uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedchannelConfigureOutput* pOutput)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)@this->LpVtbl[7])(@this, InputSize, pInput, pOutput);
            return ret;
        }

    }
}
