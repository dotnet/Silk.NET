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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaKeys2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaKeys2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaKeys2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* customDataPtr = &customData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)customDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)customDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)customDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeType, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
                fixed (byte* customDataPtr = &customData)
                {
                    fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                    {
                        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
        SilkMarshal.Free((nint)customDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
        SilkMarshal.Free((nint)customDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
            fixed (byte* initDataPtr = &initData)
            {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
        SilkMarshal.Free((nint)customDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* mimeTypePtr = &mimeType)
        {
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* customDataPtr = &customData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initData, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
                }
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
                }
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
            fixed (byte* customDataPtr = &customData)
            {
                fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
                {
                    fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        fixed (byte* initDataPtr = &initData)
        {
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        SilkMarshal.Free((nint)customDataPtr);
        }
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customData, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        fixed (byte* customDataPtr = &customData)
        {
            fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
            {
                fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
                }
            }
        }
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSession);
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notify, ppSessionPtr);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSession);
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var mimeTypePtr = (byte*) SilkMarshal.StringToPtr(mimeType, NativeStringEncoding.BStr);
        var initDataPtr = (byte*) SilkMarshal.StringToPtr(initData, NativeStringEncoding.UTF8);
        var customDataPtr = (byte*) SilkMarshal.StringToPtr(customData, NativeStringEncoding.UTF8);
        fixed (IMFMediaKeySessionNotify* notifyPtr = &notify)
        {
            fixed (IMFMediaKeySession** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)@this->LpVtbl[3])(@this, mimeTypePtr, initDataPtr, cb, customDataPtr, cbCustomData, notifyPtr, ppSessionPtr);
            }
        }
        SilkMarshal.Free((nint)customDataPtr);
        SilkMarshal.Free((nint)initDataPtr);
        SilkMarshal.Free((nint)mimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeys2> thisVtbl, char** keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeys2> thisVtbl, ref char* keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Shutdown(this ComPtr<IMFMediaKeys2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSuspendNotify(this ComPtr<IMFMediaKeys2> thisVtbl, IMFCdmSuspendNotify** notify)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notify);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSuspendNotify(this ComPtr<IMFMediaKeys2> thisVtbl, ref IMFCdmSuspendNotify* notify)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFCdmSuspendNotify** notifyPtr = &notify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, IMFCdmSuspendNotify**, int>)@this->LpVtbl[6])(@this, notifyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2, IMFMediaKeySession2** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySession2** ppSessionPtr = &ppSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2, ppSessionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, IMFMediaKeySession2** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2Ptr = &pMFMediaKeySessionNotify2)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2Ptr, ppSession);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2Ptr = &pMFMediaKeySessionNotify2)
        {
            fixed (IMFMediaKeySession2** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)@this->LpVtbl[7])(@this, eSessionType, pMFMediaKeySessionNotify2Ptr, ppSessionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetServerCertificate(this ComPtr<IMFMediaKeys2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbServerCertificate, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificate, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetServerCertificate(this ComPtr<IMFMediaKeys2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbServerCertificate, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbServerCertificatePtr = &pbServerCertificate)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificatePtr, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetServerCertificate(this ComPtr<IMFMediaKeys2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbServerCertificate, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbServerCertificatePtr = (byte*) SilkMarshal.StringToPtr(pbServerCertificate, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)@this->LpVtbl[8])(@this, pbServerCertificatePtr, cb);
        SilkMarshal.Free((nint)pbServerCertificatePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDOMException(this ComPtr<IMFMediaKeys2> thisVtbl, int systemCode, int* code)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int, int*, int>)@this->LpVtbl[9])(@this, systemCode, code);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDOMException(this ComPtr<IMFMediaKeys2> thisVtbl, int systemCode, ref int code)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* codePtr = &code)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int, int*, int>)@this->LpVtbl[9])(@this, systemCode, codePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeys2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, char* mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref char mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(ref mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, Span<char> mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(ref mimeType.GetPinnableReference(), initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, in initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, in initData.GetPinnableReference(), cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, IMFMediaKeySessionNotify* notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, notify, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, in customData.GetPinnableReference(), cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ComPtr<TI0> notify, ref IMFMediaKeySession* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, (IMFMediaKeySessionNotify*) notify.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, IMFMediaKeySession** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, ref IMFMediaKeySessionNotify notify, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify, (IMFMediaKeySession**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession(this ComPtr<IMFMediaKeys2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string mimeType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string initData, uint cb, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string customData, uint cbCustomData, Span<IMFMediaKeySessionNotify> notify, ref IMFMediaKeySession* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession(mimeType, initData, cb, customData, cbCustomData, ref notify.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int GetKeySystem(this ComPtr<IMFMediaKeys2> thisVtbl, string[] keySystemSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var keySystem = (char**) SilkMarshal.StringArrayToPtr(keySystemSa);
        var ret = @this->GetKeySystem(keySystem);
        SilkMarshal.CopyPtrToStringArray((nint) keySystem, keySystemSa);
        SilkMarshal.Free((nint) keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSuspendNotify<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, ref ComPtr<TI0> notify) where TI0 : unmanaged, IComVtbl<IMFCdmSuspendNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSuspendNotify((IMFCdmSuspendNotify**) notify.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession2<TI0, TI1>(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, ComPtr<TI0> pMFMediaKeySessionNotify2, ref ComPtr<TI1> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify2>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFMediaKeySession2>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession2(eSessionType, (IMFMediaKeySessionNotify2*) pMFMediaKeySessionNotify2.Handle, (IMFMediaKeySession2**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, ComPtr<TI0> pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySessionNotify2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession2(eSessionType, (IMFMediaKeySessionNotify2*) pMFMediaKeySessionNotify2.Handle, ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, Span<IMFMediaKeySessionNotify2> pMFMediaKeySessionNotify2, IMFMediaKeySession2** ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession2(eSessionType, ref pMFMediaKeySessionNotify2.GetPinnableReference(), ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSession2<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, ref IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, ref ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<IMFMediaKeySession2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSession2(eSessionType, ref pMFMediaKeySessionNotify2, (IMFMediaKeySession2**) ppSession.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSession2(this ComPtr<IMFMediaKeys2> thisVtbl, MF_MEDIAKEYSESSION_TYPE eSessionType, Span<IMFMediaKeySessionNotify2> pMFMediaKeySessionNotify2, ref IMFMediaKeySession2* ppSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSession2(eSessionType, ref pMFMediaKeySessionNotify2.GetPinnableReference(), ref ppSession);
    }

    /// <summary>To be documented.</summary>
    public static int SetServerCertificate(this ComPtr<IMFMediaKeys2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbServerCertificate, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetServerCertificate(in pbServerCertificate.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static int GetDOMException(this ComPtr<IMFMediaKeys2> thisVtbl, int systemCode, Span<int> code)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDOMException(systemCode, ref code.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaKeys2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
