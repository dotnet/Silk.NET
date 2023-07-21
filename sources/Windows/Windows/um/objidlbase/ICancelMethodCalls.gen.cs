// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICancelMethodCalls.xml' path='doc/member[@name="ICancelMethodCalls"]/*' />
[Guid("00000029-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICancelMethodCalls : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICancelMethodCalls : ICancelMethodCalls.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICancelMethodCalls));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICancelMethodCalls*, Guid*, void**, int>)(lpVtbl[0]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICancelMethodCalls*, uint>)(lpVtbl[1]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICancelMethodCalls*, uint>)(lpVtbl[2]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICancelMethodCalls.xml' path='doc/member[@name="ICancelMethodCalls.Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Cancel([NativeTypeName("ULONG")] uint ulSeconds)
    {
        return ((delegate* unmanaged<ICancelMethodCalls*, uint, int>)(lpVtbl[3]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this), ulSeconds);
    }

    /// <include file='ICancelMethodCalls.xml' path='doc/member[@name="ICancelMethodCalls.TestCancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TestCancel()
    {
        return ((delegate* unmanaged<ICancelMethodCalls*, int>)(lpVtbl[4]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Cancel([NativeTypeName("ULONG")] uint ulSeconds);

        [VtblIndex(4)]
        HRESULT TestCancel();
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

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Cancel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TestCancel;
    }
}
