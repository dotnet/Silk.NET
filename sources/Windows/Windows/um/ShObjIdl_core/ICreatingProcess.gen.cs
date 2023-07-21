// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICreatingProcess.xml' path='doc/member[@name="ICreatingProcess"]/*' />
[Guid("C2B937A9-3110-4398-8A56-F34C6342D244")]
[NativeTypeName("struct ICreatingProcess : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreatingProcess : ICreatingProcess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreatingProcess));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreatingProcess*, Guid*, void**, int>)(lpVtbl[0]))((ICreatingProcess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICreatingProcess*, uint>)(lpVtbl[1]))((ICreatingProcess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreatingProcess*, uint>)(lpVtbl[2]))((ICreatingProcess*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreatingProcess.xml' path='doc/member[@name="ICreatingProcess.OnCreating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnCreating(ICreateProcessInputs* pcpi)
    {
        return ((delegate* unmanaged<ICreatingProcess*, ICreateProcessInputs*, int>)(lpVtbl[3]))((ICreatingProcess*)Unsafe.AsPointer(ref this), pcpi);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnCreating(ICreateProcessInputs* pcpi);
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

        [NativeTypeName("HRESULT (ICreateProcessInputs *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICreateProcessInputs*, int> OnCreating;
    }
}
