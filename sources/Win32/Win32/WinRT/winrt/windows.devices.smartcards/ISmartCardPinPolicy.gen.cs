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

[Guid("183CE184-4DB6-4841-AC9E-2AC1F39B7304")]
[NativeTypeName("struct ISmartCardPinPolicy : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardPinPolicy : ISmartCardPinPolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardPinPolicy));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MinLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MinLength([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxLength([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ISmartCardPinPolicy, uint, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UppercaseLetters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")]
            SmartCardPinCharacterPolicyOption* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_UppercaseLetters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
            SmartCardPinCharacterPolicyOption value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LowercaseLetters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")]
            SmartCardPinCharacterPolicyOption* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_LowercaseLetters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
            SmartCardPinCharacterPolicyOption value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Digits(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")]
            SmartCardPinCharacterPolicyOption* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Digits(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
            SmartCardPinCharacterPolicyOption value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SpecialCharacters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *")]
            SmartCardPinCharacterPolicyOption* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SpecialCharacters(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
            SmartCardPinCharacterPolicyOption value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardPinPolicy, SmartCardPinCharacterPolicyOption, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MinLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_MinLength([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_MaxLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_MaxLength([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_UppercaseLetters(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *"
            )]
                SmartCardPinCharacterPolicyOption* value
        );

        [VtblIndex(11)]
        HRESULT put_UppercaseLetters(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
                SmartCardPinCharacterPolicyOption value
        );

        [VtblIndex(12)]
        HRESULT get_LowercaseLetters(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *"
            )]
                SmartCardPinCharacterPolicyOption* value
        );

        [VtblIndex(13)]
        HRESULT put_LowercaseLetters(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
                SmartCardPinCharacterPolicyOption value
        );

        [VtblIndex(14)]
        HRESULT get_Digits(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *"
            )]
                SmartCardPinCharacterPolicyOption* value
        );

        [VtblIndex(15)]
        HRESULT put_Digits(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
                SmartCardPinCharacterPolicyOption value
        );

        [VtblIndex(16)]
        HRESULT get_SpecialCharacters(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *"
            )]
                SmartCardPinCharacterPolicyOption* value
        );

        [VtblIndex(17)]
        HRESULT put_SpecialCharacters(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption")]
                SmartCardPinCharacterPolicyOption value
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MinLength;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_MinLength;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxLength;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_MaxLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption*,
            int> get_UppercaseLetters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption,
            int> put_UppercaseLetters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption*,
            int> get_LowercaseLetters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption,
            int> put_LowercaseLetters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardPinCharacterPolicyOption*, int> get_Digits;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardPinCharacterPolicyOption, int> put_Digits;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption*,
            int> get_SpecialCharacters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardPinCharacterPolicyOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardPinCharacterPolicyOption,
            int> put_SpecialCharacters;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardPinPolicy"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardPinPolicy(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardPinPolicy"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardPinPolicy(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardPinPolicy(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardPinPolicy"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardPinPolicy"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardPinPolicy value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardPinPolicy"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardPinPolicy(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardPinPolicy(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardPinPolicy"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardPinPolicy"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardPinPolicy value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
