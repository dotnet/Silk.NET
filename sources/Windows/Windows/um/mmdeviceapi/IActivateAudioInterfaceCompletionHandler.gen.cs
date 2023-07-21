// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IActivateAudioInterfaceCompletionHandler.xml' path='doc/member[@name="IActivateAudioInterfaceCompletionHandler"]/*' />
[Guid("41D949AB-9862-444A-80F6-C261334DA5EB")]
[NativeTypeName("struct IActivateAudioInterfaceCompletionHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IActivateAudioInterfaceCompletionHandler : IActivateAudioInterfaceCompletionHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivateAudioInterfaceCompletionHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, Guid*, void**, int>)(lpVtbl[0]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, uint>)(lpVtbl[1]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, uint>)(lpVtbl[2]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActivateAudioInterfaceCompletionHandler.xml' path='doc/member[@name="IActivateAudioInterfaceCompletionHandler.ActivateCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ActivateCompleted(IActivateAudioInterfaceAsyncOperation* activateOperation)
    {
        return ((delegate* unmanaged<IActivateAudioInterfaceCompletionHandler*, IActivateAudioInterfaceAsyncOperation*, int>)(lpVtbl[3]))((IActivateAudioInterfaceCompletionHandler*)Unsafe.AsPointer(ref this), activateOperation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ActivateCompleted(IActivateAudioInterfaceAsyncOperation* activateOperation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IActivateAudioInterfaceAsyncOperation *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IActivateAudioInterfaceAsyncOperation*, int> ActivateCompleted;
    }
}
