// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("3C2925FE-8519-45C1-AA79-197B6718C1C1")]
public unsafe partial struct IMap<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMap<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((IMap<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint>)(lpVtbl[1]))((IMap<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint>)(lpVtbl[2]))((IMap<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))((IMap<K, V>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMap<K, V>*, HSTRING*, int>)(lpVtbl[4]))((IMap<K, V>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMap<K, V>*, TrustLevel*, int>)(lpVtbl[5]))((IMap<K, V>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, V*, int>)(lpVtbl[6]))((IMap<K, V>*)Unsafe.AsPointer(ref this), key, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, int>)(lpVtbl[7]))((IMap<K, V>*)Unsafe.AsPointer(ref this), size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT HasKey([NativeTypeName("T_abi")] K key, [NativeTypeName("boolean *")] byte* found)
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, byte*, int>)(lpVtbl[8]))((IMap<K, V>*)Unsafe.AsPointer(ref this), key, found);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetView([NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** view)
    {
        return ((delegate* unmanaged<IMap<K, V>*, IMapView<K, V>**, int>)(lpVtbl[9]))((IMap<K, V>*)Unsafe.AsPointer(ref this), view);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Insert([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMap<K, V>*, uint*, int>)(lpVtbl[10]))((IMap<K, V>*)Unsafe.AsPointer(ref this), size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Remove([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi")] V value, [NativeTypeName("boolean *")] byte* replaced)
    {
        return ((delegate* unmanaged<IMap<K, V>*, K, V, byte*, int>)(lpVtbl[11]))((IMap<K, V>*)Unsafe.AsPointer(ref this), key, value, replaced);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IMap<K, V>*, int>)(lpVtbl[12]))((IMap<K, V>*)Unsafe.AsPointer(ref this));
    }

}
