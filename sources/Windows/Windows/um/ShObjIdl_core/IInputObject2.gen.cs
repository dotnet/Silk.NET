// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IInputObject2.xml' path='doc/member[@name="IInputObject2"]/*' />
[Guid("6915C085-510B-44CD-94AF-28DFA56CF92B")]
[NativeTypeName("struct IInputObject2 : IInputObject")]
[NativeInheritance("IInputObject")]
public unsafe partial struct IInputObject2 : IInputObject2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputObject2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInputObject2*, Guid*, void**, int>)(lpVtbl[0]))((IInputObject2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInputObject2*, uint>)(lpVtbl[1]))((IInputObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInputObject2*, uint>)(lpVtbl[2]))((IInputObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInputObject.UIActivateIO" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UIActivateIO(BOOL fActivate, MSG* pMsg)
    {
        return ((delegate* unmanaged<IInputObject2*, BOOL, MSG*, int>)(lpVtbl[3]))((IInputObject2*)Unsafe.AsPointer(ref this), fActivate, pMsg);
    }

    /// <inheritdoc cref="IInputObject.HasFocusIO" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HasFocusIO()
    {
        return ((delegate* unmanaged<IInputObject2*, int>)(lpVtbl[4]))((IInputObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInputObject.TranslateAcceleratorIO" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAcceleratorIO(MSG* pMsg)
    {
        return ((delegate* unmanaged<IInputObject2*, MSG*, int>)(lpVtbl[5]))((IInputObject2*)Unsafe.AsPointer(ref this), pMsg);
    }

    /// <include file='IInputObject2.xml' path='doc/member[@name="IInputObject2.TranslateAcceleratorGlobal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TranslateAcceleratorGlobal(MSG* pMsg)
    {
        return ((delegate* unmanaged<IInputObject2*, MSG*, int>)(lpVtbl[6]))((IInputObject2*)Unsafe.AsPointer(ref this), pMsg);
    }

    public interface Interface : IInputObject.Interface
    {
        [VtblIndex(6)]
        HRESULT TranslateAcceleratorGlobal(MSG* pMsg);
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

        [NativeTypeName("HRESULT (BOOL, MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, MSG*, int> UIActivateIO;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasFocusIO;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorIO;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorGlobal;
    }
}
