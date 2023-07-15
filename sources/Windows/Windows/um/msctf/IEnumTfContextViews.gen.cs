// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfContextViews.xml' path='doc/member[@name="IEnumTfContextViews"]/*'/>
[Guid("F0C0F8DD-CF38-44E1-BB0F-68CF0D551C78")]
[NativeTypeName("struct IEnumTfContextViews : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfContextViews : IEnumTfContextViews.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfContextViews));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, uint> )(lpVtbl[1]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, uint> )(lpVtbl[2]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfContextViews.xml' path='doc/member[@name="IEnumTfContextViews.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfContextViews** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, IEnumTfContextViews**, int> )(lpVtbl[3]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfContextViews.xml' path='doc/member[@name="IEnumTfContextViews.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfContextView** rgViews, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, uint, ITfContextView**, uint*, int> )(lpVtbl[4]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ulCount, rgViews, pcFetched);
    }

    /// <include file='IEnumTfContextViews.xml' path='doc/member[@name="IEnumTfContextViews.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, int> )(lpVtbl[5]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfContextViews.xml' path='doc/member[@name="IEnumTfContextViews.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfContextViews*, uint, int> )(lpVtbl[6]))((IEnumTfContextViews*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfContextViews** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfContextView** rgViews, [NativeTypeName("ULONG *")] uint* pcFetched);
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
        [NativeTypeName("HRESULT (IEnumTfContextViews **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfContextViews**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfContextView **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfContextView**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}