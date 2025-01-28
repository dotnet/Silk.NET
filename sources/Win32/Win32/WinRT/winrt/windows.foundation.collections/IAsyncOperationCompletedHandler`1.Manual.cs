// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;

namespace Silk.NET.WinRT;

[Guid("FCDCF02C-E5D8-4478-915A-4D90B74B83A5")]
public unsafe partial struct IAsyncOperationCompletedHandler<TResult>
    where TResult : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, uint>)(lpVtbl[1]))((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, uint>)(lpVtbl[2]))((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IAsyncOperation<TResult_logical> *")] IAsyncOperation<TResult>* asyncInfo, [NativeTypeName("Windows::Foundation::AsyncStatus")] AsyncStatus status)
    {
        return ((delegate* unmanaged<IAsyncOperationCompletedHandler<TResult>*, IAsyncOperation<TResult>*, AsyncStatus, int>)(lpVtbl[3]))((IAsyncOperationCompletedHandler<TResult>*)Unsafe.AsPointer(ref this), asyncInfo, status);
    }
}
