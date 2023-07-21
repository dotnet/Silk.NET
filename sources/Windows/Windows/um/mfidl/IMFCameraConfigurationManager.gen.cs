// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFCameraConfigurationManager.xml' path='doc/member[@name="IMFCameraConfigurationManager"]/*' />
[Guid("A624F617-4704-4206-8A6D-EBDA4A093985")]
[NativeTypeName("struct IMFCameraConfigurationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraConfigurationManager : IMFCameraConfigurationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraConfigurationManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager*, uint>)(lpVtbl[1]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager*, uint>)(lpVtbl[2]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraConfigurationManager.xml' path='doc/member[@name="IMFCameraConfigurationManager.LoadDefaults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadDefaults(IMFAttributes* cameraAttributes, IMFCameraControlDefaultsCollection** configurations)
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager*, IMFAttributes*, IMFCameraControlDefaultsCollection**, int>)(lpVtbl[3]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this), cameraAttributes, configurations);
    }

    /// <include file='IMFCameraConfigurationManager.xml' path='doc/member[@name="IMFCameraConfigurationManager.SaveDefaults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SaveDefaults(IMFCameraControlDefaultsCollection* configurations)
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager*, IMFCameraControlDefaultsCollection*, int>)(lpVtbl[4]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this), configurations);
    }

    /// <include file='IMFCameraConfigurationManager.xml' path='doc/member[@name="IMFCameraConfigurationManager.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Shutdown()
    {
        ((delegate* unmanaged<IMFCameraConfigurationManager*, void>)(lpVtbl[5]))((IMFCameraConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadDefaults(IMFAttributes* cameraAttributes, IMFCameraControlDefaultsCollection** configurations);

        [VtblIndex(4)]
        HRESULT SaveDefaults(IMFCameraControlDefaultsCollection* configurations);

        [VtblIndex(5)]
        void Shutdown();
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

        [NativeTypeName("HRESULT (IMFAttributes *, IMFCameraControlDefaultsCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, IMFCameraControlDefaultsCollection**, int> LoadDefaults;

        [NativeTypeName("HRESULT (IMFCameraControlDefaultsCollection *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCameraControlDefaultsCollection*, int> SaveDefaults;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Shutdown;
    }
}
