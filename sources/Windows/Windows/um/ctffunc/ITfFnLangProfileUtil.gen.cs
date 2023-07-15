// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfFnLangProfileUtil.xml' path='doc/member[@name="ITfFnLangProfileUtil"]/*'/>
[Guid("A87A8574-A6C1-4E15-99F0-3D3965F548EB")]
[NativeTypeName("struct ITfFnLangProfileUtil : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnLangProfileUtil : ITfFnLangProfileUtil.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnLangProfileUtil));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, uint> )(lpVtbl[1]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, uint> )(lpVtbl[2]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, ushort**, int> )(lpVtbl[3]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnLangProfileUtil.xml' path='doc/member[@name="ITfFnLangProfileUtil.RegisterActiveProfiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RegisterActiveProfiles()
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, int> )(lpVtbl[4]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfFnLangProfileUtil.xml' path='doc/member[@name="ITfFnLangProfileUtil.IsProfileAvailableForLang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsProfileAvailableForLang([NativeTypeName("LANGID")] ushort langid, BOOL* pfAvailable)
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil*, ushort, BOOL*, int> )(lpVtbl[5]))((ITfFnLangProfileUtil*)Unsafe.AsPointer(ref this), langid, pfAvailable);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT RegisterActiveProfiles();
        [VtblIndex(5)]
        HRESULT IsProfileAvailableForLang([NativeTypeName("LANGID")] ushort langid, BOOL* pfAvailable);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RegisterActiveProfiles;
        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> IsProfileAvailableForLang;
    }
}