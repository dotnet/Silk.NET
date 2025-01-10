// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F237F327-5181-4F24-96A7-700A4E5FAC62")]
[NativeTypeName("struct ISecondaryAuthenticationFactorAuthenticationTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SecondaryAuthenticationFactorAuthenticationTrigger is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct ISecondaryAuthenticationFactorAuthenticationTrigger
    : ISecondaryAuthenticationFactorAuthenticationTrigger.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ISecondaryAuthenticationFactorAuthenticationTrigger)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISecondaryAuthenticationFactorAuthenticationTrigger,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISecondaryAuthenticationFactorAuthenticationTrigger, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISecondaryAuthenticationFactorAuthenticationTrigger, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                ISecondaryAuthenticationFactorAuthenticationTrigger,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                ISecondaryAuthenticationFactorAuthenticationTrigger,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                ISecondaryAuthenticationFactorAuthenticationTrigger,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    public interface Interface : IInspectable.Interface { }

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
    }

    /// <summary>Initializes a new instance of the <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISecondaryAuthenticationFactorAuthenticationTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISecondaryAuthenticationFactorAuthenticationTrigger(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISecondaryAuthenticationFactorAuthenticationTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISecondaryAuthenticationFactorAuthenticationTrigger value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISecondaryAuthenticationFactorAuthenticationTrigger(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISecondaryAuthenticationFactorAuthenticationTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISecondaryAuthenticationFactorAuthenticationTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISecondaryAuthenticationFactorAuthenticationTrigger value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
