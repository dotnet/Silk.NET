// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0C06D5AD-1B90-4F51-9981-EF5A1C0DDF66")]
[NativeTypeName("struct IHdmiDisplayMode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHdmiDisplayMode : IHdmiDisplayMode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHdmiDisplayMode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolutionWidthInRawPixels([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResolutionHeightInRawPixels([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, uint*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RefreshRate(double* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, double*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BitsPerPixel([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, ushort*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsEqual(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
            IHdmiDisplayMode mode,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IHdmiDisplayMode, IHdmiDisplayMode, byte*, int>)((*lpVtbl)[11])
        )(this, mode, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ColorSpace(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *")]
            HdmiDisplayColorSpace* value
    )
    {
        return (
            (delegate* unmanaged<IHdmiDisplayMode, HdmiDisplayColorSpace*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PixelEncoding(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *")]
            HdmiDisplayPixelEncoding* value
    )
    {
        return (
            (delegate* unmanaged<IHdmiDisplayMode, HdmiDisplayPixelEncoding*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsSdrLuminanceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsSmpte2084Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Is2086MetadataSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHdmiDisplayMode, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolutionWidthInRawPixels([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_ResolutionHeightInRawPixels([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_RefreshRate(double* value);

        [VtblIndex(9)]
        HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_BitsPerPixel([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT IsEqual(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
                IHdmiDisplayMode mode,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(12)]
        HRESULT get_ColorSpace(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *")]
                HdmiDisplayColorSpace* value
        );

        [VtblIndex(13)]
        HRESULT get_PixelEncoding(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *")]
                HdmiDisplayPixelEncoding* value
        );

        [VtblIndex(14)]
        HRESULT get_IsSdrLuminanceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsSmpte2084Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_Is2086MetadataSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ResolutionWidthInRawPixels;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ResolutionHeightInRawPixels;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RefreshRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_StereoEnabled;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BitsPerPixel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHdmiDisplayMode, byte*, int> IsEqual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::HdmiDisplayColorSpace *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HdmiDisplayColorSpace*, int> get_ColorSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::HdmiDisplayPixelEncoding *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HdmiDisplayPixelEncoding*, int> get_PixelEncoding;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSdrLuminanceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSmpte2084Supported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Is2086MetadataSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHdmiDisplayMode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHdmiDisplayMode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHdmiDisplayMode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHdmiDisplayMode(Silk.NET.WinRT.IInspectable value)
    {
        return new IHdmiDisplayMode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHdmiDisplayMode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHdmiDisplayMode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHdmiDisplayMode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHdmiDisplayMode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHdmiDisplayMode(Silk.NET.Windows.IUnknown value)
    {
        return new IHdmiDisplayMode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHdmiDisplayMode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHdmiDisplayMode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHdmiDisplayMode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
