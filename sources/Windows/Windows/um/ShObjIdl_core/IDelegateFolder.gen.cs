// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDelegateFolder.xml' path='doc/member[@name="IDelegateFolder"]/*'/>
[Guid("ADD8BA80-002B-11D0-8F0F-00C04FD7D062")]
[NativeTypeName("struct IDelegateFolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDelegateFolder : IDelegateFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDelegateFolder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDelegateFolder*, Guid*, void**, int> )(lpVtbl[0]))((IDelegateFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDelegateFolder*, uint> )(lpVtbl[1]))((IDelegateFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDelegateFolder*, uint> )(lpVtbl[2]))((IDelegateFolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDelegateFolder.xml' path='doc/member[@name="IDelegateFolder.SetItemAlloc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetItemAlloc(IMalloc* pmalloc)
    {
        return ((delegate* unmanaged<IDelegateFolder*, IMalloc*, int> )(lpVtbl[3]))((IDelegateFolder*)Unsafe.AsPointer(ref this), pmalloc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetItemAlloc(IMalloc* pmalloc);
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
        [NativeTypeName("HRESULT (IMalloc *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMalloc*, int> SetItemAlloc;
    }
}