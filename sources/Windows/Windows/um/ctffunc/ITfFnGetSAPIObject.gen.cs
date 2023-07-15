// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfFnGetSAPIObject.xml' path='doc/member[@name="ITfFnGetSAPIObject"]/*'/>
[Guid("5C0AB7EA-167D-4F59-BFB5-4693755E90CA")]
[NativeTypeName("struct ITfFnGetSAPIObject : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnGetSAPIObject : ITfFnGetSAPIObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnGetSAPIObject));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnGetSAPIObject*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnGetSAPIObject*, uint> )(lpVtbl[1]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnGetSAPIObject*, uint> )(lpVtbl[2]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnGetSAPIObject*, ushort**, int> )(lpVtbl[3]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnGetSAPIObject.xml' path='doc/member[@name="ITfFnGetSAPIObject.Get"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Get(TfSapiObject sObj, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITfFnGetSAPIObject*, TfSapiObject, IUnknown**, int> )(lpVtbl[4]))((ITfFnGetSAPIObject*)Unsafe.AsPointer(ref this), sObj, ppunk);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT Get(TfSapiObject sObj, IUnknown** ppunk);
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
        [NativeTypeName("HRESULT (TfSapiObject, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfSapiObject, IUnknown**, int> Get;
    }
}