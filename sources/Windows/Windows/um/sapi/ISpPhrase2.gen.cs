// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpPhrase2.xml' path='doc/member[@name="ISpPhrase2"]/*'/>
[Guid("F264DA52-E457-4696-B856-A737B717AF79")]
[NativeTypeName("struct ISpPhrase2 : ISpPhrase")]
[NativeInheritance("ISpPhrase")]
public unsafe partial struct ISpPhrase2 : ISpPhrase2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhrase2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhrase2*, Guid*, void**, int> )(lpVtbl[0]))((ISpPhrase2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpPhrase2*, uint> )(lpVtbl[1]))((ISpPhrase2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhrase2*, uint> )(lpVtbl[2]))((ISpPhrase2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpPhrase.GetPhrase"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase2*, SPPHRASE**, int> )(lpVtbl[3]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <inheritdoc cref = "ISpPhrase.GetSerializedPhrase"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase2*, SPSERIALIZEDPHRASE**, int> )(lpVtbl[4]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <inheritdoc cref = "ISpPhrase.GetText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes)
    {
        return ((delegate* unmanaged<ISpPhrase2*, uint, uint, BOOL, ushort**, byte*, int> )(lpVtbl[5]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    /// <inheritdoc cref = "ISpPhrase.Discard"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpPhrase2*, uint, int> )(lpVtbl[6]))((ISpPhrase2*)Unsafe.AsPointer(ref this), dwValueTypes);
    }

    /// <include file='ISpPhrase2.xml' path='doc/member[@name="ISpPhrase2.GetXMLResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetXMLResult([NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpPhrase2*, ushort**, SPXMLRESULTOPTIONS, int> )(lpVtbl[7]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppszCoMemXMLResult, Options);
    }

    /// <include file='ISpPhrase2.xml' path='doc/member[@name="ISpPhrase2.GetXMLErrorInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo)
    {
        return ((delegate* unmanaged<ISpPhrase2*, SPSEMANTICERRORINFO*, int> )(lpVtbl[8]))((ISpPhrase2*)Unsafe.AsPointer(ref this), pSemanticErrorInfo);
    }

    /// <include file='ISpPhrase2.xml' path='doc/member[@name="ISpPhrase2.GetAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
    {
        return ((delegate* unmanaged<ISpPhrase2*, uint, uint, ISpStreamFormat**, int> )(lpVtbl[9]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
    }

    public interface Interface : ISpPhrase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetXMLResult([NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options);
        [VtblIndex(8)]
        HRESULT GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo);
        [VtblIndex(9)]
        HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream);
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
        public delegate* unmanaged<TSelf*, uint, uint, ISpStreamFormat**, int> GetAudio;
    }
}