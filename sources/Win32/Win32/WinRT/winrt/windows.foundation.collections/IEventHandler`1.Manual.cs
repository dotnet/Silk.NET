// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;

namespace Silk.NET.WinRT;

[Guid("9DE1C535-6AE1-11E0-84E1-18A905BCC53F")]
public unsafe partial struct IEventHandler<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<IEventHandler<T>*, Guid*, void**, int>)(lpVtbl[0]))((IEventHandler<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEventHandler<T>*, uint>)(lpVtbl[1]))((IEventHandler<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEventHandler<T>*, uint>)(lpVtbl[2]))((IEventHandler<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IInspectable *")] IInspectable* sender, [NativeTypeName("T_abi")] T args)
    {
        return ((delegate* unmanaged<IEventHandler<T>*, IInspectable*, T, int>)(lpVtbl[3]))((IEventHandler<T>*)Unsafe.AsPointer(ref this), sender, args);
    }
}
