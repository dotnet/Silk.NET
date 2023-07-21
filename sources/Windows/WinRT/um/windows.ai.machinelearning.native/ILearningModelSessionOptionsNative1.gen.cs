// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ILearningModelSessionOptionsNative1.xml' path='doc/member[@name="ILearningModelSessionOptionsNative1"]/*' />
[Guid("5DA37A26-0526-414B-91E4-2A0FA3DDBA40")]
[NativeTypeName("struct ILearningModelSessionOptionsNative1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILearningModelSessionOptionsNative1 : ILearningModelSessionOptionsNative1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILearningModelSessionOptionsNative1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative1*, Guid*, void**, int>)(lpVtbl[0]))((ILearningModelSessionOptionsNative1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative1*, uint>)(lpVtbl[1]))((ILearningModelSessionOptionsNative1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative1*, uint>)(lpVtbl[2]))((ILearningModelSessionOptionsNative1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILearningModelSessionOptionsNative1.xml' path='doc/member[@name="ILearningModelSessionOptionsNative1.SetIntraOpThreadSpinning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIntraOpThreadSpinning([NativeTypeName("boolean")] byte allowSpinning)
    {
        return ((delegate* unmanaged<ILearningModelSessionOptionsNative1*, byte, int>)(lpVtbl[3]))((ILearningModelSessionOptionsNative1*)Unsafe.AsPointer(ref this), allowSpinning);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIntraOpThreadSpinning([NativeTypeName("boolean")] byte allowSpinning);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> SetIntraOpThreadSpinning;
    }
}
