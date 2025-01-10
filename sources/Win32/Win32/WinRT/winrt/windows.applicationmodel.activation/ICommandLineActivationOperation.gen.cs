// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("994B2841-C59E-4F69-BCFD-B61ED4E622EB")]
[NativeTypeName("struct ICommandLineActivationOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICommandLineActivationOperation
    : ICommandLineActivationOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICommandLineActivationOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICommandLineActivationOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICommandLineActivationOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Arguments(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CurrentDirectoryPath(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ExitCode([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICommandLineActivationOperation, int, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ExitCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICommandLineActivationOperation, int*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
    )
    {
        return (
            (delegate* unmanaged<ICommandLineActivationOperation, IDeferral*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Arguments(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CurrentDirectoryPath(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_ExitCode([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_ExitCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Arguments;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CurrentDirectoryPath;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ExitCode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ExitCode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICommandLineActivationOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICommandLineActivationOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICommandLineActivationOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICommandLineActivationOperation(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICommandLineActivationOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommandLineActivationOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICommandLineActivationOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICommandLineActivationOperation value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICommandLineActivationOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICommandLineActivationOperation(Silk.NET.Windows.IUnknown value)
    {
        return new ICommandLineActivationOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommandLineActivationOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICommandLineActivationOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICommandLineActivationOperation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
