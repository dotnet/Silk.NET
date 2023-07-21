// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFExtendedCameraController.xml' path='doc/member[@name="IMFExtendedCameraController"]/*' />
[Guid("B91EBFEE-CA03-4AF4-8A82-A31752F4A0FC")]
[NativeTypeName("struct IMFExtendedCameraController : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraController : IMFExtendedCameraController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedCameraController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFExtendedCameraController*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedCameraController*, uint>)(lpVtbl[1]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedCameraController*, uint>)(lpVtbl[2]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraController.xml' path='doc/member[@name="IMFExtendedCameraController.GetExtendedCameraControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetExtendedCameraControl([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("ULONG")] uint ulPropertyId, IMFExtendedCameraControl** ppControl)
    {
        return ((delegate* unmanaged<IMFExtendedCameraController*, uint, uint, IMFExtendedCameraControl**, int>)(lpVtbl[3]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this), dwStreamIndex, ulPropertyId, ppControl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetExtendedCameraControl([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("ULONG")] uint ulPropertyId, IMFExtendedCameraControl** ppControl);
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

        [NativeTypeName("HRESULT (DWORD, ULONG, IMFExtendedCameraControl **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFExtendedCameraControl**, int> GetExtendedCameraControl;
    }
}
