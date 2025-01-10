// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("138D5E40-F3BC-4A5C-B41D-4B4EF684E237")]
[NativeTypeName("struct ISmartCardPinResetHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISmartCardPinResetHandler
    : ISmartCardPinResetHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardPinResetHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmartCardPinResetHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmartCardPinResetHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardPinResetHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardProvisioning *")]
            ISmartCardProvisioning sender,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetRequest *")]
            ISmartCardPinResetRequest request
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardPinResetHandler,
                ISmartCardProvisioning,
                ISmartCardPinResetRequest,
                int>)((*lpVtbl)[3])
        )(this, sender, request);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardProvisioning *")]
                ISmartCardProvisioning sender,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetRequest *")]
                ISmartCardPinResetRequest request
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardProvisioning *, ABI::Windows::Devices::SmartCards::ISmartCardPinResetRequest *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCardProvisioning,
            ISmartCardPinResetRequest,
            int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardPinResetHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardPinResetHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardPinResetHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardPinResetHandler(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardPinResetHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardPinResetHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardPinResetHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardPinResetHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
