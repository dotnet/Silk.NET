// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPinConnection.xml' path='doc/member[@name="IPinConnection"]/*'/>
[Guid("4A9A62D3-27D4-403D-91E9-89F540E55534")]
[NativeTypeName("struct IPinConnection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPinConnection : IPinConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPinConnection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPinConnection*, Guid*, void**, int> )(lpVtbl[0]))((IPinConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPinConnection*, uint> )(lpVtbl[1]))((IPinConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPinConnection*, uint> )(lpVtbl[2]))((IPinConnection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPinConnection.xml' path='doc/member[@name="IPinConnection.DynamicQueryAccept"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DynamicQueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IPinConnection*, AM_MEDIA_TYPE*, int> )(lpVtbl[3]))((IPinConnection*)Unsafe.AsPointer(ref this), pmt);
    }

    /// <include file='IPinConnection.xml' path='doc/member[@name="IPinConnection.NotifyEndOfStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyEndOfStream(HANDLE hNotifyEvent)
    {
        return ((delegate* unmanaged<IPinConnection*, HANDLE, int> )(lpVtbl[4]))((IPinConnection*)Unsafe.AsPointer(ref this), hNotifyEvent);
    }

    /// <include file='IPinConnection.xml' path='doc/member[@name="IPinConnection.IsEndPin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsEndPin()
    {
        return ((delegate* unmanaged<IPinConnection*, int> )(lpVtbl[5]))((IPinConnection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPinConnection.xml' path='doc/member[@name="IPinConnection.DynamicDisconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DynamicDisconnect()
    {
        return ((delegate* unmanaged<IPinConnection*, int> )(lpVtbl[6]))((IPinConnection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DynamicQueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);
        [VtblIndex(4)]
        HRESULT NotifyEndOfStream(HANDLE hNotifyEvent);
        [VtblIndex(5)]
        HRESULT IsEndPin();
        [VtblIndex(6)]
        HRESULT DynamicDisconnect();
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
        [NativeTypeName("HRESULT (const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, int> DynamicQueryAccept;
        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> NotifyEndOfStream;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEndPin;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DynamicDisconnect;
    }
}