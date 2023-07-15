// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl"]/*'/>
[Guid("38E33520-FCA1-4845-A27A-68B7C6AB3789")]
[NativeTypeName("struct IMFExtendedCameraControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraControl : IMFExtendedCameraControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedCameraControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, Guid*, void**, int> )(lpVtbl[0]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, uint> )(lpVtbl[1]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, uint> )(lpVtbl[2]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.GetCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetCapabilities()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, ulong> )(lpVtbl[3]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.SetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFlags([NativeTypeName("ULONGLONG")] ulong ulFlags)
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, ulong, int> )(lpVtbl[4]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), ulFlags);
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.GetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetFlags()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, ulong> )(lpVtbl[5]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.LockPayload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LockPayload(byte** ppPayload, [NativeTypeName("ULONG *")] uint* pulPayload)
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, byte**, uint*, int> )(lpVtbl[6]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this), ppPayload, pulPayload);
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.UnlockPayload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnlockPayload()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, int> )(lpVtbl[7]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraControl.xml' path='doc/member[@name="IMFExtendedCameraControl.CommitSettings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CommitSettings()
    {
        return ((delegate* unmanaged<IMFExtendedCameraControl*, int> )(lpVtbl[8]))((IMFExtendedCameraControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetCapabilities();
        [VtblIndex(4)]
        HRESULT SetFlags([NativeTypeName("ULONGLONG")] ulong ulFlags);
        [VtblIndex(5)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetFlags();
        [VtblIndex(6)]
        HRESULT LockPayload(byte** ppPayload, [NativeTypeName("ULONG *")] uint* pulPayload);
        [VtblIndex(7)]
        HRESULT UnlockPayload();
        [VtblIndex(8)]
        HRESULT CommitSettings();
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
        [NativeTypeName("ULONGLONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetCapabilities;
        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetFlags;
        [NativeTypeName("ULONGLONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetFlags;
        [NativeTypeName("HRESULT (BYTE **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> LockPayload;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockPayload;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CommitSettings;
    }
}