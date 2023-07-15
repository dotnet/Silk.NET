// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary"]/*'/>
[Guid("1DC4CB5F-D737-474D-ADE9-5CCFC9BC1CC9")]
[NativeTypeName("struct IAccDictionary : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccDictionary : IAccDictionary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccDictionary));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccDictionary*, Guid*, void**, int> )(lpVtbl[0]))((IAccDictionary*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccDictionary*, uint> )(lpVtbl[1]))((IAccDictionary*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccDictionary*, uint> )(lpVtbl[2]))((IAccDictionary*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary.GetLocalizedString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLocalizedString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pResult, [NativeTypeName("LCID *")] uint* plcid)
    {
        return ((delegate* unmanaged<IAccDictionary*, Guid*, uint, ushort**, uint*, int> )(lpVtbl[3]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, lcid, pResult, plcid);
    }

    /// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary.GetParentTerm"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetParentTerm([NativeTypeName("const GUID &")] Guid* Term, Guid* pParentTerm)
    {
        return ((delegate* unmanaged<IAccDictionary*, Guid*, Guid*, int> )(lpVtbl[4]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, pParentTerm);
    }

    /// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary.GetMnemonicString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMnemonicString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IAccDictionary*, Guid*, ushort**, int> )(lpVtbl[5]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, pResult);
    }

    /// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary.LookupMnemonicTerm"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LookupMnemonicTerm([NativeTypeName("BSTR")] ushort* bstrMnemonic, Guid* pTerm)
    {
        return ((delegate* unmanaged<IAccDictionary*, ushort*, Guid*, int> )(lpVtbl[6]))((IAccDictionary*)Unsafe.AsPointer(ref this), bstrMnemonic, pTerm);
    }

    /// <include file='IAccDictionary.xml' path='doc/member[@name="IAccDictionary.ConvertValueToString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertValueToString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, VARIANT varValue, [NativeTypeName("BSTR *")] ushort** pbstrResult, [NativeTypeName("LCID *")] uint* plcid)
    {
        return ((delegate* unmanaged<IAccDictionary*, Guid*, uint, VARIANT, ushort**, uint*, int> )(lpVtbl[7]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, lcid, varValue, pbstrResult, plcid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLocalizedString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pResult, [NativeTypeName("LCID *")] uint* plcid);
        [VtblIndex(4)]
        HRESULT GetParentTerm([NativeTypeName("const GUID &")] Guid* Term, Guid* pParentTerm);
        [VtblIndex(5)]
        HRESULT GetMnemonicString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(6)]
        HRESULT LookupMnemonicTerm([NativeTypeName("BSTR")] ushort* bstrMnemonic, Guid* pTerm);
        [VtblIndex(7)]
        HRESULT ConvertValueToString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, VARIANT varValue, [NativeTypeName("BSTR *")] ushort** pbstrResult, [NativeTypeName("LCID *")] uint* plcid);
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
        [NativeTypeName("HRESULT (const GUID &, LCID, BSTR *, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, ushort**, uint*, int> GetLocalizedString;
        [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> GetParentTerm;
        [NativeTypeName("HRESULT (const GUID &, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, int> GetMnemonicString;
        [NativeTypeName("HRESULT (BSTR, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> LookupMnemonicTerm;
        [NativeTypeName("HRESULT (const GUID &, LCID, VARIANT, BSTR *, LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, VARIANT, ushort**, uint*, int> ConvertValueToString;
    }
}