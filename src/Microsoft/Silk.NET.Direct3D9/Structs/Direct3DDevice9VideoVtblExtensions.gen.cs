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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DDevice9VideoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, Contentprotectioncaps* pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, ref Contentprotectioncaps pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, Contentprotectioncaps* pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, ref Contentprotectioncaps pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, Contentprotectioncaps* pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, ref Contentprotectioncaps pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCapsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, Contentprotectioncaps* pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCaps);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, ref Contentprotectioncaps pCaps) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfilePtr, pCapsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, void** pChannelHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, ref void* pChannelHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pChannelHandlePtr = &pChannelHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, void** pChannelHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DAuthenticatedChannel9** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TThis>(this TThis thisVtbl, Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, ref void* pChannelHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DAuthenticatedChannel9** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            fixed (void** pChannelHandlePtr = &pChannelHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pCryptoHandlePtr = &pCryptoHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
        {
            fixed (void** pCryptoHandlePtr = &pCryptoHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            fixed (void** pCryptoHandlePtr = &pCryptoHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, Guid* pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (void** pCryptoHandlePtr = &pCryptoHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSession, pCryptoHandlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TThis>(this TThis thisVtbl, ref Guid pCryptoType, ref Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle) where TThis : IComVtbl<IDirect3DDevice9Video>
    {
        var @this = (IDirect3DDevice9Video*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
            {
                fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    fixed (void** pCryptoHandlePtr = &pCryptoHandle)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfilePtr, ppCryptoSessionPtr, pCryptoHandlePtr);
                    }
                }
            }
        }
        return ret;
    }

}
