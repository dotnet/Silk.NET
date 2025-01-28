// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;

namespace Silk.NET.WinRT;

[Guid("9939F4DF-050A-4C0F-AA60-77075F9C4777")]
public unsafe partial struct IMapChangedEventArgs<K>
    where K : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, Guid*, void**, int>)(lpVtbl[0]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint>)(lpVtbl[1]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint>)(lpVtbl[2]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, uint*, Guid**, int>)(lpVtbl[3]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, HSTRING*, int>)(lpVtbl[4]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, TrustLevel*, int>)(lpVtbl[5]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_CollectionChange([NativeTypeName("CollectionChange *")] CollectionChange* value)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, CollectionChange*, int>)(lpVtbl[6]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Key([NativeTypeName("K_abi *")] K* value)
    {
        return ((delegate* unmanaged<IMapChangedEventArgs<K>*, K*, int>)(lpVtbl[7]))((IMapChangedEventArgs<K>*)Unsafe.AsPointer(ref this), value);
    }
}
