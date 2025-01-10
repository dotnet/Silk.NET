// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1A5C0354-B621-4B5A-8791-D306ED379E53")]
[NativeTypeName("struct ISpPhrase : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpPhrase : ISpPhrase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhrase));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhrase, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpPhrase, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhrase, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase, SPPHRASE**, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase, SPSERIALIZEDPHRASE**, int>)((*lpVtbl)[4]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetText(
        [NativeTypeName("ULONG")] uint ulStart,
        [NativeTypeName("ULONG")] uint ulCount,
        BOOL fUseTextReplacements,
        [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText,
        byte* pbDisplayAttributes
    )
    {
        return (
            (delegate* unmanaged<ISpPhrase, uint, uint, BOOL, ushort**, byte*, int>)((*lpVtbl)[5])
        )(this, ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpPhrase, uint, int>)((*lpVtbl)[6]))(this, dwValueTypes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase);

        [VtblIndex(4)]
        HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase);

        [VtblIndex(5)]
        HRESULT GetText(
            [NativeTypeName("ULONG")] uint ulStart,
            [NativeTypeName("ULONG")] uint ulCount,
            BOOL fUseTextReplacements,
            [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText,
            byte* pbDisplayAttributes
        );

        [VtblIndex(6)]
        HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes);
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

        [NativeTypeName("HRESULT (SPPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPPHRASE**, int> GetPhrase;

        [NativeTypeName("HRESULT (SPSERIALIZEDPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSERIALIZEDPHRASE**, int> GetSerializedPhrase;

        [NativeTypeName("HRESULT (ULONG, ULONG, BOOL, LPWSTR *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, ushort**, byte*, int> GetText;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Discard;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhrase"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhrase(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhrase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhrase(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhrase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhrase"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhrase"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhrase value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
