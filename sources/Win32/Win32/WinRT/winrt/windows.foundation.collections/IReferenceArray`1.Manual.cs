// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;

namespace Silk.NET.WinRT;

[Guid("61C17706-2D65-11E0-9AE8-D48564015472")]
public unsafe partial struct IReferenceArray<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, Guid*, void**, int>)(lpVtbl[0]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, uint>)(lpVtbl[1]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, uint>)(lpVtbl[2]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, uint*, Guid**, int>)(lpVtbl[3]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, HSTRING*, int>)(lpVtbl[4]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, TrustLevel*, int>)(lpVtbl[5]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Value([NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("T_abi **")] T** value)
    {
        return ((delegate* unmanaged<IReferenceArray<T>*, uint*, T**, int>)(lpVtbl[6]))((IReferenceArray<T>*)Unsafe.AsPointer(ref this), length, value);
    }
}
