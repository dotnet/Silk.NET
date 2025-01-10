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

[Guid("FB9F48F2-2A18-4E28-9730-786F30F04DC4")]
[NativeTypeName("struct IMFSensorDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IMFSensorDevice : IMFSensorDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSensorDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDeviceId([NativeTypeName("ULONGLONG *")] ulong* pDeviceId)
    {
        return ((delegate* unmanaged<IMFSensorDevice, ulong*, int>)((*lpVtbl)[3]))(this, pDeviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDeviceType(MFSensorDeviceType* pType)
    {
        return ((delegate* unmanaged<IMFSensorDevice, MFSensorDeviceType*, int>)((*lpVtbl)[4]))(
            this,
            pType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags)
    {
        return ((delegate* unmanaged<IMFSensorDevice, ulong*, int>)((*lpVtbl)[5]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSymbolicLink(
        [NativeTypeName("LPWSTR")] ushort* SymbolicLink,
        [NativeTypeName("LONG")] int cchSymbolicLink,
        [NativeTypeName("LONG *")] int* pcchWritten
    )
    {
        return ((delegate* unmanaged<IMFSensorDevice, ushort*, int, int*, int>)((*lpVtbl)[6]))(
            this,
            SymbolicLink,
            cchSymbolicLink,
            pcchWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceAttributes(IMFAttributes* ppAttributes)
    {
        return ((delegate* unmanaged<IMFSensorDevice, IMFAttributes*, int>)((*lpVtbl)[7]))(
            this,
            ppAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamAttributesCount(
        MFSensorStreamType eType,
        [NativeTypeName("DWORD *")] uint* pdwCount
    )
    {
        return (
            (delegate* unmanaged<IMFSensorDevice, MFSensorStreamType, uint*, int>)((*lpVtbl)[8])
        )(this, eType, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetStreamAttributes(
        MFSensorStreamType eType,
        [NativeTypeName("DWORD")] uint dwIndex,
        IMFAttributes* ppAttributes
    )
    {
        return (
            (delegate* unmanaged<IMFSensorDevice, MFSensorStreamType, uint, IMFAttributes*, int>)(
                (*lpVtbl)[9]
            )
        )(this, eType, dwIndex, ppAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSensorDeviceMode(MFSensorDeviceMode eMode)
    {
        return ((delegate* unmanaged<IMFSensorDevice, MFSensorDeviceMode, int>)((*lpVtbl)[10]))(
            this,
            eMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSensorDeviceMode(MFSensorDeviceMode* peMode)
    {
        return ((delegate* unmanaged<IMFSensorDevice, MFSensorDeviceMode*, int>)((*lpVtbl)[11]))(
            this,
            peMode
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDeviceId([NativeTypeName("ULONGLONG *")] ulong* pDeviceId);

        [VtblIndex(4)]
        HRESULT GetDeviceType(MFSensorDeviceType* pType);

        [VtblIndex(5)]
        HRESULT GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags);

        [VtblIndex(6)]
        HRESULT GetSymbolicLink(
            [NativeTypeName("LPWSTR")] ushort* SymbolicLink,
            [NativeTypeName("LONG")] int cchSymbolicLink,
            [NativeTypeName("LONG *")] int* pcchWritten
        );

        [VtblIndex(7)]
        HRESULT GetDeviceAttributes(IMFAttributes* ppAttributes);

        [VtblIndex(8)]
        HRESULT GetStreamAttributesCount(
            MFSensorStreamType eType,
            [NativeTypeName("DWORD *")] uint* pdwCount
        );

        [VtblIndex(9)]
        HRESULT GetStreamAttributes(
            MFSensorStreamType eType,
            [NativeTypeName("DWORD")] uint dwIndex,
            IMFAttributes* ppAttributes
        );

        [VtblIndex(10)]
        HRESULT SetSensorDeviceMode(MFSensorDeviceMode eMode);

        [VtblIndex(11)]
        HRESULT GetSensorDeviceMode(MFSensorDeviceMode* peMode);
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

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetDeviceId;

        [NativeTypeName("HRESULT (MFSensorDeviceType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSensorDeviceType*, int> GetDeviceType;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetFlags;

        [NativeTypeName("HRESULT (LPWSTR, LONG, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> GetSymbolicLink;

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> GetDeviceAttributes;

        [NativeTypeName("HRESULT (MFSensorStreamType, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSensorStreamType, uint*, int> GetStreamAttributesCount;

        [NativeTypeName(
            "HRESULT (MFSensorStreamType, DWORD, IMFAttributes **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFSensorStreamType,
            uint,
            IMFAttributes*,
            int> GetStreamAttributes;

        [NativeTypeName("HRESULT (MFSensorDeviceMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSensorDeviceMode, int> SetSensorDeviceMode;

        [NativeTypeName("HRESULT (MFSensorDeviceMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSensorDeviceMode*, int> GetSensorDeviceMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSensorDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSensorDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSensorDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSensorDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSensorDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSensorDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSensorDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSensorDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
