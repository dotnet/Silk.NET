// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumDiscRecorders.xml' path='doc/member[@name="IEnumDiscRecorders"]/*' />
[Guid("9B1921E1-54AC-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IEnumDiscRecorders : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumDiscRecorders : IEnumDiscRecorders.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumDiscRecorders));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, uint>)(lpVtbl[1]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, uint>)(lpVtbl[2]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDiscRecorders.xml' path='doc/member[@name="IEnumDiscRecorders.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cRecorders, IDiscRecorder** ppRecorder, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, uint, IDiscRecorder**, uint*, int>)(lpVtbl[3]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), cRecorders, ppRecorder, pcFetched);
    }

    /// <include file='IEnumDiscRecorders.xml' path='doc/member[@name="IEnumDiscRecorders.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cRecorders)
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, uint, int>)(lpVtbl[4]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), cRecorders);
    }

    /// <include file='IEnumDiscRecorders.xml' path='doc/member[@name="IEnumDiscRecorders.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, int>)(lpVtbl[5]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDiscRecorders.xml' path='doc/member[@name="IEnumDiscRecorders.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumDiscRecorders** ppEnum)
    {
        return ((delegate* unmanaged<IEnumDiscRecorders*, IEnumDiscRecorders**, int>)(lpVtbl[6]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cRecorders, IDiscRecorder** ppRecorder, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cRecorders);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumDiscRecorders** ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, IDiscRecorder **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiscRecorder**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumDiscRecorders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDiscRecorders**, int> Clone;
    }
}
