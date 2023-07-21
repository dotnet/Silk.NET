// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpPhoneConverter.xml' path='doc/member[@name="ISpPhoneConverter"]/*' />
[Guid("8445C581-0CAC-4A38-ABFE-9B2CE2826455")]
[NativeTypeName("struct ISpPhoneConverter : ISpObjectWithToken")]
[NativeInheritance("ISpObjectWithToken")]
public unsafe partial struct ISpPhoneConverter : ISpPhoneConverter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhoneConverter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, uint>)(lpVtbl[1]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, uint>)(lpVtbl[2]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpObjectWithToken.SetObjectToken" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetObjectToken(ISpObjectToken* pToken)
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, ISpObjectToken*, int>)(lpVtbl[3]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pToken);
    }

    /// <inheritdoc cref="ISpObjectWithToken.GetObjectToken" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectToken(ISpObjectToken** ppToken)
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, ISpObjectToken**, int>)(lpVtbl[4]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), ppToken);
    }

    /// <include file='ISpPhoneConverter.xml' path='doc/member[@name="ISpPhoneConverter.PhoneToId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PhoneToId([NativeTypeName("LPCWSTR")] ushort* pszPhone, [NativeTypeName("SPPHONEID *")] ushort* pId)
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pszPhone, pId);
    }

    /// <include file='ISpPhoneConverter.xml' path='doc/member[@name="ISpPhoneConverter.IdToPhone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IdToPhone([NativeTypeName("PCSPPHONEID")] ushort* pId, [NativeTypeName("WCHAR *")] ushort* pszPhone)
    {
        return ((delegate* unmanaged<ISpPhoneConverter*, ushort*, ushort*, int>)(lpVtbl[6]))((ISpPhoneConverter*)Unsafe.AsPointer(ref this), pId, pszPhone);
    }

    public interface Interface : ISpObjectWithToken.Interface
    {
        [VtblIndex(5)]
        HRESULT PhoneToId([NativeTypeName("LPCWSTR")] ushort* pszPhone, [NativeTypeName("SPPHONEID *")] ushort* pId);

        [VtblIndex(6)]
        HRESULT IdToPhone([NativeTypeName("PCSPPHONEID")] ushort* pId, [NativeTypeName("WCHAR *")] ushort* pszPhone);
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

        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken*, int> SetObjectToken;

        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken**, int> GetObjectToken;

        [NativeTypeName("HRESULT (LPCWSTR, SPPHONEID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> PhoneToId;

        [NativeTypeName("HRESULT (PCSPPHONEID, WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> IdToPhone;
    }
}
