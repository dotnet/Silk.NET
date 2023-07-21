// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISynchronizeEvent.xml' path='doc/member[@name="ISynchronizeEvent"]/*' />
[Guid("00000032-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISynchronizeEvent : ISynchronizeHandle")]
[NativeInheritance("ISynchronizeHandle")]
public unsafe partial struct ISynchronizeEvent : ISynchronizeEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISynchronizeEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISynchronizeEvent*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISynchronizeEvent*, uint>)(lpVtbl[1]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISynchronizeEvent*, uint>)(lpVtbl[2]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISynchronizeHandle.GetHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHandle(HANDLE* ph)
    {
        return ((delegate* unmanaged<ISynchronizeEvent*, HANDLE*, int>)(lpVtbl[3]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
    }

    /// <include file='ISynchronizeEvent.xml' path='doc/member[@name="ISynchronizeEvent.SetEventHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEventHandle(HANDLE* ph)
    {
        return ((delegate* unmanaged<ISynchronizeEvent*, HANDLE*, int>)(lpVtbl[4]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
    }

    public interface Interface : ISynchronizeHandle.Interface
    {
        [VtblIndex(4)]
        HRESULT SetEventHandle(HANDLE* ph);
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

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetHandle;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> SetEventHandle;
    }
}
