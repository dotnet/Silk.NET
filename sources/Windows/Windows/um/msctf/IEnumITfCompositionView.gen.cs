// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumITfCompositionView.xml' path='doc/member[@name="IEnumITfCompositionView"]/*'/>
[Guid("5EFD22BA-7838-46CB-88E2-CADB14124F8F")]
[NativeTypeName("struct IEnumITfCompositionView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumITfCompositionView : IEnumITfCompositionView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumITfCompositionView));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, Guid*, void**, int> )(lpVtbl[0]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, uint> )(lpVtbl[1]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, uint> )(lpVtbl[2]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumITfCompositionView.xml' path='doc/member[@name="IEnumITfCompositionView.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumITfCompositionView** ppEnum)
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, IEnumITfCompositionView**, int> )(lpVtbl[3]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumITfCompositionView.xml' path='doc/member[@name="IEnumITfCompositionView.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfCompositionView** rgCompositionView, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, uint, ITfCompositionView**, uint*, int> )(lpVtbl[4]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ulCount, rgCompositionView, pcFetched);
    }

    /// <include file='IEnumITfCompositionView.xml' path='doc/member[@name="IEnumITfCompositionView.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, int> )(lpVtbl[5]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumITfCompositionView.xml' path='doc/member[@name="IEnumITfCompositionView.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumITfCompositionView*, uint, int> )(lpVtbl[6]))((IEnumITfCompositionView*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumITfCompositionView** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfCompositionView** rgCompositionView, [NativeTypeName("ULONG *")] uint* pcFetched);
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
        [NativeTypeName("HRESULT (IEnumITfCompositionView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumITfCompositionView**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfCompositionView **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfCompositionView**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}