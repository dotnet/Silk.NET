// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfFnConfigureRegisterWord.xml' path='doc/member[@name="ITfFnConfigureRegisterWord"]/*'/>
[Guid("BB95808A-6D8F-4BCA-8400-5390B586AEDF")]
[NativeTypeName("struct ITfFnConfigureRegisterWord : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnConfigureRegisterWord : ITfFnConfigureRegisterWord.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnConfigureRegisterWord));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, uint> )(lpVtbl[1]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, uint> )(lpVtbl[2]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, ushort**, int> )(lpVtbl[3]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnConfigureRegisterWord.xml' path='doc/member[@name="ITfFnConfigureRegisterWord.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Show(HWND hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile, [NativeTypeName("BSTR")] ushort* bstrRegistered)
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, HWND, ushort, Guid*, ushort*, int> )(lpVtbl[4]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), hwndParent, langid, rguidProfile, bstrRegistered);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT Show(HWND hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile, [NativeTypeName("BSTR")] ushort* bstrRegistered);
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
        [NativeTypeName("HRESULT (HWND, LANGID, const GUID &, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort, Guid*, ushort*, int> Show;
    }
}