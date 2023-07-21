// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMStreamSelect.xml' path='doc/member[@name="IAMStreamSelect"]/*' />
[Guid("C1960960-17F5-11D1-ABE1-00A0C905F375")]
[NativeTypeName("struct IAMStreamSelect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMStreamSelect : IAMStreamSelect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMStreamSelect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMStreamSelect*, Guid*, void**, int>)(lpVtbl[0]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMStreamSelect*, uint>)(lpVtbl[1]))((IAMStreamSelect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMStreamSelect*, uint>)(lpVtbl[2]))((IAMStreamSelect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMStreamSelect.xml' path='doc/member[@name="IAMStreamSelect.Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Count([NativeTypeName("DWORD *")] uint* pcStreams)
    {
        return ((delegate* unmanaged<IAMStreamSelect*, uint*, int>)(lpVtbl[3]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), pcStreams);
    }

    /// <include file='IAMStreamSelect.xml' path='doc/member[@name="IAMStreamSelect.Info"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Info([NativeTypeName("long")] int lIndex, AM_MEDIA_TYPE** ppmt, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LCID *")] uint* plcid, [NativeTypeName("DWORD *")] uint* pdwGroup, [NativeTypeName("LPWSTR *")] ushort** ppszName, IUnknown** ppObject, IUnknown** ppUnk)
    {
        return ((delegate* unmanaged<IAMStreamSelect*, int, AM_MEDIA_TYPE**, uint*, uint*, uint*, ushort**, IUnknown**, IUnknown**, int>)(lpVtbl[4]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), lIndex, ppmt, pdwFlags, plcid, pdwGroup, ppszName, ppObject, ppUnk);
    }

    /// <include file='IAMStreamSelect.xml' path='doc/member[@name="IAMStreamSelect.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Enable([NativeTypeName("long")] int lIndex, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IAMStreamSelect*, int, uint, int>)(lpVtbl[5]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), lIndex, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Count([NativeTypeName("DWORD *")] uint* pcStreams);

        [VtblIndex(4)]
        HRESULT Info([NativeTypeName("long")] int lIndex, AM_MEDIA_TYPE** ppmt, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LCID *")] uint* plcid, [NativeTypeName("DWORD *")] uint* pdwGroup, [NativeTypeName("LPWSTR *")] ushort** ppszName, IUnknown** ppObject, IUnknown** ppUnk);

        [VtblIndex(5)]
        HRESULT Enable([NativeTypeName("long")] int lIndex, [NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Count;

        [NativeTypeName("HRESULT (long, AM_MEDIA_TYPE **, DWORD *, LCID *, DWORD *, LPWSTR *, IUnknown **, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, AM_MEDIA_TYPE**, uint*, uint*, uint*, ushort**, IUnknown**, IUnknown**, int> Info;

        [NativeTypeName("HRESULT (long, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, int> Enable;
    }
}
