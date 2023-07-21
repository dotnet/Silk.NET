// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IRegisterServiceProvider.xml' path='doc/member[@name="IRegisterServiceProvider"]/*' />
[Guid("7B3A2F01-0751-48DD-B556-004785171C54")]
[NativeTypeName("struct IRegisterServiceProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRegisterServiceProvider : IRegisterServiceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRegisterServiceProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRegisterServiceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRegisterServiceProvider*, uint>)(lpVtbl[1]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRegisterServiceProvider*, uint>)(lpVtbl[2]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRegisterServiceProvider.xml' path='doc/member[@name="IRegisterServiceProvider.RegisterService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterService([NativeTypeName("const GUID &")] Guid* guidService, IUnknown* pUnkObject)
    {
        return ((delegate* unmanaged<IRegisterServiceProvider*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IRegisterServiceProvider*)Unsafe.AsPointer(ref this), guidService, pUnkObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterService([NativeTypeName("const GUID &")] Guid* guidService, IUnknown* pUnkObject);
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

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> RegisterService;
    }
}
