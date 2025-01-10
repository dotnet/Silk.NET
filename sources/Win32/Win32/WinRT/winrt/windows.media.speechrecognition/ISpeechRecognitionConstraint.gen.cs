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

[Guid("79AC1628-4D68-43C4-8911-40DC4101B55B")]
[NativeTypeName("struct ISpeechRecognitionConstraint : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionConstraint
    : ISpeechRecognitionConstraint.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionConstraint));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionConstraint, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionConstraint, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpeechRecognitionConstraint, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Tag(HSTRING value)
    {
        return ((delegate* unmanaged<ISpeechRecognitionConstraint, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Type(
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *"
        )]
            SpeechRecognitionConstraintType* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionConstraint,
                SpeechRecognitionConstraintType*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Probability(
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *"
        )]
            SpeechRecognitionConstraintProbability* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionConstraint,
                SpeechRecognitionConstraintProbability*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Probability(
        [NativeTypeName(
            "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability"
        )]
            SpeechRecognitionConstraintProbability value
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechRecognitionConstraint,
                SpeechRecognitionConstraintProbability,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_Tag(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Tag(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Type(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *"
            )]
                SpeechRecognitionConstraintType* value
        );

        [VtblIndex(11)]
        HRESULT get_Probability(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *"
            )]
                SpeechRecognitionConstraintProbability* value
        );

        [VtblIndex(12)]
        HRESULT put_Probability(
            [NativeTypeName(
                "ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability"
            )]
                SpeechRecognitionConstraintProbability value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Tag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Tag;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechRecognitionConstraintType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SpeechRecognitionConstraintProbability*,
            int> get_Probability;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SpeechRecognitionConstraintProbability,
            int> put_Probability;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechRecognitionConstraint"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechRecognitionConstraint(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpeechRecognitionConstraint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionConstraint(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpeechRecognitionConstraint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionConstraint"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionConstraint"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpeechRecognitionConstraint value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechRecognitionConstraint"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechRecognitionConstraint(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechRecognitionConstraint(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechRecognitionConstraint"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechRecognitionConstraint"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechRecognitionConstraint value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
