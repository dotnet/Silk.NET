// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5CDF2C82-841E-4546-9722-0CF74078229A")]
[NativeTypeName("struct IAudioEndpointVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioEndpointVolume : IAudioEndpointVolume.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEndpointVolume));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioEndpointVolume, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify)
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolume, IAudioEndpointVolumeCallback, int>)(
                (*lpVtbl)[3]
            )
        )(this, pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify)
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolume, IAudioEndpointVolumeCallback, int>)(
                (*lpVtbl)[4]
            )
        )(this, pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelCount(uint* pnChannelCount)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint*, int>)((*lpVtbl)[5]))(
            this,
            pnChannelCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMasterVolumeLevel(
        float fLevelDB,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, float, Guid*, int>)((*lpVtbl)[6]))(
            this,
            fLevelDB,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMasterVolumeLevelScalar(
        float fLevel,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, float, Guid*, int>)((*lpVtbl)[7]))(
            this,
            fLevel,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMasterVolumeLevel(float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, float*, int>)((*lpVtbl)[8]))(
            this,
            pfLevelDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMasterVolumeLevelScalar(float* pfLevel)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, float*, int>)((*lpVtbl)[9]))(
            this,
            pfLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetChannelVolumeLevel(
        uint nChannel,
        float fLevelDB,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolume, uint, float, Guid*, int>)((*lpVtbl)[10])
        )(this, nChannel, fLevelDB, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetChannelVolumeLevelScalar(
        uint nChannel,
        float fLevel,
        [NativeTypeName("LPCGUID")] Guid* pguidEventContext
    )
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolume, uint, float, Guid*, int>)((*lpVtbl)[11])
        )(this, nChannel, fLevel, pguidEventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetChannelVolumeLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint, float*, int>)((*lpVtbl)[12]))(
            this,
            nChannel,
            pfLevelDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetChannelVolumeLevelScalar(uint nChannel, float* pfLevel)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint, float*, int>)((*lpVtbl)[13]))(
            this,
            nChannel,
            pfLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMute(BOOL bMute, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, BOOL, Guid*, int>)((*lpVtbl)[14]))(
            this,
            bMute,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetMute(BOOL* pbMute)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, BOOL*, int>)((*lpVtbl)[15]))(
            this,
            pbMute
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetVolumeStepInfo(uint* pnStep, uint* pnStepCount)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint*, uint*, int>)((*lpVtbl)[16]))(
            this,
            pnStep,
            pnStepCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT VolumeStepUp([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, Guid*, int>)((*lpVtbl)[17]))(
            this,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT VolumeStepDown([NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, Guid*, int>)((*lpVtbl)[18]))(
            this,
            pguidEventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
    {
        return ((delegate* unmanaged<IAudioEndpointVolume, uint*, int>)((*lpVtbl)[19]))(
            this,
            pdwHardwareSupportMask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetVolumeRange(
        float* pflVolumeMindB,
        float* pflVolumeMaxdB,
        float* pflVolumeIncrementdB
    )
    {
        return (
            (delegate* unmanaged<IAudioEndpointVolume, float*, float*, float*, int>)((*lpVtbl)[20])
        )(this, pflVolumeMindB, pflVolumeMaxdB, pflVolumeIncrementdB);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify);

        [VtblIndex(4)]
        HRESULT UnregisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify);

        [VtblIndex(5)]
        HRESULT GetChannelCount(uint* pnChannelCount);

        [VtblIndex(6)]
        HRESULT SetMasterVolumeLevel(
            float fLevelDB,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(7)]
        HRESULT SetMasterVolumeLevelScalar(
            float fLevel,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(8)]
        HRESULT GetMasterVolumeLevel(float* pfLevelDB);

        [VtblIndex(9)]
        HRESULT GetMasterVolumeLevelScalar(float* pfLevel);

        [VtblIndex(10)]
        HRESULT SetChannelVolumeLevel(
            uint nChannel,
            float fLevelDB,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(11)]
        HRESULT SetChannelVolumeLevelScalar(
            uint nChannel,
            float fLevel,
            [NativeTypeName("LPCGUID")] Guid* pguidEventContext
        );

        [VtblIndex(12)]
        HRESULT GetChannelVolumeLevel(uint nChannel, float* pfLevelDB);

        [VtblIndex(13)]
        HRESULT GetChannelVolumeLevelScalar(uint nChannel, float* pfLevel);

        [VtblIndex(14)]
        HRESULT SetMute(BOOL bMute, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);

        [VtblIndex(15)]
        HRESULT GetMute(BOOL* pbMute);

        [VtblIndex(16)]
        HRESULT GetVolumeStepInfo(uint* pnStep, uint* pnStepCount);

        [VtblIndex(17)]
        HRESULT VolumeStepUp([NativeTypeName("LPCGUID")] Guid* pguidEventContext);

        [VtblIndex(18)]
        HRESULT VolumeStepDown([NativeTypeName("LPCGUID")] Guid* pguidEventContext);

        [VtblIndex(19)]
        HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask);

        [VtblIndex(20)]
        HRESULT GetVolumeRange(
            float* pflVolumeMindB,
            float* pflVolumeMaxdB,
            float* pflVolumeIncrementdB
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

        [NativeTypeName("HRESULT (IAudioEndpointVolumeCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioEndpointVolumeCallback,
            int> RegisterControlChangeNotify;

        [NativeTypeName("HRESULT (IAudioEndpointVolumeCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAudioEndpointVolumeCallback,
            int> UnregisterControlChangeNotify;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Guid*, int> SetMasterVolumeLevel;

        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Guid*, int> SetMasterVolumeLevelScalar;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMasterVolumeLevel;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMasterVolumeLevelScalar;

        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, Guid*, int> SetChannelVolumeLevel;

        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, Guid*, int> SetChannelVolumeLevelScalar;

        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetChannelVolumeLevel;

        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetChannelVolumeLevelScalar;

        [NativeTypeName("HRESULT (BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, Guid*, int> SetMute;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMute;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetVolumeStepInfo;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> VolumeStepUp;

        [NativeTypeName("HRESULT (LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> VolumeStepDown;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> QueryHardwareSupport;

        [NativeTypeName("HRESULT (float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, float*, float*, int> GetVolumeRange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEndpointVolume"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEndpointVolume(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEndpointVolume"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEndpointVolume(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEndpointVolume(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEndpointVolume"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEndpointVolume"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEndpointVolume value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
