// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAssocHandlerInvoker.xml' path='doc/member[@name="IAssocHandlerInvoker"]/*' />
[Guid("92218CAB-ECAA-4335-8133-807FD234C2EE")]
[NativeTypeName("struct IAssocHandlerInvoker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAssocHandlerInvoker : IAssocHandlerInvoker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAssocHandlerInvoker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAssocHandlerInvoker*, Guid*, void**, int>)(lpVtbl[0]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAssocHandlerInvoker*, uint>)(lpVtbl[1]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAssocHandlerInvoker*, uint>)(lpVtbl[2]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAssocHandlerInvoker.xml' path='doc/member[@name="IAssocHandlerInvoker.SupportsSelection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SupportsSelection()
    {
        return ((delegate* unmanaged<IAssocHandlerInvoker*, int>)(lpVtbl[3]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAssocHandlerInvoker.xml' path='doc/member[@name="IAssocHandlerInvoker.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Invoke()
    {
        return ((delegate* unmanaged<IAssocHandlerInvoker*, int>)(lpVtbl[4]))((IAssocHandlerInvoker*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SupportsSelection();

        [VtblIndex(4)]
        HRESULT Invoke();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SupportsSelection;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Invoke;
    }
}
