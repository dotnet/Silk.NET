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

public unsafe static class MFMediaEngineExtensionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, char* MimeType, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeType, pAnswer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, char* MimeType, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeType, pAnswerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, ref char MimeType, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* MimeTypePtr = &MimeType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, ref char MimeType, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* MimeTypePtr = &MimeType)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string MimeType, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var MimeTypePtr = (byte*) SilkMarshal.StringToPtr(MimeType, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswer);
        SilkMarshal.Free((nint)MimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string MimeType, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var MimeTypePtr = (byte*) SilkMarshal.StringToPtr(MimeType, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Bool32, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, AudioOnly, MimeTypePtr, pAnswerPtr);
        }
        SilkMarshal.Free((nint)MimeTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURL, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrURLPtr = &bstrURL)
        {
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
                {
                    fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, char*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStream, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkState);
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallback, punkStatePtr);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkState);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookie, pCallbackPtr, punkStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkState);
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallback, punkStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkState);
                }
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrURLPtr = (byte*) SilkMarshal.StringToPtr(bstrURL, NativeStringEncoding.BStr);
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookiePtr = &ppIUnknownCancelCookie)
            {
                fixed (IMFAsyncCallback* pCallbackPtr = &pCallback)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* punkStatePtr = &punkState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, byte*, IMFByteStream*, MF_OBJECT_TYPE, Silk.NET.Core.Native.IUnknown**, IMFAsyncCallback*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, bstrURLPtr, pByteStreamPtr, type, ppIUnknownCancelCookiePtr, pCallbackPtr, punkStatePtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)bstrURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CancelObjectCreation(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Native.IUnknown* pIUnknownCancelCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, pIUnknownCancelCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CancelObjectCreation(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref Silk.NET.Core.Native.IUnknown pIUnknownCancelCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pIUnknownCancelCookiePtr = &pIUnknownCancelCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, pIUnknownCancelCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, IMFAsyncResult* pResult, Silk.NET.Core.Native.IUnknown** ppObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResult, ppObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, IMFAsyncResult* pResult, ref Silk.NET.Core.Native.IUnknown* ppObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppObjectPtr = &ppObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResult, ppObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref IMFAsyncResult pResult, Silk.NET.Core.Native.IUnknown** ppObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAsyncResult* pResultPtr = &pResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResultPtr, ppObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref IMFAsyncResult pResult, ref Silk.NET.Core.Native.IUnknown* ppObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFAsyncResult* pResultPtr = &pResult)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppObjectPtr = &ppObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineExtension*, IMFAsyncResult*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[6])(@this, pResultPtr, ppObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, char* MimeType, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(AudioOnly, MimeType, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, Span<char> MimeType, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(AudioOnly, ref MimeType.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, Span<char> MimeType, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(AudioOnly, ref MimeType.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineExtension> thisVtbl, Silk.NET.Core.Bool32 AudioOnly, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string MimeType, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(AudioOnly, MimeType, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, char* bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ref ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref char bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(ref bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<char> bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(ref bstrURL.GetPinnableReference(), ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static int BeginCreateObject<TI0, TI1>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI1> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, Silk.NET.Core.Native.IUnknown** ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref ComPtr<TI0> ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ref Silk.NET.Core.Native.IUnknown punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, (Silk.NET.Core.Native.IUnknown**) ppIUnknownCancelCookie.GetAddressOf(), ref pCallback, ref punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, pCallback, ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Silk.NET.Core.Native.IUnknown* punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), punkState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, ref IMFByteStream pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, ref IMFAsyncCallback pCallback, ComPtr<TI0> punkState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream, type, ref ppIUnknownCancelCookie, ref pCallback, (Silk.NET.Core.Native.IUnknown*) punkState.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrURL, Span<IMFByteStream> pByteStream, MF_OBJECT_TYPE type, ref Silk.NET.Core.Native.IUnknown* ppIUnknownCancelCookie, Span<IMFAsyncCallback> pCallback, Span<Silk.NET.Core.Native.IUnknown> punkState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginCreateObject(bstrURL, ref pByteStream.GetPinnableReference(), type, ref ppIUnknownCancelCookie, ref pCallback.GetPinnableReference(), ref punkState.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CancelObjectCreation<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ComPtr<TI0> pIUnknownCancelCookie) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CancelObjectCreation((Silk.NET.Core.Native.IUnknown*) pIUnknownCancelCookie.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CancelObjectCreation(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pIUnknownCancelCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CancelObjectCreation(ref pIUnknownCancelCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, IMFAsyncResult* pResult, ref ComPtr<TI0> ppObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EndCreateObject(pResult, (Silk.NET.Core.Native.IUnknown**) ppObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<IMFAsyncResult> pResult, Silk.NET.Core.Native.IUnknown** ppObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndCreateObject(ref pResult.GetPinnableReference(), ppObject);
    }

    /// <summary>To be documented.</summary>
    public static int EndCreateObject<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl, ref IMFAsyncResult pResult, ref ComPtr<TI0> ppObject) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EndCreateObject(ref pResult, (Silk.NET.Core.Native.IUnknown**) ppObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndCreateObject(this ComPtr<IMFMediaEngineExtension> thisVtbl, Span<IMFAsyncResult> pResult, ref Silk.NET.Core.Native.IUnknown* ppObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EndCreateObject(ref pResult.GetPinnableReference(), ref ppObject);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineExtension> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
