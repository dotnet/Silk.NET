// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumTfRanges.xml' path='doc/member[@name="IEnumTfRanges"]/*'/>
[Guid("F99D3F40-8E32-11D2-BF46-00105A2799B5")]
[NativeTypeName("struct IEnumTfRanges : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfRanges : IEnumTfRanges.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfRanges));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfRanges*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfRanges*, uint> )(lpVtbl[1]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfRanges*, uint> )(lpVtbl[2]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfRanges.xml' path='doc/member[@name="IEnumTfRanges.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfRanges** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfRanges*, IEnumTfRanges**, int> )(lpVtbl[3]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfRanges.xml' path='doc/member[@name="IEnumTfRanges.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfRange** ppRange, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumTfRanges*, uint, ITfRange**, uint*, int> )(lpVtbl[4]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ulCount, ppRange, pcFetched);
    }

    /// <include file='IEnumTfRanges.xml' path='doc/member[@name="IEnumTfRanges.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfRanges*, int> )(lpVtbl[5]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfRanges.xml' path='doc/member[@name="IEnumTfRanges.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfRanges*, uint, int> )(lpVtbl[6]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfRanges** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfRange** ppRange, [NativeTypeName("ULONG *")] uint* pcFetched);
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
        [NativeTypeName("HRESULT (IEnumTfRanges **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfRanges**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfRange **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}