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

public unsafe static class MFMediaEngineSrcElementsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineSrcElements> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineSrcElements> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLength(this ComPtr<IMFMediaEngineSrcElements> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetURL(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, char** pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[4])(@this, index, pURL);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetURL(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, ref char* pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pURLPtr = &pURL)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[4])(@this, index, pURLPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetType(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, char** pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[5])(@this, index, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetType(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, ref char* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[5])(@this, index, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMedia(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, char** pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[6])(@this, index, pMedia);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMedia(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, ref char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pMediaPtr = &pMedia)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, uint, char**, int>)@this->LpVtbl[6])(@this, index, pMediaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, char* pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMedia);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, char* pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pMediaPtr = &pMedia)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMediaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pType, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, ref char pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMedia);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, ref char pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTypePtr = &pType)
        {
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTypePtr = &pType)
        {
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMedia);
        SilkMarshal.Free((nint)pTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        fixed (char* pMediaPtr = &pMedia)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
        }
        SilkMarshal.Free((nint)pTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURL, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        SilkMarshal.Free((nint)pTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, char* pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMedia);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, char* pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, ref char pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            fixed (char* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, ref char pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            fixed (char* pTypePtr = &pType)
            {
                fixed (char* pMediaPtr = &pMedia)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            fixed (char* pTypePtr = &pType)
            {
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
        SilkMarshal.Free((nint)pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            }
        SilkMarshal.Free((nint)pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, ref char pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, char*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        SilkMarshal.Free((nint)pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMedia);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        fixed (char* pMediaPtr = &pMedia)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
        }
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pType, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        fixed (char* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
        }
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        fixed (char* pTypePtr = &pType)
        {
            fixed (char* pMediaPtr = &pMedia)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
            }
        }
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, ref char pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        fixed (char* pTypePtr = &pType)
        {
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, char*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        }
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMedia);
        SilkMarshal.Free((nint)pTypePtr);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, ref char pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        fixed (char* pMediaPtr = &pMedia)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, byte*, char*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
        }
        SilkMarshal.Free((nint)pTypePtr);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        var pTypePtr = (byte*) SilkMarshal.StringToPtr(pType, NativeStringEncoding.BStr);
        var pMediaPtr = (byte*) SilkMarshal.StringToPtr(pMedia, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, byte*, byte*, byte*, int>)@this->LpVtbl[7])(@this, pURLPtr, pTypePtr, pMediaPtr);
        SilkMarshal.Free((nint)pMediaPtr);
        SilkMarshal.Free((nint)pTypePtr);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllElements(this ComPtr<IMFMediaEngineSrcElements> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineSrcElements*, int>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetURL(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, string[] pURLSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pURL = (char**) SilkMarshal.StringArrayToPtr(pURLSa);
        var ret = @this->GetURL(index, pURL);
        SilkMarshal.CopyPtrToStringArray((nint) pURL, pURLSa);
        SilkMarshal.Free((nint) pURL);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetType(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, string[] pTypeSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pType = (char**) SilkMarshal.StringArrayToPtr(pTypeSa);
        var ret = @this->GetType(index, pType);
        SilkMarshal.CopyPtrToStringArray((nint) pType, pTypeSa);
        SilkMarshal.Free((nint) pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMedia(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, uint index, string[] pMediaSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pMedia = (char**) SilkMarshal.StringArrayToPtr(pMediaSa);
        var ret = @this->GetMedia(index, pMedia);
        SilkMarshal.CopyPtrToStringArray((nint) pMedia, pMediaSa);
        SilkMarshal.Free((nint) pMedia);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, char* pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, Span<char> pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, Span<char> pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, Span<char> pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, char* pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, char* pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, char* pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, char* pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, Span<char> pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, Span<char> pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), ref pType.GetPinnableReference(), ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, Span<char> pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, pMedia);
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, Span<char> pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(ref pURL.GetPinnableReference(), pType, pMedia);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, char* pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, Span<char> pType, char* pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, Span<char> pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, Span<char> pType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, ref pType.GetPinnableReference(), pMedia);
    }

    /// <summary>To be documented.</summary>
    public static int AddElement(this ComPtr<IMFMediaEngineSrcElements> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pType, Span<char> pMedia)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddElement(pURL, pType, ref pMedia.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineSrcElements> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
