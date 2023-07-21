// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IObjectWithSite.xml' path='doc/member[@name="IObjectWithSite"]/*' />
[Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")]
[NativeTypeName("struct IObjectWithSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithSite : IObjectWithSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithSite));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithSite*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectWithSite*, uint>)(lpVtbl[1]))((IObjectWithSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithSite*, uint>)(lpVtbl[2]))((IObjectWithSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectWithSite.xml' path='doc/member[@name="IObjectWithSite.SetSite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSite(IUnknown* pUnkSite)
    {
        return ((delegate* unmanaged<IObjectWithSite*, IUnknown*, int>)(lpVtbl[3]))((IObjectWithSite*)Unsafe.AsPointer(ref this), pUnkSite);
    }

    /// <include file='IObjectWithSite.xml' path='doc/member[@name="IObjectWithSite.GetSite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSite([NativeTypeName("const IID &")] Guid* riid, void** ppvSite)
    {
        return ((delegate* unmanaged<IObjectWithSite*, Guid*, void**, int>)(lpVtbl[4]))((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvSite);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSite(IUnknown* pUnkSite);

        [VtblIndex(4)]
        HRESULT GetSite([NativeTypeName("const IID &")] Guid* riid, void** ppvSite);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetSite;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetSite;
    }
}
