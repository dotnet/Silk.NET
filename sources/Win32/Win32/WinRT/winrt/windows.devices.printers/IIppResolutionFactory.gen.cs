// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E481C2AE-251A-5326-B173-95543ED99A35")]
[NativeTypeName("struct IIppResolutionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppResolutionFactory : IIppResolutionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppResolutionFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppResolutionFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppResolutionFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppResolutionFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppResolutionFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppResolutionFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppResolutionFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance(
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Devices::Printers::IppResolutionUnit")]
            IppResolutionUnit unit,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution **")] IIppResolution* value
    )
    {
        return (
            (delegate* unmanaged<
                IIppResolutionFactory,
                int,
                int,
                IppResolutionUnit,
                IIppResolution*,
                int>)((*lpVtbl)[6])
        )(this, width, height, unit, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance(
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Devices::Printers::IppResolutionUnit")]
                IppResolutionUnit unit,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution **")]
                IIppResolution* value
        );
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

        [NativeTypeName(
            "HRESULT (INT32, INT32, ABI::Windows::Devices::Printers::IppResolutionUnit, ABI::Windows::Devices::Printers::IIppResolution **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            IppResolutionUnit,
            IIppResolution*,
            int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppResolutionFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppResolutionFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppResolutionFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppResolutionFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppResolutionFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppResolutionFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppResolutionFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppResolutionFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppResolutionFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppResolutionFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IIppResolutionFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppResolutionFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppResolutionFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppResolutionFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
