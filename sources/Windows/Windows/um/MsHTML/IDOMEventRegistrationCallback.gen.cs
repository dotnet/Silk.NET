// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback"]/*' />
[Guid("3051083B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMEventRegistrationCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDOMEventRegistrationCallback : IDOMEventRegistrationCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMEventRegistrationCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMEventRegistrationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMEventRegistrationCallback*, uint>)(lpVtbl[1]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMEventRegistrationCallback*, uint>)(lpVtbl[2]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback.OnDOMEventListenerAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDOMEventListenerAdded([NativeTypeName("LPCWSTR")] ushort* pszEventType, IScriptEventHandler* pHandler)
    {
        return ((delegate* unmanaged<IDOMEventRegistrationCallback*, ushort*, IScriptEventHandler*, int>)(lpVtbl[3]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), pszEventType, pHandler);
    }

    /// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback.OnDOMEventListenerRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDOMEventListenerRemoved([NativeTypeName("ULONGLONG")] ulong ullCookie)
    {
        return ((delegate* unmanaged<IDOMEventRegistrationCallback*, ulong, int>)(lpVtbl[4]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), ullCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDOMEventListenerAdded([NativeTypeName("LPCWSTR")] ushort* pszEventType, IScriptEventHandler* pHandler);

        [VtblIndex(4)]
        HRESULT OnDOMEventListenerRemoved([NativeTypeName("ULONGLONG")] ulong ullCookie);
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

        [NativeTypeName("HRESULT (LPCWSTR, IScriptEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IScriptEventHandler*, int> OnDOMEventListenerAdded;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> OnDOMEventListenerRemoved;
    }
}
