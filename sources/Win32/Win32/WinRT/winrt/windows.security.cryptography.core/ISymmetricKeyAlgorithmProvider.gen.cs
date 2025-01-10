// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3D7E4A33-3BD0-4902-8AC8-470D50D21376")]
[NativeTypeName("struct ISymmetricKeyAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISymmetricKeyAlgorithmProvider
    : ISymmetricKeyAlgorithmProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISymmetricKeyAlgorithmProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISymmetricKeyAlgorithmProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISymmetricKeyAlgorithmProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISymmetricKeyAlgorithmProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISymmetricKeyAlgorithmProvider, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISymmetricKeyAlgorithmProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISymmetricKeyAlgorithmProvider, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged<ISymmetricKeyAlgorithmProvider, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BlockLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISymmetricKeyAlgorithmProvider, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSymmetricKey(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyMaterial,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
            ICryptographicKey* key
    )
    {
        return (
            (delegate* unmanaged<ISymmetricKeyAlgorithmProvider, IBuffer, ICryptographicKey*, int>)(
                (*lpVtbl)[8]
            )
        )(this, keyMaterial, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_BlockLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT CreateSymmetricKey(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer keyMaterial,
            [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")]
                ICryptographicKey* key
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AlgorithmName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_BlockLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, ICryptographicKey*, int> CreateSymmetricKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISymmetricKeyAlgorithmProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISymmetricKeyAlgorithmProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISymmetricKeyAlgorithmProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISymmetricKeyAlgorithmProvider(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISymmetricKeyAlgorithmProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISymmetricKeyAlgorithmProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISymmetricKeyAlgorithmProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISymmetricKeyAlgorithmProvider value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISymmetricKeyAlgorithmProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISymmetricKeyAlgorithmProvider(Silk.NET.Windows.IUnknown value)
    {
        return new ISymmetricKeyAlgorithmProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISymmetricKeyAlgorithmProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISymmetricKeyAlgorithmProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISymmetricKeyAlgorithmProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
