// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfInputScope2.xml' path='doc/member[@name="ITfInputScope2"]/*'/>
[Guid("5731EAA0-6BC2-4681-A532-92FBB74D7C41")]
[NativeTypeName("struct ITfInputScope2 : ITfInputScope")]
[NativeInheritance("ITfInputScope")]
public unsafe partial struct ITfInputScope2 : ITfInputScope2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputScope2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputScope2*, Guid*, void**, int> )(lpVtbl[0]))((ITfInputScope2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfInputScope2*, uint> )(lpVtbl[1]))((ITfInputScope2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputScope2*, uint> )(lpVtbl[2]))((ITfInputScope2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfInputScope.GetInputScopes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputScopes(InputScope** pprgInputScopes, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope2*, InputScope**, uint*, int> )(lpVtbl[3]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pprgInputScopes, pcCount);
    }

    /// <inheritdoc cref = "ITfInputScope.GetPhrase"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPhrase([NativeTypeName("BSTR **")] ushort*** ppbstrPhrases, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope2*, ushort***, uint*, int> )(lpVtbl[4]))((ITfInputScope2*)Unsafe.AsPointer(ref this), ppbstrPhrases, pcCount);
    }

    /// <inheritdoc cref = "ITfInputScope.GetRegularExpression"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRegularExpression([NativeTypeName("BSTR *")] ushort** pbstrRegExp)
    {
        return ((delegate* unmanaged<ITfInputScope2*, ushort**, int> )(lpVtbl[5]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrRegExp);
    }

    /// <inheritdoc cref = "ITfInputScope.GetSRGS"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSRGS([NativeTypeName("BSTR *")] ushort** pbstrSRGS)
    {
        return ((delegate* unmanaged<ITfInputScope2*, ushort**, int> )(lpVtbl[6]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrSRGS);
    }

    /// <inheritdoc cref = "ITfInputScope.GetXML"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetXML([NativeTypeName("BSTR *")] ushort** pbstrXML)
    {
        return ((delegate* unmanaged<ITfInputScope2*, ushort**, int> )(lpVtbl[7]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrXML);
    }

    /// <include file='ITfInputScope2.xml' path='doc/member[@name="ITfInputScope2.EnumWordList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumWordList(IEnumString** ppEnumString)
    {
        return ((delegate* unmanaged<ITfInputScope2*, IEnumString**, int> )(lpVtbl[8]))((ITfInputScope2*)Unsafe.AsPointer(ref this), ppEnumString);
    }

    public interface Interface : ITfInputScope.Interface
    {
        [VtblIndex(8)]
        HRESULT EnumWordList(IEnumString** ppEnumString);
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
        [NativeTypeName("HRESULT (InputScope **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InputScope**, uint*, int> GetInputScopes;
        [NativeTypeName("HRESULT (BSTR **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort***, uint*, int> GetPhrase;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRegularExpression;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSRGS;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetXML;
        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString**, int> EnumWordList;
    }
}