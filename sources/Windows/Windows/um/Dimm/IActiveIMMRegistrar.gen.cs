// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IActiveIMMRegistrar.xml' path='doc/member[@name="IActiveIMMRegistrar"]/*' />
[Guid("B3458082-BD00-11D1-939B-0060B067B86E")]
[NativeTypeName("struct IActiveIMMRegistrar : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActiveIMMRegistrar : IActiveIMMRegistrar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIMMRegistrar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIMMRegistrar*, uint>)(lpVtbl[1]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIMMRegistrar*, uint>)(lpVtbl[2]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMRegistrar.xml' path='doc/member[@name="IActiveIMMRegistrar.RegisterIME"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterIME([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort lgid, [NativeTypeName("LPCWSTR")] ushort* pszIconFile, [NativeTypeName("LPCWSTR")] ushort* pszDesc)
    {
        return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, ushort, ushort*, ushort*, int>)(lpVtbl[3]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), rclsid, lgid, pszIconFile, pszDesc);
    }

    /// <include file='IActiveIMMRegistrar.xml' path='doc/member[@name="IActiveIMMRegistrar.UnregisterIME"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterIME([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, int>)(lpVtbl[4]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), rclsid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterIME([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort lgid, [NativeTypeName("LPCWSTR")] ushort* pszIconFile, [NativeTypeName("LPCWSTR")] ushort* pszDesc);

        [VtblIndex(4)]
        HRESULT UnregisterIME([NativeTypeName("const IID &")] Guid* rclsid);
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

        [NativeTypeName("HRESULT (const IID &, LANGID, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, ushort*, ushort*, int> RegisterIME;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> UnregisterIME;
    }
}
