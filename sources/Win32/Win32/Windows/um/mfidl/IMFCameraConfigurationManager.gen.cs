// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A624F617-4704-4206-8A6D-EBDA4A093985")]
[NativeTypeName("struct IMFCameraConfigurationManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22621.0")]
public unsafe partial struct IMFCameraConfigurationManager
    : IMFCameraConfigurationManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraConfigurationManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFCameraConfigurationManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraConfigurationManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadDefaults(
        IMFAttributes cameraAttributes,
        IMFCameraControlDefaultsCollection* configurations
    )
    {
        return (
            (delegate* unmanaged<
                IMFCameraConfigurationManager,
                IMFAttributes,
                IMFCameraControlDefaultsCollection*,
                int>)((*lpVtbl)[3])
        )(this, cameraAttributes, configurations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SaveDefaults(IMFCameraControlDefaultsCollection configurations)
    {
        return (
            (delegate* unmanaged<
                IMFCameraConfigurationManager,
                IMFCameraControlDefaultsCollection,
                int>)((*lpVtbl)[4])
        )(this, configurations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Shutdown()
    {
        ((delegate* unmanaged<IMFCameraConfigurationManager, void>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadDefaults(
            IMFAttributes cameraAttributes,
            IMFCameraControlDefaultsCollection* configurations
        );

        [VtblIndex(4)]
        HRESULT SaveDefaults(IMFCameraControlDefaultsCollection configurations);

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

        [NativeTypeName(
            "HRESULT (IMFAttributes *, IMFCameraControlDefaultsCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAttributes,
            IMFCameraControlDefaultsCollection*,
            int> LoadDefaults;

        [NativeTypeName("HRESULT (IMFCameraControlDefaultsCollection *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCameraControlDefaultsCollection, int> SaveDefaults;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCameraConfigurationManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCameraConfigurationManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCameraConfigurationManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCameraConfigurationManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCameraConfigurationManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCameraConfigurationManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCameraConfigurationManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCameraConfigurationManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
