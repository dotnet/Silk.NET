// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB533D5D-2DB6-40F8-97A9-494692014F07")]
[NativeTypeName("struct IMFDXGIDeviceManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFDXGIDeviceManager : IMFDXGIDeviceManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDXGIDeviceManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFDXGIDeviceManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CloseDeviceHandle(HANDLE hDevice)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, HANDLE, int>)((*lpVtbl)[3]))(
            this,
            hDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetVideoService(
        HANDLE hDevice,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppService
    )
    {
        return (
            (delegate* unmanaged<IMFDXGIDeviceManager, HANDLE, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, hDevice, riid, ppService);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LockDevice(
        HANDLE hDevice,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppUnkDevice,
        BOOL fBlock
    )
    {
        return (
            (delegate* unmanaged<IMFDXGIDeviceManager, HANDLE, Guid*, void**, BOOL, int>)(
                (*lpVtbl)[5]
            )
        )(this, hDevice, riid, ppUnkDevice, fBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenDeviceHandle(HANDLE* phDevice)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, HANDLE*, int>)((*lpVtbl)[6]))(
            this,
            phDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetDevice(IUnknown pUnkDevice, uint resetToken)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, IUnknown, uint, int>)((*lpVtbl)[7]))(
            this,
            pUnkDevice,
            resetToken
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TestDevice(HANDLE hDevice)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, HANDLE, int>)((*lpVtbl)[8]))(
            this,
            hDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnlockDevice(HANDLE hDevice, BOOL fSaveState)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManager, HANDLE, BOOL, int>)((*lpVtbl)[9]))(
            this,
            hDevice,
            fSaveState
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CloseDeviceHandle(HANDLE hDevice);

        [VtblIndex(4)]
        HRESULT GetVideoService(
            HANDLE hDevice,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppService
        );

        [VtblIndex(5)]
        HRESULT LockDevice(
            HANDLE hDevice,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppUnkDevice,
            BOOL fBlock
        );

        [VtblIndex(6)]
        HRESULT OpenDeviceHandle(HANDLE* phDevice);

        [VtblIndex(7)]
        HRESULT ResetDevice(IUnknown pUnkDevice, uint resetToken);

        [VtblIndex(8)]
        HRESULT TestDevice(HANDLE hDevice);

        [VtblIndex(9)]
        HRESULT UnlockDevice(HANDLE hDevice, BOOL fSaveState);
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

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> CloseDeviceHandle;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> GetVideoService;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, BOOL, int> LockDevice;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> OpenDeviceHandle;

        [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> ResetDevice;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> TestDevice;

        [NativeTypeName("HRESULT (HANDLE, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, BOOL, int> UnlockDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFDXGIDeviceManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFDXGIDeviceManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFDXGIDeviceManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFDXGIDeviceManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFDXGIDeviceManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFDXGIDeviceManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFDXGIDeviceManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFDXGIDeviceManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
