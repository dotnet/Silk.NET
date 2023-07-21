// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IInitializeCommand.xml' path='doc/member[@name="IInitializeCommand"]/*' />
[Guid("85075ACF-231F-40EA-9610-D26B7B58F638")]
[NativeTypeName("struct IInitializeCommand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeCommand : IInitializeCommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeCommand));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeCommand*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeCommand*, uint>)(lpVtbl[1]))((IInitializeCommand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeCommand*, uint>)(lpVtbl[2]))((IInitializeCommand*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInitializeCommand.xml' path='doc/member[@name="IInitializeCommand.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszCommandName, IPropertyBag* ppb)
    {
        return ((delegate* unmanaged<IInitializeCommand*, ushort*, IPropertyBag*, int>)(lpVtbl[3]))((IInitializeCommand*)Unsafe.AsPointer(ref this), pszCommandName, ppb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszCommandName, IPropertyBag* ppb);
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

        [NativeTypeName("HRESULT (LPCWSTR, IPropertyBag *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IPropertyBag*, int> Initialize;
    }
}
