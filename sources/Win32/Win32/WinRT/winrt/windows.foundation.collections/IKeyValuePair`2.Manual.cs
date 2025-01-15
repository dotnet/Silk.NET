// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("02B51929-C1C4-4A7E-8940-0312B5C18500")]
public unsafe partial struct IKeyValuePair<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, uint>)(lpVtbl[1]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, uint>)(lpVtbl[2]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, HSTRING*, int>)(lpVtbl[4]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, TrustLevel*, int>)(lpVtbl[5]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Key([NativeTypeName("K_abi *")] K* key)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, K*, int>)(lpVtbl[6]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Value([NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IKeyValuePair<K, V>*, V*, int>)(lpVtbl[7]))((IKeyValuePair<K, V>*)Unsafe.AsPointer(ref this), value);
    }
}
