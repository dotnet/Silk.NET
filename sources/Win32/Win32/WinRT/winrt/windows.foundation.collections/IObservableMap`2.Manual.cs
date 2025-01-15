// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("65DF2BF5-BF39-41B5-AEBC-5A9D865E472B")]
public unsafe partial struct IObservableMap<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(lpVtbl[1]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(lpVtbl[2]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, HSTRING*, int>)(lpVtbl[4]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, TrustLevel*, int>)(lpVtbl[5]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT add_MapChanged([NativeTypeName("MapChangedEventHandler<K_logical, V_logical> *")] MapChangedEventHandler<K, V>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, MapChangedEventHandler<K, V>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT remove_MapChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IObservableMap<K, V>*, EventRegistrationToken, int>)(lpVtbl[7]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), token);
    }
}
