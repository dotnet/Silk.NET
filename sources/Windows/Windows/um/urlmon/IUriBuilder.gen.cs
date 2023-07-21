// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder"]/*' />
[Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
[NativeTypeName("struct IUriBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUriBuilder : IUriBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriBuilder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUriBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUriBuilder*, uint>)(lpVtbl[1]))((IUriBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUriBuilder*, uint>)(lpVtbl[2]))((IUriBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUriSimple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint, nuint, IUri**, int>)(lpVtbl[3]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint, uint, nuint, IUri**, int>)(lpVtbl[4]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUriWithFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint, uint, uint, nuint, IUri**, int>)(lpVtbl[5]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetIUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIUri(IUri** ppIUri)
    {
        return ((delegate* unmanaged<IUriBuilder*, IUri**, int>)(lpVtbl[6]))((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetIUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIUri(IUri* pIUri)
    {
        return ((delegate* unmanaged<IUriBuilder*, IUri*, int>)(lpVtbl[7]))((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[8]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[9]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[10]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[11]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPort(BOOL* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
    {
        return ((delegate* unmanaged<IUriBuilder*, BOOL*, uint*, int>)(lpVtbl[12]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[13]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetSchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[14]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[15]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[16]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[17]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[18]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[19]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetPort(BOOL fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, BOOL, uint, int>)(lpVtbl[20]))((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[21]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetSchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[22]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
    {
        return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[23]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.RemoveProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
    {
        return ((delegate* unmanaged<IUriBuilder*, uint, int>)(lpVtbl[24]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.HasBeenModified"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT HasBeenModified(BOOL* pfModified)
    {
        return ((delegate* unmanaged<IUriBuilder*, BOOL*, int>)(lpVtbl[25]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(4)]
        HRESULT CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(5)]
        HRESULT CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(6)]
        HRESULT GetIUri(IUri** ppIUri);

        [VtblIndex(7)]
        HRESULT SetIUri(IUri* pIUri);

        [VtblIndex(8)]
        HRESULT GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment);

        [VtblIndex(9)]
        HRESULT GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost);

        [VtblIndex(10)]
        HRESULT GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword);

        [VtblIndex(11)]
        HRESULT GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath);

        [VtblIndex(12)]
        HRESULT GetPort(BOOL* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort);

        [VtblIndex(13)]
        HRESULT GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery);

        [VtblIndex(14)]
        HRESULT GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName);

        [VtblIndex(15)]
        HRESULT GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName);

        [VtblIndex(16)]
        HRESULT SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(17)]
        HRESULT SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(18)]
        HRESULT SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(19)]
        HRESULT SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(20)]
        HRESULT SetPort(BOOL fHasPort, [NativeTypeName("DWORD")] uint dwNewValue);

        [VtblIndex(21)]
        HRESULT SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(22)]
        HRESULT SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(23)]
        HRESULT SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [VtblIndex(24)]
        HRESULT RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask);

        [VtblIndex(25)]
        HRESULT HasBeenModified(BOOL* pfModified);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nuint, IUri**, int> CreateUriSimple;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, nuint, IUri**, int> CreateUri;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, nuint, IUri**, int> CreateUriWithFlags;

        [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri**, int> GetIUri;

        [NativeTypeName("HRESULT (IUri *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri*, int> SetIUri;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetFragment;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetHost;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetPassword;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetPath;

        [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, uint*, int> GetPort;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetQuery;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetSchemeName;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetUserName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetFragment;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetHost;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetPassword;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetPath;

        [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, uint, int> SetPort;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetQuery;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSchemeName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetUserName;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveProperties;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> HasBeenModified;
    }
}
