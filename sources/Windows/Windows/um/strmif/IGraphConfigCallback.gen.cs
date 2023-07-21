// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IGraphConfigCallback.xml' path='doc/member[@name="IGraphConfigCallback"]/*' />
[Guid("ADE0FD60-D19D-11D2-ABF6-00A0C905F375")]
[NativeTypeName("struct IGraphConfigCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphConfigCallback : IGraphConfigCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphConfigCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphConfigCallback*, Guid*, void**, int>)(lpVtbl[0]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[1]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[2]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphConfigCallback.xml' path='doc/member[@name="IGraphConfigCallback.Reconfigure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reconfigure([NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IGraphConfigCallback*, void*, uint, int>)(lpVtbl[3]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), pvContext, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reconfigure([NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName("HRESULT (PVOID, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, int> Reconfigure;
    }
}
