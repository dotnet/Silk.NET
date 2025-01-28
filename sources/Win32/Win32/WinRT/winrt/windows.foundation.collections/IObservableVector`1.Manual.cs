// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;

namespace Silk.NET.WinRT;

[Guid("5917EB53-50B4-4A0D-B309-65862B3F1DBC")]
public unsafe partial struct IObservableVector<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, Guid*, void**, int>)(lpVtbl[0]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObservableVector<T>*, uint>)(lpVtbl[1]))((IObservableVector<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObservableVector<T>*, uint>)(lpVtbl[2]))((IObservableVector<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, uint*, Guid**, int>)(lpVtbl[3]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, HSTRING*, int>)(lpVtbl[4]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, TrustLevel*, int>)(lpVtbl[5]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT add_VectorChanged([NativeTypeName("VectorChangedEventHandler<T_logical> *")] VectorChangedEventHandler<T>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, VectorChangedEventHandler<T>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT remove_VectorChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IObservableVector<T>*, EventRegistrationToken, int>)(lpVtbl[7]))((IObservableVector<T>*)Unsafe.AsPointer(ref this), token);
    }
}
