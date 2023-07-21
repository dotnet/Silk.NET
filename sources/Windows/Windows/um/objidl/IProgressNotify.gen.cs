// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IProgressNotify.xml' path='doc/member[@name="IProgressNotify"]/*' />
[Guid("A9D758A0-4617-11CF-95FC-00AA00680DB4")]
[NativeTypeName("struct IProgressNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProgressNotify : IProgressNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProgressNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProgressNotify*, Guid*, void**, int>)(lpVtbl[0]))((IProgressNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProgressNotify*, uint>)(lpVtbl[1]))((IProgressNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProgressNotify*, uint>)(lpVtbl[2]))((IProgressNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProgressNotify.xml' path='doc/member[@name="IProgressNotify.OnProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnProgress([NativeTypeName("DWORD")] uint dwProgressCurrent, [NativeTypeName("DWORD")] uint dwProgressMaximum, BOOL fAccurate, BOOL fOwner)
    {
        return ((delegate* unmanaged<IProgressNotify*, uint, uint, BOOL, BOOL, int>)(lpVtbl[3]))((IProgressNotify*)Unsafe.AsPointer(ref this), dwProgressCurrent, dwProgressMaximum, fAccurate, fOwner);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnProgress([NativeTypeName("DWORD")] uint dwProgressCurrent, [NativeTypeName("DWORD")] uint dwProgressMaximum, BOOL fAccurate, BOOL fOwner);
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

        [NativeTypeName("HRESULT (DWORD, DWORD, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, BOOL, int> OnProgress;
    }
}
