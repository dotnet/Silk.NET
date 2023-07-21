// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver"]/*' />
[Guid("FBE5A32D-A497-4B61-BB85-97B1A848A6E3")]
[NativeTypeName("struct IMFSourceResolver : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSourceResolver : IMFSourceResolver.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceResolver));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceResolver*, uint>)(lpVtbl[1]))((IMFSourceResolver*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceResolver*, uint>)(lpVtbl[2]))((IMFSourceResolver*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.CreateObjectFromURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[3]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pwszURL, dwFlags, pProps, pObjectType, ppObject);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.CreateObjectFromByteStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, IMFByteStream*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[4]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, pObjectType, ppObject);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.BeginCreateObjectFromURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginCreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.EndCreateObjectFromURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndCreateObjectFromURL(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[6]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.BeginCreateObjectFromByteStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BeginCreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[7]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.EndCreateObjectFromByteStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EndCreateObjectFromByteStream(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[8]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
    }

    /// <include file='IMFSourceResolver.xml' path='doc/member[@name="IMFSourceResolver.CancelObjectCreation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie)
    {
        return ((delegate* unmanaged<IMFSourceResolver*, IUnknown*, int>)(lpVtbl[9]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject);

        [VtblIndex(4)]
        HRESULT CreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject);

        [VtblIndex(5)]
        HRESULT BeginCreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(6)]
        HRESULT EndCreateObjectFromURL(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject);

        [VtblIndex(7)]
        HRESULT BeginCreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(8)]
        HRESULT EndCreateObjectFromByteStream(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject);

        [VtblIndex(9)]
        HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie);
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, IPropertyStore *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int> CreateObjectFromURL;

        [NativeTypeName("HRESULT (IMFByteStream *, LPCWSTR, DWORD, IPropertyStore *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int> CreateObjectFromByteStream;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, IPropertyStore *, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int> BeginCreateObjectFromURL;

        [NativeTypeName("HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int> EndCreateObjectFromURL;

        [NativeTypeName("HRESULT (IMFByteStream *, LPCWSTR, DWORD, IPropertyStore *, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int> BeginCreateObjectFromByteStream;

        [NativeTypeName("HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int> EndCreateObjectFromByteStream;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> CancelObjectCreation;
    }
}
