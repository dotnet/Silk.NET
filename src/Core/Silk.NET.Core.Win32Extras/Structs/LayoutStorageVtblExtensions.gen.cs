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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class LayoutStorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ILayoutStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ILayoutStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LayoutScript(this ComPtr<ILayoutStorage> thisVtbl, StorageLayout* pStorageLayout, uint nEntries, uint glfInterleavedFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, StorageLayout*, uint, uint, int>)@this->LpVtbl[3])(@this, pStorageLayout, nEntries, glfInterleavedFlag);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LayoutScript(this ComPtr<ILayoutStorage> thisVtbl, ref StorageLayout pStorageLayout, uint nEntries, uint glfInterleavedFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (StorageLayout* pStorageLayoutPtr = &pStorageLayout)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, StorageLayout*, uint, uint, int>)@this->LpVtbl[3])(@this, pStorageLayoutPtr, nEntries, glfInterleavedFlag);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginMonitor(this ComPtr<ILayoutStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndMonitor(this ComPtr<ILayoutStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReLayoutDocfile(this ComPtr<ILayoutStorage> thisVtbl, char* pwcsNewDfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, char*, int>)@this->LpVtbl[6])(@this, pwcsNewDfName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfile(this ComPtr<ILayoutStorage> thisVtbl, ref char pwcsNewDfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pwcsNewDfNamePtr = &pwcsNewDfName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, char*, int>)@this->LpVtbl[6])(@this, pwcsNewDfNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfile(this ComPtr<ILayoutStorage> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pwcsNewDfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pwcsNewDfNamePtr = (byte*) SilkMarshal.StringToPtr(pwcsNewDfName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, byte*, int>)@this->LpVtbl[6])(@this, pwcsNewDfNamePtr);
        SilkMarshal.Free((nint)pwcsNewDfNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReLayoutDocfileOnILockBytes(this ComPtr<ILayoutStorage> thisVtbl, ILockBytes* pILockBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, ILockBytes*, int>)@this->LpVtbl[7])(@this, pILockBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfileOnILockBytes(this ComPtr<ILayoutStorage> thisVtbl, ref ILockBytes pILockBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ILockBytes* pILockBytesPtr = &pILockBytes)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILayoutStorage*, ILockBytes*, int>)@this->LpVtbl[7])(@this, pILockBytesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ILayoutStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILayoutStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int LayoutScript(this ComPtr<ILayoutStorage> thisVtbl, Span<StorageLayout> pStorageLayout, uint nEntries, uint glfInterleavedFlag)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LayoutScript(ref pStorageLayout.GetPinnableReference(), nEntries, glfInterleavedFlag);
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfile(this ComPtr<ILayoutStorage> thisVtbl, Span<char> pwcsNewDfName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReLayoutDocfile(ref pwcsNewDfName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfileOnILockBytes<TI0>(this ComPtr<ILayoutStorage> thisVtbl, ComPtr<TI0> pILockBytes) where TI0 : unmanaged, IComVtbl<ILockBytes>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReLayoutDocfileOnILockBytes((ILockBytes*) pILockBytes.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ReLayoutDocfileOnILockBytes(this ComPtr<ILayoutStorage> thisVtbl, Span<ILockBytes> pILockBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReLayoutDocfileOnILockBytes(ref pILockBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ILayoutStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
