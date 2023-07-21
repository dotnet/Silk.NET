// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFCameraControlNotify.xml' path='doc/member[@name="IMFCameraControlNotify"]/*' />
[Guid("E8F2540D-558A-4449-8B64-4863467A9FE8")]
[NativeTypeName("struct IMFCameraControlNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraControlNotify : IMFCameraControlNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraControlNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraControlNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFCameraControlNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraControlNotify*, uint>)(lpVtbl[1]))((IMFCameraControlNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraControlNotify*, uint>)(lpVtbl[2]))((IMFCameraControlNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraControlNotify.xml' path='doc/member[@name="IMFCameraControlNotify.OnChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnChange([NativeTypeName("const GUID &")] Guid* controlSet, [NativeTypeName("UINT32")] uint id)
    {
        ((delegate* unmanaged<IMFCameraControlNotify*, Guid*, uint, void>)(lpVtbl[3]))((IMFCameraControlNotify*)Unsafe.AsPointer(ref this), controlSet, id);
    }

    /// <include file='IMFCameraControlNotify.xml' path='doc/member[@name="IMFCameraControlNotify.OnError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnError(HRESULT hrStatus)
    {
        ((delegate* unmanaged<IMFCameraControlNotify*, HRESULT, void>)(lpVtbl[4]))((IMFCameraControlNotify*)Unsafe.AsPointer(ref this), hrStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnChange([NativeTypeName("const GUID &")] Guid* controlSet, [NativeTypeName("UINT32")] uint id);

        [VtblIndex(4)]
        void OnError(HRESULT hrStatus);
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

        [NativeTypeName("void (const GUID &, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void> OnChange;

        [NativeTypeName("void (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, void> OnError;
    }
}
