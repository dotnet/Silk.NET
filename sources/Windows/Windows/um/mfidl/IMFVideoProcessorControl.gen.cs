// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl"]/*' />
[Guid("A3F675D5-6119-4F7F-A100-1D8B280F0EFB")]
[NativeTypeName("struct IMFVideoProcessorControl : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFVideoProcessorControl : IMFVideoProcessorControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoProcessorControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetBorderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBorderColor(MFARGB* pBorderColor)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pBorderColor);
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetSourceRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRectangle(RECT* pSrcRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pSrcRect);
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetDestinationRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDestinationRectangle(RECT* pDstRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pDstRect);
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetMirror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eMirror);
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetRotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eRotation);
    }

    /// <include file='IMFVideoProcessorControl.xml' path='doc/member[@name="IMFVideoProcessorControl.SetConstrictionSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pConstrictionSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBorderColor(MFARGB* pBorderColor);

        [VtblIndex(4)]
        HRESULT SetSourceRectangle(RECT* pSrcRect);

        [VtblIndex(5)]
        HRESULT SetDestinationRectangle(RECT* pDstRect);

        [VtblIndex(6)]
        HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror);

        [VtblIndex(7)]
        HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation);

        [VtblIndex(8)]
        HRESULT SetConstrictionSize(SIZE* pConstrictionSize);
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

        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> SetBorderColor;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetSourceRectangle;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetDestinationRectangle;

        [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_MIRROR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_VIDEO_PROCESSOR_MIRROR, int> SetMirror;

        [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_VIDEO_PROCESSOR_ROTATION, int> SetRotation;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> SetConstrictionSize;
    }
}
