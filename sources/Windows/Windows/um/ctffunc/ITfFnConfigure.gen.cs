// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfFnConfigure.xml' path='doc/member[@name="ITfFnConfigure"]/*'/>
[Guid("88F567C6-1757-49F8-A1B2-89234C1EEFF9")]
[NativeTypeName("struct ITfFnConfigure : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnConfigure : ITfFnConfigure.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnConfigure));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnConfigure*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnConfigure*, uint> )(lpVtbl[1]))((ITfFnConfigure*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnConfigure*, uint> )(lpVtbl[2]))((ITfFnConfigure*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnConfigure*, ushort**, int> )(lpVtbl[3]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnConfigure.xml' path='doc/member[@name="ITfFnConfigure.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Show(HWND hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile)
    {
        return ((delegate* unmanaged<ITfFnConfigure*, HWND, ushort, Guid*, int> )(lpVtbl[4]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), hwndParent, langid, rguidProfile);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT Show(HWND hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile);
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
        [NativeTypeName("HRESULT (HWND, LANGID, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort, Guid*, int> Show;
    }
}