// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IObjectWithSelection.xml' path='doc/member[@name="IObjectWithSelection"]/*'/>
[Guid("1C9CD5BB-98E9-4491-A60F-31AACC72B83C")]
[NativeTypeName("struct IObjectWithSelection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithSelection : IObjectWithSelection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithSelection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int> )(lpVtbl[0]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectWithSelection*, uint> )(lpVtbl[1]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithSelection*, uint> )(lpVtbl[2]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IObjectWithSelection.xml' path='doc/member[@name="IObjectWithSelection.SetSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSelection(IShellItemArray* psia)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, IShellItemArray*, int> )(lpVtbl[3]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), psia);
    }

    /// <include file='IObjectWithSelection.xml' path='doc/member[@name="IObjectWithSelection.GetSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSelection([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int> )(lpVtbl[4]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSelection(IShellItemArray* psia);
        [VtblIndex(4)]
        HRESULT GetSelection([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, int> SetSelection;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetSelection;
    }
}