// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAudioSessionEnumerator.xml' path='doc/member[@name="IAudioSessionEnumerator"]/*' />
[Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8")]
[NativeTypeName("struct IAudioSessionEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionEnumerator : IAudioSessionEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionEnumerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator*, uint>)(lpVtbl[1]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator*, uint>)(lpVtbl[2]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSessionEnumerator.xml' path='doc/member[@name="IAudioSessionEnumerator.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(int* SessionCount)
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator*, int*, int>)(lpVtbl[3]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount);
    }

    /// <include file='IAudioSessionEnumerator.xml' path='doc/member[@name="IAudioSessionEnumerator.GetSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSession(int SessionCount, IAudioSessionControl** Session)
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator*, int, IAudioSessionControl**, int>)(lpVtbl[4]))((IAudioSessionEnumerator*)Unsafe.AsPointer(ref this), SessionCount, Session);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(int* SessionCount);

        [VtblIndex(4)]
        HRESULT GetSession(int SessionCount, IAudioSessionControl** Session);
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

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetCount;

        [NativeTypeName("HRESULT (int, IAudioSessionControl **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IAudioSessionControl**, int> GetSession;
    }
}
