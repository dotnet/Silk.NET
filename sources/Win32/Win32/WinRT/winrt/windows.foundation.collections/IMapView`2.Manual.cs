// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("E480CE40-A338-4ADA-ADCF-272272E48CB9")]
public unsafe partial struct IMapView<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(lpVtbl[1]))((IMapView<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(lpVtbl[2]))((IMapView<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, HSTRING*, int>)(lpVtbl[4]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, TrustLevel*, int>)(lpVtbl[5]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, V*, int>)(lpVtbl[6]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), key, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, int>)(lpVtbl[7]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT HasKey([NativeTypeName("T_abi")] K key, [NativeTypeName("boolean *")] byte* found)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, byte*, int>)(lpVtbl[8]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), key, found);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Split([NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** firstPartition, [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** secondPartition)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, IMapView<K, V>**, IMapView<K, V>**, int>)(lpVtbl[9]))((IMapView<K, V>*)Unsafe.AsPointer(ref this), firstPartition, secondPartition);
    }
}
