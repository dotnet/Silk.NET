// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISyncMgrRegister.xml' path='doc/member[@name="ISyncMgrRegister"]/*' />
[Guid("6295DF42-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrRegister : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrRegister : ISyncMgrRegister.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrRegister));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, uint>)(lpVtbl[1]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, uint>)(lpVtbl[2]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrRegister.xml' path='doc/member[@name="ISyncMgrRegister.RegisterSyncMgrHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPCWSTR")] ushort* pwszDescription, [NativeTypeName("DWORD")] uint dwSyncMgrRegisterFlags)
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, ushort*, uint, int>)(lpVtbl[3]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, pwszDescription, dwSyncMgrRegisterFlags);
    }

    /// <include file='ISyncMgrRegister.xml' path='doc/member[@name="ISyncMgrRegister.UnregisterSyncMgrHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, uint, int>)(lpVtbl[4]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, dwReserved);
    }

    /// <include file='ISyncMgrRegister.xml' path='doc/member[@name="ISyncMgrRegister.GetHandlerRegistrationInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHandlerRegistrationInfo([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPDWORD")] uint* pdwSyncMgrRegisterFlags)
    {
        return ((delegate* unmanaged<ISyncMgrRegister*, Guid*, uint*, int>)(lpVtbl[5]))((ISyncMgrRegister*)Unsafe.AsPointer(ref this), clsidHandler, pdwSyncMgrRegisterFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPCWSTR")] ushort* pwszDescription, [NativeTypeName("DWORD")] uint dwSyncMgrRegisterFlags);

        [VtblIndex(4)]
        HRESULT UnregisterSyncMgrHandler([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(5)]
        HRESULT GetHandlerRegistrationInfo([NativeTypeName("const IID &")] Guid* clsidHandler, [NativeTypeName("LPDWORD")] uint* pdwSyncMgrRegisterFlags);
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

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, int> RegisterSyncMgrHandler;

        [NativeTypeName("HRESULT (const IID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> UnregisterSyncMgrHandler;

        [NativeTypeName("HRESULT (const IID &, LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetHandlerRegistrationInfo;
    }
}
