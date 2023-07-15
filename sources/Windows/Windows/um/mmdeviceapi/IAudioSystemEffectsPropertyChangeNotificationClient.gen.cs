// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioSystemEffectsPropertyChangeNotificationClient.xml' path='doc/member[@name="IAudioSystemEffectsPropertyChangeNotificationClient"]/*'/>
[Guid("20049D40-56D5-400E-A2EF-385599FEED49")]
[NativeTypeName("struct IAudioSystemEffectsPropertyChangeNotificationClient : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct IAudioSystemEffectsPropertyChangeNotificationClient : IAudioSystemEffectsPropertyChangeNotificationClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSystemEffectsPropertyChangeNotificationClient));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSystemEffectsPropertyChangeNotificationClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient*, uint> )(lpVtbl[1]))((IAudioSystemEffectsPropertyChangeNotificationClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient*, uint> )(lpVtbl[2]))((IAudioSystemEffectsPropertyChangeNotificationClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSystemEffectsPropertyChangeNotificationClient.xml' path='doc/member[@name="IAudioSystemEffectsPropertyChangeNotificationClient.OnPropertyChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPropertyChanged(AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE type, [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient*, AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE, PROPERTYKEY, int> )(lpVtbl[3]))((IAudioSystemEffectsPropertyChangeNotificationClient*)Unsafe.AsPointer(ref this), type, key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnPropertyChanged(AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE type, [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key);
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
        [NativeTypeName("HRESULT (AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE, const PROPERTYKEY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE, PROPERTYKEY, int> OnPropertyChanged;
    }
}