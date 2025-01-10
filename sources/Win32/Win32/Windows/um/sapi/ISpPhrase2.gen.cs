// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F264DA52-E457-4696-B856-A737B717AF79")]
[NativeTypeName("struct ISpPhrase2 : ISpPhrase")]
[NativeInheritance("ISpPhrase")]
public unsafe partial struct ISpPhrase2 : ISpPhrase2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhrase2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhrase2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpPhrase2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhrase2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase2, SPPHRASE**, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemPhrase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase2, SPSERIALIZEDPHRASE**, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpPhrase2, uint, uint, BOOL, ushort**, byte*, int>)((*lpVtbl)[5])
        )(this, ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpPhrase2, uint, int>)((*lpVtbl)[6]))(this, dwValueTypes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetXMLResult(
        [NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult,
        SPXMLRESULTOPTIONS Options
    )
    {
        return ((delegate* unmanaged<ISpPhrase2, ushort**, SPXMLRESULTOPTIONS, int>)((*lpVtbl)[7]))(
            this,
            ppszCoMemXMLResult,
            Options
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo)
    {
        return ((delegate* unmanaged<ISpPhrase2, SPSEMANTICERRORINFO*, int>)((*lpVtbl)[8]))(
            this,
            pSemanticErrorInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAudio(
        [NativeTypeName("ULONG")] uint ulStartElement,
        [NativeTypeName("ULONG")] uint cElements,
        ISpStreamFormat* ppStream
    )
    {
        return ((delegate* unmanaged<ISpPhrase2, uint, uint, ISpStreamFormat*, int>)((*lpVtbl)[9]))(
            this,
            ulStartElement,
            cElements,
            ppStream
        );
    }

    public interface Interface : ISpPhrase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetXMLResult(
            [NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult,
            SPXMLRESULTOPTIONS Options
        );

        [VtblIndex(8)]
        HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo);

        [VtblIndex(9)]
        HRESULT GetAudio(
            [NativeTypeName("ULONG")] uint ulStartElement,
            [NativeTypeName("ULONG")] uint cElements,
            ISpStreamFormat* ppStream
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

        [NativeTypeName("HRESULT (SPPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPPHRASE**, int> GetPhrase;

        [NativeTypeName("HRESULT (SPSERIALIZEDPHRASE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSERIALIZEDPHRASE**, int> GetSerializedPhrase;

        [NativeTypeName("HRESULT (ULONG, ULONG, BOOL, LPWSTR *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, ushort**, byte*, int> GetText;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Discard;

        [NativeTypeName("HRESULT (LPWSTR *, SPXMLRESULTOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, SPXMLRESULTOPTIONS, int> GetXMLResult;

        [NativeTypeName("HRESULT (SPSEMANTICERRORINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSEMANTICERRORINFO*, int> GetXMLErrorInfo;

        [NativeTypeName("HRESULT (ULONG, ULONG, ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ISpStreamFormat*, int> GetAudio;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpPhrase2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpPhrase2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpPhrase"/> to <see cref = "ISpPhrase2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpPhrase"/> instance to be converted </param>
    public static explicit operator ISpPhrase2(Silk.NET.Windows.ISpPhrase value)
    {
        return new ISpPhrase2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhrase2"/> to <see cref = "Silk.NET.Windows.ISpPhrase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhrase2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpPhrase(ISpPhrase2 value)
    {
        return new Silk.NET.Windows.ISpPhrase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpPhrase2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpPhrase2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpPhrase2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpPhrase2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpPhrase2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpPhrase2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
