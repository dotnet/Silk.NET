// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFVideoProcessorControl2.xml' path='doc/member[@name="IMFVideoProcessorControl2"]/*'/>
[Guid("BDE633D3-E1DC-4A7F-A693-BBAE399C4A20")]
[NativeTypeName("struct IMFVideoProcessorControl2 : IMFVideoProcessorControl")]
[NativeInheritance("IMFVideoProcessorControl")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFVideoProcessorControl2 : IMFVideoProcessorControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoProcessorControl2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, Guid*, void**, int> )(lpVtbl[0]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint> )(lpVtbl[1]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint> )(lpVtbl[2]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetBorderColor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBorderColor(MFARGB* pBorderColor)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, MFARGB*, int> )(lpVtbl[3]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pBorderColor);
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetSourceRectangle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRectangle(RECT* pSrcRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int> )(lpVtbl[4]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pSrcRect);
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetDestinationRectangle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDestinationRectangle(RECT* pDstRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, RECT*, int> )(lpVtbl[5]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pDstRect);
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetMirror"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_MIRROR, int> )(lpVtbl[6]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eMirror);
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetRotation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_ROTATION, int> )(lpVtbl[7]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eRotation);
    }

    /// <inheritdoc cref = "IMFVideoProcessorControl.SetConstrictionSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, SIZE*, int> )(lpVtbl[8]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pConstrictionSize);
    }

    /// <include file='IMFVideoProcessorControl2.xml' path='doc/member[@name="IMFVideoProcessorControl2.SetRotationOverride"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetRotationOverride(uint uiRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint, int> )(lpVtbl[9]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), uiRotation);
    }

    /// <include file='IMFVideoProcessorControl2.xml' path='doc/member[@name="IMFVideoProcessorControl2.EnableHardwareEffects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnableHardwareEffects(BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, BOOL, int> )(lpVtbl[10]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), fEnabled);
    }

    /// <include file='IMFVideoProcessorControl2.xml' path='doc/member[@name="IMFVideoProcessorControl2.GetSupportedHardwareEffects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedHardwareEffects(uint* puiSupport)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2*, uint*, int> )(lpVtbl[11]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), puiSupport);
    }

    public interface Interface : IMFVideoProcessorControl.Interface
    {
        [VtblIndex(9)]
        HRESULT SetRotationOverride(uint uiRotation);
        [VtblIndex(10)]
        HRESULT EnableHardwareEffects(BOOL fEnabled);
        [VtblIndex(11)]
        HRESULT GetSupportedHardwareEffects(uint* puiSupport);
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
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRotationOverride;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableHardwareEffects;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSupportedHardwareEffects;
    }
}