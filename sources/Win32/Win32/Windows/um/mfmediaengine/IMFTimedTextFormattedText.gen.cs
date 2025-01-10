// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E13AF3C1-4D47-4354-B1F5-E83AE0ECAE60")]
[NativeTypeName("struct IMFTimedTextFormattedText : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextFormattedText
    : IMFTimedTextFormattedText.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextFormattedText));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextFormattedText, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedTextFormattedText, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextFormattedText, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetText([NativeTypeName("LPWSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IMFTimedTextFormattedText, ushort**, int>)((*lpVtbl)[3]))(
            this,
            text
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("DWORD")]
    public uint GetSubformattingCount()
    {
        return ((delegate* unmanaged<IMFTimedTextFormattedText, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSubformatting(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("DWORD *")] uint* firstChar,
        [NativeTypeName("DWORD *")] uint* charLength,
        IMFTimedTextStyle* style
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedTextFormattedText,
                uint,
                uint*,
                uint*,
                IMFTimedTextStyle*,
                int>)((*lpVtbl)[5])
        )(this, index, firstChar, charLength, style);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetText([NativeTypeName("LPWSTR *")] ushort** text);

        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        uint GetSubformattingCount();

        [VtblIndex(5)]
        HRESULT GetSubformatting(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("DWORD *")] uint* firstChar,
            [NativeTypeName("DWORD *")] uint* charLength,
            IMFTimedTextStyle* style
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetText;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSubformattingCount;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD *, DWORD *, IMFTimedTextStyle **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint*,
            uint*,
            IMFTimedTextStyle*,
            int> GetSubformatting;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextFormattedText"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextFormattedText(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextFormattedText"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextFormattedText(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextFormattedText(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextFormattedText"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextFormattedText"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextFormattedText value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
