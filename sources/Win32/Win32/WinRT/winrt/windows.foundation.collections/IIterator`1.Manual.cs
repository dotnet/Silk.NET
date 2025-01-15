// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("6A79E863-4300-459A-9966-CBB660963EE1")]
public unsafe partial struct IIterator<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IIterator<T>*, Guid*, void**, int>)(lpVtbl[0]))((IIterator<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIterator<T>*, uint>)(lpVtbl[1]))((IIterator<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIterator<T>*, uint>)(lpVtbl[2]))((IIterator<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IIterator<T>*, uint*, Guid**, int>)(lpVtbl[3]))((IIterator<T>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIterator<T>*, HSTRING*, int>)(lpVtbl[4]))((IIterator<T>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIterator<T>*, TrustLevel*, int>)(lpVtbl[5]))((IIterator<T>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Current([NativeTypeName("T_abi *")] T* current)
    {
        return ((delegate* unmanaged<IIterator<T>*, T*, int>)(lpVtbl[6]))((IIterator<T>*)Unsafe.AsPointer(ref this), current);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_HasCurrent([NativeTypeName("boolean *")] byte* hasCurrent)
    {
        return ((delegate* unmanaged<IIterator<T>*, byte*, int>)(lpVtbl[7]))((IIterator<T>*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT MoveNext([NativeTypeName("boolean *")] byte* hasCurrent)
    {
        return ((delegate* unmanaged<IIterator<T>*, byte*, int>)(lpVtbl[8]))((IIterator<T>*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetMany([NativeTypeName("unsigned")] uint capacity, [NativeTypeName("T_abi *")] T* value, [NativeTypeName("unsigned *")] uint* actual)
    {
        return ((delegate* unmanaged<IIterator<T>*, uint, T*, uint*, int>)(lpVtbl[9]))((IIterator<T>*)Unsafe.AsPointer(ref this), capacity, value, actual);
    }
}
