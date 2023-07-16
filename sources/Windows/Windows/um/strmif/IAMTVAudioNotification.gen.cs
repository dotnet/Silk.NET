// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMTVAudioNotification.xml' path='doc/member[@name="IAMTVAudioNotification"]/*'/>
[Guid("83EC1C33-23D1-11D1-99E6-00A0C9560266")]
[NativeTypeName("struct IAMTVAudioNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTVAudioNotification : IAMTVAudioNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTVAudioNotification));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTVAudioNotification*, Guid*, void**, int> )(lpVtbl[0]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTVAudioNotification*, uint> )(lpVtbl[1]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTVAudioNotification*, uint> )(lpVtbl[2]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMTVAudioNotification.xml' path='doc/member[@name="IAMTVAudioNotification.OnEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnEvent(AMTVAudioEventType Event)
    {
        return ((delegate* unmanaged<IAMTVAudioNotification*, AMTVAudioEventType, int> )(lpVtbl[3]))((IAMTVAudioNotification*)Unsafe.AsPointer(ref this), Event);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnEvent(AMTVAudioEventType Event);
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
        [NativeTypeName("HRESULT (AMTVAudioEventType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMTVAudioEventType, int> OnEvent;
    }
}