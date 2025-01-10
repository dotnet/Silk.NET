// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE9D91D2-70B4-4F41-836C-25FCD39626D3")]
[NativeTypeName("struct IWICDisplayAdaptationControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDisplayAdaptationControl
    : IWICDisplayAdaptationControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDisplayAdaptationControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICDisplayAdaptationControl, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDisplayAdaptationControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDisplayAdaptationControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportChangingMaxLuminance(
        [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat,
        BOOL* pfIsSupported
    )
    {
        return (
            (delegate* unmanaged<IWICDisplayAdaptationControl, Guid*, BOOL*, int>)((*lpVtbl)[3])
        )(this, pguidDstFormat, pfIsSupported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDisplayMaxLuminance(float fLuminanceInNits)
    {
        return ((delegate* unmanaged<IWICDisplayAdaptationControl, float, int>)((*lpVtbl)[4]))(
            this,
            fLuminanceInNits
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayMaxLuminance(float* pfLuminanceInNits)
    {
        return ((delegate* unmanaged<IWICDisplayAdaptationControl, float*, int>)((*lpVtbl)[5]))(
            this,
            pfLuminanceInNits
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoesSupportChangingMaxLuminance(
            [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat,
            BOOL* pfIsSupported
        );

        [VtblIndex(4)]
        HRESULT SetDisplayMaxLuminance(float fLuminanceInNits);

        [VtblIndex(5)]
        HRESULT GetDisplayMaxLuminance(float* pfLuminanceInNits);
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

        [NativeTypeName("HRESULT (WICPixelFormatGUID *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL*, int> DoesSupportChangingMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetDisplayMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetDisplayMaxLuminance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICDisplayAdaptationControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICDisplayAdaptationControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICDisplayAdaptationControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICDisplayAdaptationControl(Silk.NET.Windows.IUnknown value)
    {
        return new IWICDisplayAdaptationControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICDisplayAdaptationControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICDisplayAdaptationControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICDisplayAdaptationControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
