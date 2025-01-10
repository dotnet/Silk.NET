// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("24E0485F-A33E-4AA1-B564-6019B1D14F65")]
[NativeTypeName("struct IAdvancedMediaCaptureSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAdvancedMediaCaptureSettings
    : IAdvancedMediaCaptureSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedMediaCaptureSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdvancedMediaCaptureSettings, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedMediaCaptureSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDirectxDeviceManager(IMFDXGIDeviceManager* value)
    {
        return (
            (delegate* unmanaged<IAdvancedMediaCaptureSettings, IMFDXGIDeviceManager*, int>)(
                (*lpVtbl)[3]
            )
        )(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDirectxDeviceManager(IMFDXGIDeviceManager* value);
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

        [NativeTypeName("HRESULT (IMFDXGIDeviceManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFDXGIDeviceManager*, int> GetDirectxDeviceManager;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedMediaCaptureSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedMediaCaptureSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedMediaCaptureSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedMediaCaptureSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IAdvancedMediaCaptureSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedMediaCaptureSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedMediaCaptureSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdvancedMediaCaptureSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
