// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("83EC1C30-23D1-11D1-99E6-00A0C9560266")]
[NativeTypeName("struct IAMTVAudio : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTVAudio : IAMTVAudio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTVAudio));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTVAudio, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMTVAudio, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTVAudio, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHardwareSupportedTVAudioModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IAMTVAudio, int*, int>)((*lpVtbl)[3]))(this, plModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAvailableTVAudioModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IAMTVAudio, int*, int>)((*lpVtbl)[4]))(this, plModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_TVAudioMode([NativeTypeName("long *")] int* plMode)
    {
        return ((delegate* unmanaged<IAMTVAudio, int*, int>)((*lpVtbl)[5]))(this, plMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TVAudioMode([NativeTypeName("long")] int lMode)
    {
        return ((delegate* unmanaged<IAMTVAudio, int, int>)((*lpVtbl)[6]))(this, lMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterNotificationCallBack(
        IAMTunerNotification pNotify,
        [NativeTypeName("long")] int lEvents
    )
    {
        return ((delegate* unmanaged<IAMTVAudio, IAMTunerNotification, int, int>)((*lpVtbl)[7]))(
            this,
            pNotify,
            lEvents
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify)
    {
        return ((delegate* unmanaged<IAMTVAudio, IAMTunerNotification, int>)((*lpVtbl)[8]))(
            this,
            pNotify
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetHardwareSupportedTVAudioModes([NativeTypeName("long *")] int* plModes);

        [VtblIndex(4)]
        HRESULT GetAvailableTVAudioModes([NativeTypeName("long *")] int* plModes);

        [VtblIndex(5)]
        HRESULT get_TVAudioMode([NativeTypeName("long *")] int* plMode);

        [VtblIndex(6)]
        HRESULT put_TVAudioMode([NativeTypeName("long")] int lMode);

        [VtblIndex(7)]
        HRESULT RegisterNotificationCallBack(
            IAMTunerNotification pNotify,
            [NativeTypeName("long")] int lEvents
        );

        [VtblIndex(8)]
        HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetHardwareSupportedTVAudioModes;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetAvailableTVAudioModes;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TVAudioMode;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_TVAudioMode;

        [NativeTypeName("HRESULT (IAMTunerNotification *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAMTunerNotification,
            int,
            int> RegisterNotificationCallBack;

        [NativeTypeName("HRESULT (IAMTunerNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAMTunerNotification,
            int> UnRegisterNotificationCallBack;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMTVAudio"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMTVAudio(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMTVAudio"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMTVAudio(Silk.NET.Windows.IUnknown value)
    {
        return new IAMTVAudio(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMTVAudio"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMTVAudio"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMTVAudio value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
