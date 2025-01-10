// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
[NativeTypeName("struct IWICBitmapCodecProgressNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapCodecProgressNotification
    : IWICBitmapCodecProgressNotification.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapCodecProgressNotification));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICBitmapCodecProgressNotification, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapCodecProgressNotification, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapCodecProgressNotification, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterProgressNotification(
        [NativeTypeName("PFNProgressNotification")]
            delegate* unmanaged<
            void*,
            uint,
            WICProgressOperation,
            double,
            HRESULT> pfnProgressNotification,
        [NativeTypeName("LPVOID")] void* pvData,
        [NativeTypeName("DWORD")] uint dwProgressFlags
    )
    {
        return (
            (delegate* unmanaged<
                IWICBitmapCodecProgressNotification,
                delegate* unmanaged<void*, uint, WICProgressOperation, double, HRESULT>,
                void*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, pfnProgressNotification, pvData, dwProgressFlags);
    }

    public interface Interface : IUnknown.Interface { }

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
            "HRESULT (PFNProgressNotification, LPVOID, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<void*, uint, WICProgressOperation, double, HRESULT>,
            void*,
            uint,
            int> RegisterProgressNotification;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICBitmapCodecProgressNotification"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICBitmapCodecProgressNotification(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICBitmapCodecProgressNotification"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICBitmapCodecProgressNotification(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IWICBitmapCodecProgressNotification(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapCodecProgressNotification"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapCodecProgressNotification"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IWICBitmapCodecProgressNotification value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
