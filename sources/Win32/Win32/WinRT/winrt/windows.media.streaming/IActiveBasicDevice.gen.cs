// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B64D6974-6E79-49AF-9933-908B6E9A160C")]
[NativeTypeName("struct IActiveBasicDevice : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IActiveBasicDevice : IActiveBasicDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveBasicDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IActiveBasicDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveBasicDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IActiveBasicDevice, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxVolume([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMuteSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsSetNextSourceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsSearchSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCachedSinkProtocolInfo(HSTRING* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCachedSinkProtocolInfo(HSTRING value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, HSTRING, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetCachedExtraSinkProtocolInfo(HSTRING* value)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, HSTRING*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetEffectiveBandwidth(
        [NativeTypeName("boolean")] byte transmitSpeed,
        [NativeTypeName("UINT64 *")] ulong* currentSpeed
    )
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte, ulong*, int>)((*lpVtbl)[16]))(
            this,
            transmitSpeed,
            currentSpeed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCachedBitrateMeasurement(
        Guid physicalNetworkInterface,
        [NativeTypeName("UINT64 *")] ulong* bitrate
    )
    {
        return ((delegate* unmanaged<IActiveBasicDevice, Guid, ulong*, int>)((*lpVtbl)[17]))(
            this,
            physicalNetworkInterface,
            bitrate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetCachedBitrateMeasurement(
        Guid physicalNetworkInterface,
        [NativeTypeName("UINT64")] ulong bitrate
    )
    {
        return ((delegate* unmanaged<IActiveBasicDevice, Guid, ulong, int>)((*lpVtbl)[18]))(
            this,
            physicalNetworkInterface,
            bitrate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_LogicalNetworkInterface(Guid* logicalNetworkInterface)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, Guid*, int>)((*lpVtbl)[19]))(
            this,
            logicalNetworkInterface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PhysicalNetworkInterface(Guid* physicalNetworkInterface)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, Guid*, int>)((*lpVtbl)[20]))(
            this,
            physicalNetworkInterface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT NotifyStreamingStatus([NativeTypeName("boolean")] byte fIsStreaming)
    {
        return ((delegate* unmanaged<IActiveBasicDevice, byte, int>)((*lpVtbl)[21]))(
            this,
            fIsStreaming
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxVolume([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_IsMuteSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsSetNextSourceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsSearchSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT GetCachedSinkProtocolInfo(HSTRING* value);

        [VtblIndex(14)]
        HRESULT SetCachedSinkProtocolInfo(HSTRING value);

        [VtblIndex(15)]
        HRESULT GetCachedExtraSinkProtocolInfo(HSTRING* value);

        [VtblIndex(16)]
        HRESULT GetEffectiveBandwidth(
            [NativeTypeName("boolean")] byte transmitSpeed,
            [NativeTypeName("UINT64 *")] ulong* currentSpeed
        );

        [VtblIndex(17)]
        HRESULT GetCachedBitrateMeasurement(
            Guid physicalNetworkInterface,
            [NativeTypeName("UINT64 *")] ulong* bitrate
        );

        [VtblIndex(18)]
        HRESULT SetCachedBitrateMeasurement(
            Guid physicalNetworkInterface,
            [NativeTypeName("UINT64")] ulong bitrate
        );

        [VtblIndex(19)]
        HRESULT get_LogicalNetworkInterface(Guid* logicalNetworkInterface);

        [VtblIndex(20)]
        HRESULT get_PhysicalNetworkInterface(Guid* physicalNetworkInterface);

        [VtblIndex(21)]
        HRESULT NotifyStreamingStatus([NativeTypeName("boolean")] byte fIsStreaming);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxVolume;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMuteSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSetNextSourceSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAudioSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVideoSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsImageSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSearchSupported;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetCachedSinkProtocolInfo;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetCachedSinkProtocolInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetCachedExtraSinkProtocolInfo;

        [NativeTypeName("HRESULT (::boolean, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, ulong*, int> GetEffectiveBandwidth;

        [NativeTypeName("HRESULT (GUID, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong*, int> GetCachedBitrateMeasurement;

        [NativeTypeName("HRESULT (GUID, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong, int> SetCachedBitrateMeasurement;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_LogicalNetworkInterface;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_PhysicalNetworkInterface;

        [NativeTypeName("HRESULT (::boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> NotifyStreamingStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActiveBasicDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActiveBasicDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IActiveBasicDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IActiveBasicDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new IActiveBasicDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveBasicDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveBasicDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IActiveBasicDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActiveBasicDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActiveBasicDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IActiveBasicDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveBasicDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveBasicDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActiveBasicDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
