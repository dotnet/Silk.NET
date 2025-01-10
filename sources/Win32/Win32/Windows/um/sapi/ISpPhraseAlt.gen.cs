// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8FCEBC98-4E49-4067-9C6C-D86A0E092E3D")]
[NativeTypeName("struct ISpPhraseAlt : ISpPhrase")]
[NativeInheritance("ISpPhrase")]
public unsafe partial struct ISpPhraseAlt : ISpPhraseAlt.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhraseAlt));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhraseAlt, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpPhraseAlt, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhraseAlt, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhraseAlt, SPPHRASE**, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhraseAlt, SPSERIALIZEDPHRASE**, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpPhraseAlt, uint, uint, BOOL, ushort**, byte*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpPhraseAlt, uint, int>)((*lpVtbl)[6]))(this, dwValueTypes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAltInfo(
        ISpPhrase* ppParent,
        [NativeTypeName("ULONG *")] uint* pulStartElementInParent,
        [NativeTypeName("ULONG *")] uint* pcElementsInParent,
        [NativeTypeName("ULONG *")] uint* pcElementsInAlt
    )
    {
        return (
            (delegate* unmanaged<ISpPhraseAlt, ISpPhrase*, uint*, uint*, uint*, int>)((*lpVtbl)[7])
        )(this, ppParent, pulStartElementInParent, pcElementsInParent, pcElementsInAlt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<ISpPhraseAlt, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : ISpPhrase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetAltInfo(
            ISpPhrase* ppParent,
            [NativeTypeName("ULONG *")] uint* pulStartElementInParent,
            [NativeTypeName("ULONG *")] uint* pcElementsInParent,
            [NativeTypeName("ULONG *")] uint* pcElementsInAlt
        );

        [VtblIndex(8)]
        HRESULT Commit();
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

        [NativeTypeName(
            "HRESULT (ISpPhrase **, ULONG *, ULONG *, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpPhrase*, uint*, uint*, uint*, int> GetAltInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhraseAlt"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhraseAlt(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpPhrase"/> to <see cref = "ISpPhraseAlt"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpPhrase"/> instance to be converted </param>
    public static explicit operator ISpPhraseAlt(Silk.NET.Windows.ISpPhrase value)
    {
        return new ISpPhraseAlt(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhraseAlt"/> to <see cref = "Silk.NET.Windows.ISpPhrase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhraseAlt"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpPhrase(ISpPhraseAlt value)
    {
        return new Silk.NET.Windows.ISpPhrase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhraseAlt"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhraseAlt(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhraseAlt(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhraseAlt"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhraseAlt"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhraseAlt value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
