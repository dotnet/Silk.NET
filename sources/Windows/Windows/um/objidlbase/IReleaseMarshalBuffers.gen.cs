// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IReleaseMarshalBuffers.xml' path='doc/member[@name="IReleaseMarshalBuffers"]/*' />
[Guid("EB0CB9E8-7996-11D2-872E-0000F8080859")]
[NativeTypeName("struct IReleaseMarshalBuffers : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IReleaseMarshalBuffers : IReleaseMarshalBuffers.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReleaseMarshalBuffers));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers*, Guid*, void**, int>)(lpVtbl[0]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers*, uint>)(lpVtbl[1]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers*, uint>)(lpVtbl[2]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IReleaseMarshalBuffers.xml' path='doc/member[@name="IReleaseMarshalBuffers.ReleaseMarshalBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReleaseMarshalBuffer(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD")] uint dwFlags, IUnknown* pChnl)
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers*, RPCOLEMESSAGE*, uint, IUnknown*, int>)(lpVtbl[3]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this), pMsg, dwFlags, pChnl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReleaseMarshalBuffer(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD")] uint dwFlags, IUnknown* pChnl);
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

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint, IUnknown*, int> ReleaseMarshalBuffer;
    }
}
