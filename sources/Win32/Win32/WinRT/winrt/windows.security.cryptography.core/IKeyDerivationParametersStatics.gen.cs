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

[Guid("EA961FBE-F37F-4146-9DFE-A456F1735F4B")]
[NativeTypeName("struct IKeyDerivationParametersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationParametersStatics
    : IKeyDerivationParametersStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyDerivationParametersStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IKeyDerivationParametersStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKeyDerivationParametersStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKeyDerivationParametersStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IKeyDerivationParametersStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IKeyDerivationParametersStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IKeyDerivationParametersStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BuildForPbkdf2(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer pbkdf2Salt,
        [NativeTypeName("UINT32")] uint iterationCount,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")]
            IKeyDerivationParameters* value
    )
    {
        return (
            (delegate* unmanaged<
                IKeyDerivationParametersStatics,
                IBuffer,
                uint,
                IKeyDerivationParameters*,
                int>)((*lpVtbl)[6])
        )(this, pbkdf2Salt, iterationCount, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BuildForSP800108(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer label,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer context,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")]
            IKeyDerivationParameters* value
    )
    {
        return (
            (delegate* unmanaged<
                IKeyDerivationParametersStatics,
                IBuffer,
                IBuffer,
                IKeyDerivationParameters*,
                int>)((*lpVtbl)[7])
        )(this, label, context, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BuildForSP80056a(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer algorithmId,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer partyUInfo,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer partyVInfo,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer suppPubInfo,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer suppPrivInfo,
        [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")]
            IKeyDerivationParameters* value
    )
    {
        return (
            (delegate* unmanaged<
                IKeyDerivationParametersStatics,
                IBuffer,
                IBuffer,
                IBuffer,
                IBuffer,
                IBuffer,
                IKeyDerivationParameters*,
                int>)((*lpVtbl)[8])
        )(this, algorithmId, partyUInfo, partyVInfo, suppPubInfo, suppPrivInfo, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BuildForPbkdf2(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer pbkdf2Salt,
            [NativeTypeName("UINT32")] uint iterationCount,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **"
            )]
                IKeyDerivationParameters* value
        );

        [VtblIndex(7)]
        HRESULT BuildForSP800108(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer label,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer context,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **"
            )]
                IKeyDerivationParameters* value
        );

        [VtblIndex(8)]
        HRESULT BuildForSP80056a(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer algorithmId,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer partyUInfo,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer partyVInfo,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer suppPubInfo,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer suppPrivInfo,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **"
            )]
                IKeyDerivationParameters* value
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            uint,
            IKeyDerivationParameters*,
            int> BuildForPbkdf2;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IBuffer,
            IKeyDerivationParameters*,
            int> BuildForSP800108;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IBuffer,
            IBuffer,
            IBuffer,
            IBuffer,
            IKeyDerivationParameters*,
            int> BuildForSP80056a;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKeyDerivationParametersStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKeyDerivationParametersStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKeyDerivationParametersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKeyDerivationParametersStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IKeyDerivationParametersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyDerivationParametersStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyDerivationParametersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IKeyDerivationParametersStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKeyDerivationParametersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKeyDerivationParametersStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IKeyDerivationParametersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKeyDerivationParametersStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKeyDerivationParametersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKeyDerivationParametersStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
