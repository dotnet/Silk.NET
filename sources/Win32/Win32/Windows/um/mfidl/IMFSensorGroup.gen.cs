// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4110243A-9757-461F-89F1-F22345BCAB4E")]
[NativeTypeName("struct IMFSensorGroup : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IMFSensorGroup : IMFSensorGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorGroup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorGroup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSensorGroup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorGroup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSymbolicLink(
        [NativeTypeName("LPWSTR")] ushort* SymbolicLink,
        [NativeTypeName("LONG")] int cchSymbolicLink,
        [NativeTypeName("LONG *")] int* pcchWritten
    )
    {
        return ((delegate* unmanaged<IMFSensorGroup, ushort*, int, int*, int>)((*lpVtbl)[3]))(
            this,
            SymbolicLink,
            cchSymbolicLink,
            pcchWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags)
    {
        return ((delegate* unmanaged<IMFSensorGroup, ulong*, int>)((*lpVtbl)[4]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSensorGroupAttributes(IMFAttributes* ppAttributes)
    {
        return ((delegate* unmanaged<IMFSensorGroup, IMFAttributes*, int>)((*lpVtbl)[5]))(
            this,
            ppAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSensorDeviceCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFSensorGroup, uint*, int>)((*lpVtbl)[6]))(this, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSensorDevice(
        [NativeTypeName("DWORD")] uint dwIndex,
        IMFSensorDevice* ppDevice
    )
    {
        return ((delegate* unmanaged<IMFSensorGroup, uint, IMFSensorDevice*, int>)((*lpVtbl)[7]))(
            this,
            dwIndex,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDefaultSensorDeviceIndex([NativeTypeName("DWORD")] uint dwIndex)
    {
        return ((delegate* unmanaged<IMFSensorGroup, uint, int>)((*lpVtbl)[8]))(this, dwIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaultSensorDeviceIndex([NativeTypeName("DWORD *")] uint* pdwIndex)
    {
        return ((delegate* unmanaged<IMFSensorGroup, uint*, int>)((*lpVtbl)[9]))(this, pdwIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateMediaSource(IMFMediaSource* ppSource)
    {
        return ((delegate* unmanaged<IMFSensorGroup, IMFMediaSource*, int>)((*lpVtbl)[10]))(
            this,
            ppSource
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSymbolicLink(
            [NativeTypeName("LPWSTR")] ushort* SymbolicLink,
            [NativeTypeName("LONG")] int cchSymbolicLink,
            [NativeTypeName("LONG *")] int* pcchWritten
        );

        [VtblIndex(4)]
        HRESULT GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags);

        [VtblIndex(5)]
        HRESULT GetSensorGroupAttributes(IMFAttributes* ppAttributes);

        [VtblIndex(6)]
        HRESULT GetSensorDeviceCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(7)]
        HRESULT GetSensorDevice([NativeTypeName("DWORD")] uint dwIndex, IMFSensorDevice* ppDevice);

        [VtblIndex(8)]
        HRESULT SetDefaultSensorDeviceIndex([NativeTypeName("DWORD")] uint dwIndex);

        [VtblIndex(9)]
        HRESULT GetDefaultSensorDeviceIndex([NativeTypeName("DWORD *")] uint* pdwIndex);

        [VtblIndex(10)]
        HRESULT CreateMediaSource(IMFMediaSource* ppSource);
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

        [NativeTypeName("HRESULT (LPWSTR, LONG, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> GetSymbolicLink;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetFlags;

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> GetSensorGroupAttributes;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSensorDeviceCount;

        [NativeTypeName("HRESULT (DWORD, IMFSensorDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSensorDevice*, int> GetSensorDevice;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetDefaultSensorDeviceIndex;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDefaultSensorDeviceIndex;

        [NativeTypeName("HRESULT (IMFMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSource*, int> CreateMediaSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSensorGroup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSensorGroup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSensorGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSensorGroup(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSensorGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSensorGroup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSensorGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSensorGroup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
