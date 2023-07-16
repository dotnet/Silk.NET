// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore"]/*'/>
[Guid("302AE7F9-D7E0-43E4-971B-1F8293613D2A")]
[NativeTypeName("struct IAudioSystemEffectsPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct IAudioSystemEffectsPropertyStore : IAudioSystemEffectsPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSystemEffectsPropertyStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, uint> )(lpVtbl[1]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, uint> )(lpVtbl[2]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.OpenDefaultPropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenDefaultPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, uint, IPropertyStore**, int> )(lpVtbl[3]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), stgmAccess, propStore);
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.OpenUserPropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenUserPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, uint, IPropertyStore**, int> )(lpVtbl[4]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), stgmAccess, propStore);
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.OpenVolatilePropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OpenVolatilePropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, uint, IPropertyStore**, int> )(lpVtbl[5]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), stgmAccess, propStore);
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.ResetUserPropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResetUserPropertyStore()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, int> )(lpVtbl[6]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.ResetVolatilePropertyStore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetVolatilePropertyStore()
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, int> )(lpVtbl[7]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.RegisterPropertyChangeNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterPropertyChangeNotification(IAudioSystemEffectsPropertyChangeNotificationClient* callback)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, IAudioSystemEffectsPropertyChangeNotificationClient*, int> )(lpVtbl[8]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), callback);
    }

    /// <include file='IAudioSystemEffectsPropertyStore.xml' path='doc/member[@name="IAudioSystemEffectsPropertyStore.UnregisterPropertyChangeNotification"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterPropertyChangeNotification(IAudioSystemEffectsPropertyChangeNotificationClient* callback)
    {
        return ((delegate* unmanaged<IAudioSystemEffectsPropertyStore*, IAudioSystemEffectsPropertyChangeNotificationClient*, int> )(lpVtbl[9]))((IAudioSystemEffectsPropertyStore*)Unsafe.AsPointer(ref this), callback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenDefaultPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore);
        [VtblIndex(4)]
        HRESULT OpenUserPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore);
        [VtblIndex(5)]
        HRESULT OpenVolatilePropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** propStore);
        [VtblIndex(6)]
        HRESULT ResetUserPropertyStore();
        [VtblIndex(7)]
        HRESULT ResetVolatilePropertyStore();
        [VtblIndex(8)]
        HRESULT RegisterPropertyChangeNotification(IAudioSystemEffectsPropertyChangeNotificationClient* callback);
        [VtblIndex(9)]
        HRESULT UnregisterPropertyChangeNotification(IAudioSystemEffectsPropertyChangeNotificationClient* callback);
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
        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore**, int> OpenDefaultPropertyStore;
        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore**, int> OpenUserPropertyStore;
        [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyStore**, int> OpenVolatilePropertyStore;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetUserPropertyStore;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetVolatilePropertyStore;
        [NativeTypeName("HRESULT (IAudioSystemEffectsPropertyChangeNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSystemEffectsPropertyChangeNotificationClient*, int> RegisterPropertyChangeNotification;
        [NativeTypeName("HRESULT (IAudioSystemEffectsPropertyChangeNotificationClient *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSystemEffectsPropertyChangeNotificationClient*, int> UnregisterPropertyChangeNotification;
    }
}