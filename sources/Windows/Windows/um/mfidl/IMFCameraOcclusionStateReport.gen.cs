// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFCameraOcclusionStateReport.xml' path='doc/member[@name="IMFCameraOcclusionStateReport"]/*' />
[Guid("1640B2CF-74DA-4462-A43B-B76D3BDC1434")]
[NativeTypeName("struct IMFCameraOcclusionStateReport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraOcclusionStateReport : IMFCameraOcclusionStateReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraOcclusionStateReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReport*, Guid*, void**, int>)(lpVtbl[0]))((IMFCameraOcclusionStateReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReport*, uint>)(lpVtbl[1]))((IMFCameraOcclusionStateReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReport*, uint>)(lpVtbl[2]))((IMFCameraOcclusionStateReport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraOcclusionStateReport.xml' path='doc/member[@name="IMFCameraOcclusionStateReport.GetOcclusionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOcclusionState([NativeTypeName("DWORD *")] uint* occlusionState)
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateReport*, uint*, int>)(lpVtbl[3]))((IMFCameraOcclusionStateReport*)Unsafe.AsPointer(ref this), occlusionState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOcclusionState([NativeTypeName("DWORD *")] uint* occlusionState);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOcclusionState;
    }
}
