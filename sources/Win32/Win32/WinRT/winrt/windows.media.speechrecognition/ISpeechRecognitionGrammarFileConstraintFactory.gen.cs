// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3DA770EB-C479-4C27-9F19-89974EF392D1")]
[NativeTypeName("struct ISpeechRecognitionGrammarFileConstraintFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionGrammarFileConstraintFactory
    : ISpeechRecognitionGrammarFileConstraintFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ISpeechRecognitionGrammarFileConstraintFactory)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionGrammarFileConstraintFactory,
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
            (delegate* unmanaged<ISpeechRecognitionGrammarFileConstraintFactory, uint>)(
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
            (delegate* unmanaged<ISpeechRecognitionGrammarFileConstraintFactory, uint>)(
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
                ISpeechRecognitionGrammarFileConstraintFactory,
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
            (delegate* unmanaged<ISpeechRecognitionGrammarFileConstraintFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionGrammarFileConstraintFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **"
        )]
            ISpeechRecognitionGrammarFileConstraint* constraint
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionGrammarFileConstraintFactory,
                IStorageFile,
                ISpeechRecognitionGrammarFileConstraint*,
                int>)((*lpVtbl)[6])
        )(this, file, constraint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTag(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING tag,
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **"
        )]
            ISpeechRecognitionGrammarFileConstraint* constraint
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionGrammarFileConstraintFactory,
                IStorageFile,
                HSTRING,
                ISpeechRecognitionGrammarFileConstraint*,
                int>)((*lpVtbl)[7])
        )(this, file, tag, constraint);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **"
            )]
                ISpeechRecognitionGrammarFileConstraint* constraint
        );

        [VtblIndex(7)]
        HRESULT CreateWithTag(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING tag,
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **"
            )]
                ISpeechRecognitionGrammarFileConstraint* constraint
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            ISpeechRecognitionGrammarFileConstraint*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            ISpeechRecognitionGrammarFileConstraint*,
            int> CreateWithTag;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechRecognitionGrammarFileConstraintFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionGrammarFileConstraintFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISpeechRecognitionGrammarFileConstraintFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISpeechRecognitionGrammarFileConstraintFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionGrammarFileConstraintFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpeechRecognitionGrammarFileConstraintFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionGrammarFileConstraintFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpeechRecognitionGrammarFileConstraintFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
