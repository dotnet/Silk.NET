// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio"]/*' />
[Guid("83EC1C30-23D1-11D1-99E6-00A0C9560266")]
[NativeTypeName("struct IAMTVAudio : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTVAudio : IAMTVAudio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTVAudio));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTVAudio*, Guid*, void**, int>)(lpVtbl[0]))((IAMTVAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTVAudio*, uint>)(lpVtbl[1]))((IAMTVAudio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTVAudio*, uint>)(lpVtbl[2]))((IAMTVAudio*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.GetHardwareSupportedTVAudioModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHardwareSupportedTVAudioModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[3]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plModes);
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.GetAvailableTVAudioModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAvailableTVAudioModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[4]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plModes);
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.get_TVAudioMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_TVAudioMode([NativeTypeName("long *")] int* plMode)
    {
        return ((delegate* unmanaged<IAMTVAudio*, int*, int>)(lpVtbl[5]))((IAMTVAudio*)Unsafe.AsPointer(ref this), plMode);
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.put_TVAudioMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TVAudioMode([NativeTypeName("long")] int lMode)
    {
        return ((delegate* unmanaged<IAMTVAudio*, int, int>)(lpVtbl[6]))((IAMTVAudio*)Unsafe.AsPointer(ref this), lMode);
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.RegisterNotificationCallBack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
    {
        return ((delegate* unmanaged<IAMTVAudio*, IAMTunerNotification*, int, int>)(lpVtbl[7]))((IAMTVAudio*)Unsafe.AsPointer(ref this), pNotify, lEvents);
    }

    /// <include file='IAMTVAudio.xml' path='doc/member[@name="IAMTVAudio.UnRegisterNotificationCallBack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify)
    {
        return ((delegate* unmanaged<IAMTVAudio*, IAMTunerNotification*, int>)(lpVtbl[8]))((IAMTVAudio*)Unsafe.AsPointer(ref this), pNotify);
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
        HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents);

        [VtblIndex(8)]
        HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify);
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
        public delegate* unmanaged<TSelf*, IAMTunerNotification*, int, int> RegisterNotificationCallBack;

        [NativeTypeName("HRESULT (IAMTunerNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAMTunerNotification*, int> UnRegisterNotificationCallBack;
    }
}
