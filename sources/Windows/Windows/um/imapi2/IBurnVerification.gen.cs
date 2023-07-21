// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBurnVerification.xml' path='doc/member[@name="IBurnVerification"]/*' />
[Guid("D2FFD834-958B-426D-8470-2A13879C6A91")]
[NativeTypeName("struct IBurnVerification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBurnVerification : IBurnVerification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBurnVerification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBurnVerification*, Guid*, void**, int>)(lpVtbl[0]))((IBurnVerification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[1]))((IBurnVerification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[2]))((IBurnVerification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBurnVerification.xml' path='doc/member[@name="IBurnVerification.put_BurnVerificationLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value)
    {
        return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL, int>)(lpVtbl[3]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBurnVerification.xml' path='doc/member[@name="IBurnVerification.get_BurnVerificationLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL* value)
    {
        return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL*, int>)(lpVtbl[4]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value);

        [VtblIndex(4)]
        HRESULT get_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL* value);
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

        [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_BURN_VERIFICATION_LEVEL, int> put_BurnVerificationLevel;

        [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_BURN_VERIFICATION_LEVEL*, int> get_BurnVerificationLevel;
    }
}
