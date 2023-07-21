// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFSecureChannel.xml' path='doc/member[@name="IMFSecureChannel"]/*' />
[Guid("D0AE555D-3B12-4D97-B060-0990BC5AEB67")]
[NativeTypeName("struct IMFSecureChannel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSecureChannel : IMFSecureChannel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSecureChannel));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSecureChannel*, Guid*, void**, int>)(lpVtbl[0]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSecureChannel*, uint>)(lpVtbl[1]))((IMFSecureChannel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSecureChannel*, uint>)(lpVtbl[2]))((IMFSecureChannel*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSecureChannel.xml' path='doc/member[@name="IMFSecureChannel.GetCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificate(byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert)
    {
        return ((delegate* unmanaged<IMFSecureChannel*, byte**, uint*, int>)(lpVtbl[3]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), ppCert, pcbCert);
    }

    /// <include file='IMFSecureChannel.xml' path='doc/member[@name="IMFSecureChannel.SetupSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetupSession(byte* pbEncryptedSessionKey, [NativeTypeName("DWORD")] uint cbSessionKey)
    {
        return ((delegate* unmanaged<IMFSecureChannel*, byte*, uint, int>)(lpVtbl[4]))((IMFSecureChannel*)Unsafe.AsPointer(ref this), pbEncryptedSessionKey, cbSessionKey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCertificate(byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert);

        [VtblIndex(4)]
        HRESULT SetupSession(byte* pbEncryptedSessionKey, [NativeTypeName("DWORD")] uint cbSessionKey);
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

        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetCertificate;

        [NativeTypeName("HRESULT (BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetupSession;
    }
}
