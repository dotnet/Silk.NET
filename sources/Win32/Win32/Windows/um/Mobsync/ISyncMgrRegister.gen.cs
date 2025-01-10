// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6295DF42-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrRegister : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrRegister : ISyncMgrRegister.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrRegister));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrRegister, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrRegister, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrRegister, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterSyncMgrHandler(
        [NativeTypeName("const IID &")] Guid* clsidHandler,
        [NativeTypeName("LPCWSTR")] ushort* pwszDescription,
        [NativeTypeName("DWORD")] uint dwSyncMgrRegisterFlags
    )
    {
        return ((delegate* unmanaged<ISyncMgrRegister, Guid*, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            clsidHandler,
            pwszDescription,
            dwSyncMgrRegisterFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterSyncMgrHandler(
        [NativeTypeName("const IID &")] Guid* clsidHandler,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return ((delegate* unmanaged<ISyncMgrRegister, Guid*, uint, int>)((*lpVtbl)[4]))(
            this,
            clsidHandler,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHandlerRegistrationInfo(
        [NativeTypeName("const IID &")] Guid* clsidHandler,
        [NativeTypeName("LPDWORD")] uint* pdwSyncMgrRegisterFlags
    )
    {
        return ((delegate* unmanaged<ISyncMgrRegister, Guid*, uint*, int>)((*lpVtbl)[5]))(
            this,
            clsidHandler,
            pdwSyncMgrRegisterFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterSyncMgrHandler(
            [NativeTypeName("const IID &")] Guid* clsidHandler,
            [NativeTypeName("LPCWSTR")] ushort* pwszDescription,
            [NativeTypeName("DWORD")] uint dwSyncMgrRegisterFlags
        );

        [VtblIndex(4)]
        HRESULT UnregisterSyncMgrHandler(
            [NativeTypeName("const IID &")] Guid* clsidHandler,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(5)]
        HRESULT GetHandlerRegistrationInfo(
            [NativeTypeName("const IID &")] Guid* clsidHandler,
            [NativeTypeName("LPDWORD")] uint* pdwSyncMgrRegisterFlags
        );
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

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrRegister"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrRegister(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrRegister"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrRegister(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrRegister(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrRegister"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrRegister"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrRegister value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
