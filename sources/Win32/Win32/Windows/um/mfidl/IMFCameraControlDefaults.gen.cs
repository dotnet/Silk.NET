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

[Guid("75510662-B034-48F4-88A7-8DE61DAA4AF9")]
[NativeTypeName("struct IMFCameraControlDefaults : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct IMFCameraControlDefaults
    : IMFCameraControlDefaults.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraControlDefaults));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraControlDefaults, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFCameraControlDefaults, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaults, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new MF_CAMERA_CONTROL_CONFIGURATION_TYPE GetType()
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaults, MF_CAMERA_CONTROL_CONFIGURATION_TYPE>)(
                (*lpVtbl)[3]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRangeInfo(MF_CAMERA_CONTROL_RANGE_INFO* rangeInfo)
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaults, MF_CAMERA_CONTROL_RANGE_INFO*, int>)(
                (*lpVtbl)[4]
            )
        )(this, rangeInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LockControlData(
        void** control,
        [NativeTypeName("ULONG *")] uint* controlSize,
        void** data,
        [NativeTypeName("ULONG *")] uint* dataSize
    )
    {
        return (
            (delegate* unmanaged<IMFCameraControlDefaults, void**, uint*, void**, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, control, controlSize, data, dataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnlockControlData()
    {
        return ((delegate* unmanaged<IMFCameraControlDefaults, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        MF_CAMERA_CONTROL_CONFIGURATION_TYPE GetType();

        [VtblIndex(4)]
        HRESULT GetRangeInfo(MF_CAMERA_CONTROL_RANGE_INFO* rangeInfo);

        [VtblIndex(5)]
        HRESULT LockControlData(
            void** control,
            [NativeTypeName("ULONG *")] uint* controlSize,
            void** data,
            [NativeTypeName("ULONG *")] uint* dataSize
        );

        [VtblIndex(6)]
        HRESULT UnlockControlData();
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

        [NativeTypeName("MF_CAMERA_CONTROL_CONFIGURATION_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, MF_CAMERA_CONTROL_CONFIGURATION_TYPE> GetType;

        [NativeTypeName("HRESULT (MF_CAMERA_CONTROL_RANGE_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_CAMERA_CONTROL_RANGE_INFO*, int> GetRangeInfo;

        [NativeTypeName("HRESULT (void **, ULONG *, void **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, uint*, void**, uint*, int> LockControlData;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockControlData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCameraControlDefaults"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCameraControlDefaults(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCameraControlDefaults"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCameraControlDefaults(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCameraControlDefaults(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCameraControlDefaults"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCameraControlDefaults"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCameraControlDefaults value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
