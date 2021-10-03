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
    public unsafe partial struct IDirect3DAuthenticatedChannel9
    {
        public static readonly Guid Guid = new("ff24beee-da21-4beb-98b5-d2f899f98af9");

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
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificateSize(uint* pCertificateSize)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)LpVtbl[3])(@this, pCertificateSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificateSize(ref uint pCertificateSize)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCertificateSizePtr = &pCertificateSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint*, int>)LpVtbl[3])(@this, pCertificateSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificate(uint CertifacteSize, ref byte ppCertificate)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* ppCertificatePtr = &ppCertificate)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificate(uint CertifacteSize, string ppCertificate)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var ppCertificatePtr = (byte*) Marshal.StringToHGlobalAnsi(ppCertificate);
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            Marshal.FreeHGlobal((nint)ppCertificatePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateKeyExchange(uint DataSize, void* pData)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateKeyExchange<T0>(uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, T0*, int>)LpVtbl[5])(@this, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query(uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query<T0>(uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, uint, T0*, int>)LpVtbl[6])(@this, InputSize, pInput, OutputSize, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Query<T0>(uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, T0*, uint, void*, int>)LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Query<T0, T1>(uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                fixed (T1* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, T0*, uint, T1*, int>)LpVtbl[6])(@this, InputSize, pInputPtr, OutputSize, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Configure(uint InputSize, void* pInput, AuthenticatedchannelConfigureOutput* pOutput)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)LpVtbl[7])(@this, InputSize, pInput, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Configure(uint InputSize, void* pInput, ref AuthenticatedchannelConfigureOutput pOutput)
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, void*, AuthenticatedchannelConfigureOutput*, int>)LpVtbl[7])(@this, InputSize, pInput, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Configure<T0>(uint InputSize, ref T0 pInput, AuthenticatedchannelConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, T0*, AuthenticatedchannelConfigureOutput*, int>)LpVtbl[7])(@this, InputSize, pInputPtr, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Configure<T0>(uint InputSize, ref T0 pInput, ref AuthenticatedchannelConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (IDirect3DAuthenticatedChannel9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                fixed (AuthenticatedchannelConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DAuthenticatedChannel9*, uint, T0*, AuthenticatedchannelConfigureOutput*, int>)LpVtbl[7])(@this, InputSize, pInputPtr, pOutputPtr);
                }
            }
            return ret;
        }

    }
}
