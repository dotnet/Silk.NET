// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("24918ACC-64B3-37C1-8CA9-74A66E9957A8")]
[NativeTypeName("struct IAudioSessionEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionEvents : IAudioSessionEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioSessionEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDisplayNameChanged(
        [NativeTypeName("LPCWSTR")] ushort* NewDisplayName,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionEvents, ushort*, Guid*, int>)((*lpVtbl)[3]))(
            this,
            NewDisplayName,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnIconPathChanged(
        [NativeTypeName("LPCWSTR")] ushort* NewIconPath,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionEvents, ushort*, Guid*, int>)((*lpVtbl)[4]))(
            this,
            NewIconPath,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnSimpleVolumeChanged(
        float NewVolume,
        BOOL NewMute,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionEvents, float, BOOL, Guid*, int>)((*lpVtbl)[5]))(
            this,
            NewVolume,
            NewMute,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnChannelVolumeChanged(
        [NativeTypeName("DWORD")] uint ChannelCount,
        [NativeTypeName("float[]")] float* NewChannelVolumeArray,
        [NativeTypeName("DWORD")] uint ChangedChannel,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return (
            (delegate* unmanaged<IAudioSessionEvents, uint, float*, uint, Guid*, int>)((*lpVtbl)[6])
        )(this, ChannelCount, NewChannelVolumeArray, ChangedChannel, EventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnGroupingParamChanged(
        [NativeTypeName("LPCGUID")] Guid* NewGroupingParam,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IAudioSessionEvents, Guid*, Guid*, int>)((*lpVtbl)[7]))(
            this,
            NewGroupingParam,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnStateChanged(AudioSessionState NewState)
    {
        return ((delegate* unmanaged<IAudioSessionEvents, AudioSessionState, int>)((*lpVtbl)[8]))(
            this,
            NewState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnSessionDisconnected(AudioSessionDisconnectReason DisconnectReason)
    {
        return (
            (delegate* unmanaged<IAudioSessionEvents, AudioSessionDisconnectReason, int>)(
                (*lpVtbl)[9]
            )
        )(this, DisconnectReason);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDisplayNameChanged(
            [NativeTypeName("LPCWSTR")] ushort* NewDisplayName,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(4)]
        HRESULT OnIconPathChanged(
            [NativeTypeName("LPCWSTR")] ushort* NewIconPath,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(5)]
        HRESULT OnSimpleVolumeChanged(
            float NewVolume,
            BOOL NewMute,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(6)]
        HRESULT OnChannelVolumeChanged(
            [NativeTypeName("DWORD")] uint ChannelCount,
            [NativeTypeName("float[]")] float* NewChannelVolumeArray,
            [NativeTypeName("DWORD")] uint ChangedChannel,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(7)]
        HRESULT OnGroupingParamChanged(
            [NativeTypeName("LPCGUID")] Guid* NewGroupingParam,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(8)]
        HRESULT OnStateChanged(AudioSessionState NewState);

        [VtblIndex(9)]
        HRESULT OnSessionDisconnected(AudioSessionDisconnectReason DisconnectReason);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> OnDisplayNameChanged;

        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> OnIconPathChanged;

        [NativeTypeName("HRESULT (float, BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, BOOL, Guid*, int> OnSimpleVolumeChanged;

        [NativeTypeName("HRESULT (DWORD, float *, DWORD, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, uint, Guid*, int> OnChannelVolumeChanged;

        [NativeTypeName("HRESULT (LPCGUID, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> OnGroupingParamChanged;

        [NativeTypeName("HRESULT (AudioSessionState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioSessionState, int> OnStateChanged;

        [NativeTypeName("HRESULT (AudioSessionDisconnectReason) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioSessionDisconnectReason, int> OnSessionDisconnected;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionEvents(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
