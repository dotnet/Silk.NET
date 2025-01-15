// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("179517F3-94EE-41F8-BDDC-768A895544F3")]
public unsafe partial struct MapChangedEventHandler<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<MapChangedEventHandler<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((MapChangedEventHandler<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<MapChangedEventHandler<K, V>*, uint>)(lpVtbl[1]))((MapChangedEventHandler<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<MapChangedEventHandler<K, V>*, uint>)(lpVtbl[2]))((MapChangedEventHandler<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IObservableMap<K_logical, V_logical> *")] IObservableMap<K, V>* sender, [NativeTypeName("IMapChangedEventArgs<K_logical> *")] IMapChangedEventArgs<K>* e)
    {
        return ((delegate* unmanaged<MapChangedEventHandler<K, V>*, IObservableMap<K, V>*, IMapChangedEventArgs<K>*, int>)(lpVtbl[3]))((MapChangedEventHandler<K, V>*)Unsafe.AsPointer(ref this), sender, e);
    }
}
