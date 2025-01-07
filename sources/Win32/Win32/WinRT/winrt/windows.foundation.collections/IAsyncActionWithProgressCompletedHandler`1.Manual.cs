// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("9C029F91-CC84-44FD-AC26-0A6C4E555281")]
public unsafe partial struct IAsyncActionWithProgressCompletedHandler<TProgress>
    where TProgress : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncActionWithProgressCompletedHandler<TProgress>*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncActionWithProgressCompletedHandler<TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncActionWithProgressCompletedHandler<TProgress>*, uint>)(lpVtbl[1]))((IAsyncActionWithProgressCompletedHandler<TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncActionWithProgressCompletedHandler<TProgress>*, uint>)(lpVtbl[2]))((IAsyncActionWithProgressCompletedHandler<TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IAsyncActionWithProgress<TProgress_logical> *")] IAsyncActionWithProgress<TProgress>* asyncInfo, [NativeTypeName("Windows::Foundation::AsyncStatus")] AsyncStatus status)
    {
        return ((delegate* unmanaged<IAsyncActionWithProgressCompletedHandler<TProgress>*, IAsyncActionWithProgress<TProgress>*, AsyncStatus, int>)(lpVtbl[3]))((IAsyncActionWithProgressCompletedHandler<TProgress>*)Unsafe.AsPointer(ref this), asyncInfo, status);
    }
}
