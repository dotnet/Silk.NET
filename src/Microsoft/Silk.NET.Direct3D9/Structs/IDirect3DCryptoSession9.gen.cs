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
    [Guid("fa0ab799-7a9c-48ca-8c5b-237e71a54434")]
    [NativeName("Name", "IDirect3DCryptoSession9")]
    public unsafe partial struct IDirect3DCryptoSession9
    {
        public static readonly Guid Guid = new("fa0ab799-7a9c-48ca-8c5b-237e71a54434");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DCryptoSession9 val)
            => Unsafe.As<IDirect3DCryptoSession9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DCryptoSession9
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
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificateSize(uint* pCertificateSize)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSize);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSize);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificateSize(ref uint pCertificateSize)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCertificateSizePtr = &pCertificateSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSizePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSizePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint*, int>)LpVtbl[3])(@this, pCertificateSizePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCertificate(uint CertifacteSize, byte* ppCertificate)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificate);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificate);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificate);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificate(uint CertifacteSize, ref byte ppCertificate)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* ppCertificatePtr = &ppCertificate)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCertificate(uint CertifacteSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ppCertificate)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var ppCertificatePtr = (byte*) SilkMarshal.StringToPtr(ppCertificate, NativeStringEncoding.UTF8);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, byte*, int>)LpVtbl[4])(@this, CertifacteSize, ppCertificatePtr);
            }
            #endif
            SilkMarshal.Free((nint)ppCertificatePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateKeyExchange(uint DataSize, void* pData)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateKeyExchange<T0>(uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, uint, void*, int>)LpVtbl[5])(@this, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIVPtr = &pIV)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIVPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIVPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurface, DstSurfaceSize, pIVPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurface, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurface, DstSurfaceSize, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EncryptionBlt(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EncryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)LpVtbl[6])(@this, pSrcSurfacePtr, pDstSurfacePtr, DstSurfaceSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pIVPtr = &pIV)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContentKeyPtr = &pContentKey)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(IDirect3DSurface9* pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(IDirect3DSurface9* pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurface, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(ref IDirect3DSurface9 pSrcSurface, IDirect3DSurface9* pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIVPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIV);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0, T1>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, EncryptedBlockInfo* pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfo, pContentKeyPtr, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, void* pIV)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIV);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, void* pContentKey, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKey, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecryptionBlt<T0>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, void* pIV) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIV);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecryptionBlt<T0, T1>(ref IDirect3DSurface9 pSrcSurface, ref IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref EncryptedBlockInfo pEncryptedBlockInfo, ref T0 pContentKey, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (IDirect3DSurface9* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, EncryptedBlockInfo*, void*, void*, int>)LpVtbl[7])(@this, pSrcSurfacePtr, pDstSurfacePtr, SrcSurfaceSize, pEncryptedBlockInfoPtr, pContentKeyPtr, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSurfacePitch(IDirect3DSurface9* pSrcSurface, uint* pSurfacePitch)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitch);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitch);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitch);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSurfacePitch(IDirect3DSurface9* pSrcSurface, ref uint pSurfacePitch)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSurfacePitchPtr = &pSurfacePitch)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitchPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitchPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurface, pSurfacePitchPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSurfacePitch(ref IDirect3DSurface9 pSrcSurface, uint* pSurfacePitch)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitch);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitch);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitch);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSurfacePitch(ref IDirect3DSurface9 pSrcSurface, ref uint pSurfacePitch)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (uint* pSurfacePitchPtr = &pSurfacePitch)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitchPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitchPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)LpVtbl[8])(@this, pSrcSurfacePtr, pSurfacePitchPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StartSessionKeyRefresh(void* pRandomNumber, uint RandomNumberSize)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumber, RandomNumberSize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumber, RandomNumberSize);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumber, RandomNumberSize);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StartSessionKeyRefresh<T0>(ref T0 pRandomNumber, uint RandomNumberSize) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pRandomNumberPtr = &pRandomNumber)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumberPtr, RandomNumberSize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumberPtr, RandomNumberSize);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[9])(@this, pRandomNumberPtr, RandomNumberSize);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishSessionKeyRefresh()
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, int>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(void* pReadbackKey, uint KeySize)
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKey, KeySize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKey, KeySize);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKey, KeySize);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncryptionBltKey<T0>(ref T0 pReadbackKey, uint KeySize) where T0 : unmanaged
        {
            var @this = (IDirect3DCryptoSession9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReadbackKeyPtr = &pReadbackKey)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKeyPtr, KeySize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKeyPtr, KeySize);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCryptoSession9*, void*, uint, int>)LpVtbl[11])(@this, pReadbackKeyPtr, KeySize);
                }
            #endif
            }
            return ret;
        }

    }
}
