// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ICastingSourceInfo.xml' path='doc/member[@name="ICastingSourceInfo"]/*' />
[Guid("45101AB7-7C3A-4BCE-9500-12C09024B298")]
[NativeTypeName("struct ICastingSourceInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICastingSourceInfo : ICastingSourceInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingSourceInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingSourceInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICastingSourceInfo*, uint>)(lpVtbl[1]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingSourceInfo*, uint>)(lpVtbl[2]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICastingSourceInfo.xml' path='doc/member[@name="ICastingSourceInfo.GetController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetController(ICastingController** controller)
    {
        return ((delegate* unmanaged<ICastingSourceInfo*, ICastingController**, int>)(lpVtbl[3]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), controller);
    }

    /// <include file='ICastingSourceInfo.xml' path='doc/member[@name="ICastingSourceInfo.GetProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(INamedPropertyStore** props)
    {
        return ((delegate* unmanaged<ICastingSourceInfo*, INamedPropertyStore**, int>)(lpVtbl[4]))((ICastingSourceInfo*)Unsafe.AsPointer(ref this), props);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetController(ICastingController** controller);

        [VtblIndex(4)]
        HRESULT GetProperties(INamedPropertyStore** props);
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

        [NativeTypeName("HRESULT (ICastingController **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICastingController**, int> GetController;

        [NativeTypeName("HRESULT (INamedPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, INamedPropertyStore**, int> GetProperties;
    }
}
