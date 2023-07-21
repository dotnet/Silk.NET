// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVideoFrameStep.xml' path='doc/member[@name="IVideoFrameStep"]/*' />
[Guid("E46A9787-2B71-444D-A4B5-1FAB7B708D6A")]
[NativeTypeName("struct IVideoFrameStep : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVideoFrameStep : IVideoFrameStep.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrameStep));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep*, Guid*, void**, int>)(lpVtbl[0]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoFrameStep*, uint>)(lpVtbl[1]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoFrameStep*, uint>)(lpVtbl[2]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVideoFrameStep.xml' path='doc/member[@name="IVideoFrameStep.Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Step([NativeTypeName("DWORD")] uint dwFrames, IUnknown* pStepObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep*, uint, IUnknown*, int>)(lpVtbl[3]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), dwFrames, pStepObject);
    }

    /// <include file='IVideoFrameStep.xml' path='doc/member[@name="IVideoFrameStep.CanStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CanStep([NativeTypeName("long")] int bMultiple, IUnknown* pStepObject)
    {
        return ((delegate* unmanaged<IVideoFrameStep*, int, IUnknown*, int>)(lpVtbl[4]))((IVideoFrameStep*)Unsafe.AsPointer(ref this), bMultiple, pStepObject);
    }

    /// <include file='IVideoFrameStep.xml' path='doc/member[@name="IVideoFrameStep.CancelStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelStep()
    {
        return ((delegate* unmanaged<IVideoFrameStep*, int>)(lpVtbl[5]))((IVideoFrameStep*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Step([NativeTypeName("DWORD")] uint dwFrames, IUnknown* pStepObject);

        [VtblIndex(4)]
        HRESULT CanStep([NativeTypeName("long")] int bMultiple, IUnknown* pStepObject);

        [VtblIndex(5)]
        HRESULT CancelStep();
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

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> Step;

        [NativeTypeName("HRESULT (long, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IUnknown*, int> CanStep;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelStep;
    }
}
