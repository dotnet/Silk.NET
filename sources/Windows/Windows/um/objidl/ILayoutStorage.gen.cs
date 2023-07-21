// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage"]/*' />
[Guid("0E6D4D90-6738-11CF-9608-00AA00680DB4")]
[NativeTypeName("struct ILayoutStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILayoutStorage : ILayoutStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILayoutStorage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILayoutStorage*, Guid*, void**, int>)(lpVtbl[0]))((ILayoutStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILayoutStorage*, uint>)(lpVtbl[1]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILayoutStorage*, uint>)(lpVtbl[2]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage.LayoutScript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LayoutScript(StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag)
    {
        return ((delegate* unmanaged<ILayoutStorage*, StorageLayout*, uint, uint, int>)(lpVtbl[3]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pStorageLayout, nEntries, glfInterleavedFlag);
    }

    /// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage.BeginMonitor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginMonitor()
    {
        return ((delegate* unmanaged<ILayoutStorage*, int>)(lpVtbl[4]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage.EndMonitor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndMonitor()
    {
        return ((delegate* unmanaged<ILayoutStorage*, int>)(lpVtbl[5]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage.ReLayoutDocfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReLayoutDocfile([NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName)
    {
        return ((delegate* unmanaged<ILayoutStorage*, ushort*, int>)(lpVtbl[6]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pwcsNewDfName);
    }

    /// <include file='ILayoutStorage.xml' path='doc/member[@name="ILayoutStorage.ReLayoutDocfileOnILockBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReLayoutDocfileOnILockBytes(ILockBytes* pILockBytes)
    {
        return ((delegate* unmanaged<ILayoutStorage*, ILockBytes*, int>)(lpVtbl[7]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pILockBytes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LayoutScript(StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag);

        [VtblIndex(4)]
        HRESULT BeginMonitor();

        [VtblIndex(5)]
        HRESULT EndMonitor();

        [VtblIndex(6)]
        HRESULT ReLayoutDocfile([NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName);

        [VtblIndex(7)]
        HRESULT ReLayoutDocfileOnILockBytes(ILockBytes* pILockBytes);
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

        [NativeTypeName("HRESULT (StorageLayout *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, StorageLayout*, uint, uint, int> LayoutScript;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginMonitor;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndMonitor;

        [NativeTypeName("HRESULT (OLECHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ReLayoutDocfile;

        [NativeTypeName("HRESULT (ILockBytes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ILockBytes*, int> ReLayoutDocfileOnILockBytes;
    }
}
