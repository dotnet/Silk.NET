// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("65AED1AE-B95B-450C-882B-6255187F397E")]
[NativeTypeName("struct IPackage4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage4 : IPackage4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackage4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackage4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackage4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackage4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPackage4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPackage4, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPackage4, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SignatureKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::PackageSignatureKind *")]
            PackageSignatureKind* value
    )
    {
        return ((delegate* unmanaged<IPackage4, PackageSignatureKind*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsOptional([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackage4, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT VerifyContentIntegrityAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return ((delegate* unmanaged<IPackage4, IAsyncOperation<byte>**, int>)((*lpVtbl)[8]))(
            this,
            operation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SignatureKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::PackageSignatureKind *")]
                PackageSignatureKind* value
        );

        [VtblIndex(7)]
        HRESULT get_IsOptional([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT VerifyContentIntegrityAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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
            "HRESULT (ABI::Windows::ApplicationModel::PackageSignatureKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PackageSignatureKind*, int> get_SignatureKind;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOptional;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<byte>**,
            int> VerifyContentIntegrityAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackage4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackage4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackage4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackage4(Silk.NET.WinRT.IInspectable value)
    {
        return new IPackage4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPackage4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackage4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackage4(Silk.NET.Windows.IUnknown value)
    {
        return new IPackage4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackage4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
