// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfUIElements.xml' path='doc/member[@name="IEnumTfUIElements"]/*'/>
[Guid("887AA91E-ACBA-4931-84DA-3C5208CF543F")]
[NativeTypeName("struct IEnumTfUIElements : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfUIElements : IEnumTfUIElements.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfUIElements));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, uint> )(lpVtbl[1]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, uint> )(lpVtbl[2]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfUIElements.xml' path='doc/member[@name="IEnumTfUIElements.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfUIElements** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, IEnumTfUIElements**, int> )(lpVtbl[3]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfUIElements.xml' path='doc/member[@name="IEnumTfUIElements.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfUIElement** ppElement, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, uint, ITfUIElement**, uint*, int> )(lpVtbl[4]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ulCount, ppElement, pcFetched);
    }

    /// <include file='IEnumTfUIElements.xml' path='doc/member[@name="IEnumTfUIElements.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, int> )(lpVtbl[5]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfUIElements.xml' path='doc/member[@name="IEnumTfUIElements.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfUIElements*, uint, int> )(lpVtbl[6]))((IEnumTfUIElements*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfUIElements** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfUIElement** ppElement, [NativeTypeName("ULONG *")] uint* pcFetched);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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
        [NativeTypeName("HRESULT (IEnumTfUIElements **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfUIElements**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfUIElement **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfUIElement**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}