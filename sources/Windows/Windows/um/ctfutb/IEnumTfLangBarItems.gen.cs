// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfLangBarItems.xml' path='doc/member[@name="IEnumTfLangBarItems"]/*'/>
[Guid("583F34D0-DE25-11D2-AFDD-00105A2799B5")]
[NativeTypeName("struct IEnumTfLangBarItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfLangBarItems : IEnumTfLangBarItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfLangBarItems));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, uint> )(lpVtbl[1]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, uint> )(lpVtbl[2]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfLangBarItems.xml' path='doc/member[@name="IEnumTfLangBarItems.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfLangBarItems** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, IEnumTfLangBarItems**, int> )(lpVtbl[3]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfLangBarItems.xml' path='doc/member[@name="IEnumTfLangBarItems.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItem** ppItem, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, uint, ITfLangBarItem**, uint*, int> )(lpVtbl[4]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ulCount, ppItem, pcFetched);
    }

    /// <include file='IEnumTfLangBarItems.xml' path='doc/member[@name="IEnumTfLangBarItems.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, int> )(lpVtbl[5]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfLangBarItems.xml' path='doc/member[@name="IEnumTfLangBarItems.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfLangBarItems*, uint, int> )(lpVtbl[6]))((IEnumTfLangBarItems*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfLangBarItems** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItem** ppItem, [NativeTypeName("ULONG *")] uint* pcFetched);
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
        [NativeTypeName("HRESULT (IEnumTfLangBarItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfLangBarItems**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfLangBarItem **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfLangBarItem**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}