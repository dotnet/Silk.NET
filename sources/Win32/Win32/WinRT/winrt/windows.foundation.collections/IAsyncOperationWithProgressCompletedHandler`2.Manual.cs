// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;

namespace Silk.NET.WinRT;

[Guid("E85DF41D-6AA7-46E3-A8E2-F009D840C627")]
public unsafe partial struct IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>
    where TResult : unmanaged
    where TProgress : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*, uint>)(lpVtbl[1]))((IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*, uint>)(lpVtbl[2]))((IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IAsyncOperationWithProgress<TResult_logical, TProgress_logical> *")] IAsyncOperationWithProgress<TResult, TProgress>* asyncInfo, [NativeTypeName("Windows::Foundation::AsyncStatus")] AsyncStatus status)
    {
        return ((delegate* unmanaged<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*, IAsyncOperationWithProgress<TResult, TProgress>*, AsyncStatus, int>)(lpVtbl[3]))((IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*)Unsafe.AsPointer(ref this), asyncInfo, status);
    }
}
