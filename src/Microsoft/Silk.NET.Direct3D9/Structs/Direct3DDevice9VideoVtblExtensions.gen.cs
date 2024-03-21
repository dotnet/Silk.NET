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
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDirect3DDevice9Video> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDevice9Video> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref Contentprotectioncaps pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Contentprotectioncaps* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfilePtr, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref Contentprotectioncaps pCaps)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoTypePtr, pDecodeProfile, pCaps);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref Contentprotectioncaps pCaps)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref Contentprotectioncaps pCaps)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, void** pChannelHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, ref void* pChannelHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pChannelHandlePtr = &pChannelHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, void** pChannelHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DAuthenticatedChannel9** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannelPtr, pChannelHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, ref IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel, ref void* pChannelHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pCryptoHandlePtr = &pCryptoHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DCryptoSession9** ppCryptoSessionPtr = &ppCryptoSession)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSessionPtr, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pDecodeProfilePtr = &pDecodeProfile)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfilePtr, ppCryptoSession, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCryptoTypePtr = &pCryptoType)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoTypePtr, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Span<Contentprotectioncaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, pDecodeProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, in pDecodeProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, Span<Contentprotectioncaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(pCryptoType, in pDecodeProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), pDecodeProfile, pCaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Span<Contentprotectioncaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), pDecodeProfile, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), pCaps);
    }

    /// <summary>To be documented.</summary>
    public static int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, Span<Contentprotectioncaps> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContentProtectionCaps(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel, void** pChannelHandle) where TI0 : unmanaged, IComVtbl<IDirect3DAuthenticatedChannel9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAuthenticatedChannel(ChannelType, (IDirect3DAuthenticatedChannel9**) ppAuthenticatedChannel.GetAddressOf(), pChannelHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, ref ComPtr<TI0> ppAuthenticatedChannel, ref void* pChannelHandle) where TI0 : unmanaged, IComVtbl<IDirect3DAuthenticatedChannel9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAuthenticatedChannel(ChannelType, (IDirect3DAuthenticatedChannel9**) ppAuthenticatedChannel.GetAddressOf(), ref pChannelHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref ComPtr<TI0> ppCryptoSession, void** pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, SilkMarshal.GuidPtrOf<TI0>(), (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, ref ComPtr<TI0> ppCryptoSession, ref void* pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, SilkMarshal.GuidPtrOf<TI0>(), (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile.GetPinnableReference(), ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref ComPtr<TI0> ppCryptoSession, void** pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile, (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile.GetPinnableReference(), ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref ComPtr<TI0> ppCryptoSession, ref void* pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile, (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile.GetPinnableReference(), ref ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(pCryptoType, in pDecodeProfile.GetPinnableReference(), ref ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecodeProfile, ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref ComPtr<TI0> ppCryptoSession, void** pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, SilkMarshal.GuidPtrOf<TI0>(), (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecodeProfile, ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, ref ComPtr<TI0> ppCryptoSession, ref void* pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, SilkMarshal.GuidPtrOf<TI0>(), (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecodeProfile, ref ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), pDecodeProfile, ref ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref ComPtr<TI0> ppCryptoSession, void** pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, in pDecodeProfile, (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pDecodeProfile, ref ComPtr<TI0> ppCryptoSession, ref void* pCryptoHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCryptoSession9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCryptoSession(in pCryptoType, in pDecodeProfile, (IDirect3DCryptoSession9**) ppCryptoSession.GetAddressOf(), ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), ref ppCryptoSession, pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pDecodeProfile, ref IDirect3DCryptoSession9* ppCryptoSession, ref void* pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCryptoSession(in pCryptoType.GetPinnableReference(), in pDecodeProfile.GetPinnableReference(), ref ppCryptoSession, ref pCryptoHandle);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DDevice9Video> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
