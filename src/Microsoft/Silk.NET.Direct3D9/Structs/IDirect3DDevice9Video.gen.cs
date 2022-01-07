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
    [Guid("26dc4561-a1ee-4ae7-96da-118a36c0ec95")]
    [NativeName("Name", "IDirect3DDevice9Video")]
    public unsafe partial struct IDirect3DDevice9Video
    {
        public static readonly Guid Guid = new("26dc4561-a1ee-4ae7-96da-118a36c0ec95");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9Video val)
            => Unsafe.As<IDirect3DDevice9Video, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDevice9Video
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
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecodeProfile, ref Contentprotectioncaps pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecodeProfile, Contentprotectioncaps* pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCaps);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCaps);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCaps);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecodeProfile, ref Contentprotectioncaps pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCapsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCapsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCapsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCaps);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCaps);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCaps);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecodeProfile, ref Contentprotectioncaps pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCapsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCapsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCapsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecodeProfile, Contentprotectioncaps* pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCaps);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCaps);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCaps);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecodeProfile, ref Contentprotectioncaps pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
                    fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCapsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCapsPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCapsPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, void** pChannelHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, ref void* pChannelHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pChannelHandlePtr = &pChannelHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, void** pChannelHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DAuthenticatedChannel9** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, ref void* pChannelHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DAuthenticatedChannel9** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
            {
                fixed (void** pChannelHandlePtr = &pChannelHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pCryptoHandlePtr = &pCryptoHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
                    fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
                    fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pCryptoTypePtr = &pCryptoType)
            {
                fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
                {
                    fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

    }
}
