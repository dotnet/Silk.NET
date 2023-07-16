// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITimeAndNoticeControl.xml' path='doc/member[@name="ITimeAndNoticeControl"]/*'/>
[Guid("BC0BF6AE-8878-11D1-83E9-00C04FC2C6D4")]
[NativeTypeName("struct ITimeAndNoticeControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITimeAndNoticeControl : ITimeAndNoticeControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimeAndNoticeControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimeAndNoticeControl*, Guid*, void**, int> )(lpVtbl[0]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITimeAndNoticeControl*, uint> )(lpVtbl[1]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimeAndNoticeControl*, uint> )(lpVtbl[2]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITimeAndNoticeControl.xml' path='doc/member[@name="ITimeAndNoticeControl.SuppressChanges"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SuppressChanges([NativeTypeName("DWORD")] uint res1, [NativeTypeName("DWORD")] uint res2)
    {
        return ((delegate* unmanaged<ITimeAndNoticeControl*, uint, uint, int> )(lpVtbl[3]))((ITimeAndNoticeControl*)Unsafe.AsPointer(ref this), res1, res2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SuppressChanges([NativeTypeName("DWORD")] uint res1, [NativeTypeName("DWORD")] uint res2);
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
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SuppressChanges;
    }
}