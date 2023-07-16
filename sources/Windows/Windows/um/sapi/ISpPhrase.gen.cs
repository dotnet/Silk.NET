// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpPhrase.xml' path='doc/member[@name="ISpPhrase"]/*'/>
[Guid("1A5C0354-B621-4B5A-8791-D306ED379E53")]
[NativeTypeName("struct ISpPhrase : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpPhrase : ISpPhrase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpPhrase));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpPhrase*, Guid*, void**, int> )(lpVtbl[0]))((ISpPhrase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpPhrase*, uint> )(lpVtbl[1]))((ISpPhrase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpPhrase*, uint> )(lpVtbl[2]))((ISpPhrase*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpPhrase.xml' path='doc/member[@name="ISpPhrase.GetPhrase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase*, SPPHRASE**, int> )(lpVtbl[3]))((ISpPhrase*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <include file='ISpPhrase.xml' path='doc/member[@name="ISpPhrase.GetSerializedPhrase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
    {
        return ((delegate* unmanaged<ISpPhrase*, SPSERIALIZEDPHRASE**, int> )(lpVtbl[4]))((ISpPhrase*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
    }

    /// <include file='ISpPhrase.xml' path='doc/member[@name="ISpPhrase.GetText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes)
    {
        return ((delegate* unmanaged<ISpPhrase*, uint, uint, BOOL, ushort**, byte*, int> )(lpVtbl[5]))((ISpPhrase*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
    }

    /// <include file='ISpPhrase.xml' path='doc/member[@name="ISpPhrase.Discard"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
    {
        return ((delegate* unmanaged<ISpPhrase*, uint, int> )(lpVtbl[6]))((ISpPhrase*)Unsafe.AsPointer(ref this), dwValueTypes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase);
        [VtblIndex(4)]
        HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase);
        [VtblIndex(5)]
        HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes);
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
}