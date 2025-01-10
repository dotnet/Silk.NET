// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5CFAD8DE-F15C-4554-A813-C113C3881B09")]
[NativeTypeName("struct IDiagnosticInvokerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDiagnosticInvokerStatics
    : IDiagnosticInvokerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiagnosticInvokerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault(
        [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")]
            IDiagnosticInvoker* result
    )
    {
        return (
            (delegate* unmanaged<IDiagnosticInvokerStatics, IDiagnosticInvoker*, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")]
            IDiagnosticInvoker* result
    )
    {
        return (
            (delegate* unmanaged<IDiagnosticInvokerStatics, IUser, IDiagnosticInvoker*, int>)(
                (*lpVtbl)[7]
            )
        )(this, user, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDiagnosticInvokerStatics, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault(
            [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")]
                IDiagnosticInvoker* result
        );

        [VtblIndex(7)]
        HRESULT GetForUser(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::System::Diagnostics::IDiagnosticInvoker **")]
                IDiagnosticInvoker* result
        );

        [VtblIndex(8)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::System::Diagnostics::IDiagnosticInvoker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDiagnosticInvoker*, int> GetDefault;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::System::Diagnostics::IDiagnosticInvoker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUser, IDiagnosticInvoker*, int> GetForUser;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiagnosticInvokerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiagnosticInvokerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDiagnosticInvokerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDiagnosticInvokerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IDiagnosticInvokerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiagnosticInvokerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDiagnosticInvokerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDiagnosticInvokerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiagnosticInvokerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiagnosticInvokerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IDiagnosticInvokerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiagnosticInvokerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiagnosticInvokerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiagnosticInvokerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
