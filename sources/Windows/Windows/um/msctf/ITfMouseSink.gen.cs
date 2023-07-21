// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfMouseSink.xml' path='doc/member[@name="ITfMouseSink"]/*' />
[Guid("A1ADAAA2-3A24-449D-AC96-5183E7F5C217")]
[NativeTypeName("struct ITfMouseSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMouseSink : ITfMouseSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMouseSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMouseSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfMouseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfMouseSink*, uint>)(lpVtbl[1]))((ITfMouseSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMouseSink*, uint>)(lpVtbl[2]))((ITfMouseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMouseSink.xml' path='doc/member[@name="ITfMouseSink.OnMouseEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnMouseEvent([NativeTypeName("ULONG")] uint uEdge, [NativeTypeName("ULONG")] uint uQuadrant, [NativeTypeName("DWORD")] uint dwBtnStatus, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfMouseSink*, uint, uint, uint, BOOL*, int>)(lpVtbl[3]))((ITfMouseSink*)Unsafe.AsPointer(ref this), uEdge, uQuadrant, dwBtnStatus, pfEaten);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnMouseEvent([NativeTypeName("ULONG")] uint uEdge, [NativeTypeName("ULONG")] uint uQuadrant, [NativeTypeName("DWORD")] uint dwBtnStatus, BOOL* pfEaten);
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

        [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, BOOL*, int> OnMouseEvent;
    }
}
