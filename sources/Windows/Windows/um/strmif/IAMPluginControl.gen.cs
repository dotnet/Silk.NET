// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl"]/*'/>
[Guid("0E26A181-F40C-4635-8786-976284B52981")]
[NativeTypeName("struct IAMPluginControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMPluginControl : IAMPluginControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMPluginControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMPluginControl*, Guid*, void**, int> )(lpVtbl[0]))((IAMPluginControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMPluginControl*, uint> )(lpVtbl[1]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMPluginControl*, uint> )(lpVtbl[2]))((IAMPluginControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.GetPreferredClsid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged<IAMPluginControl*, Guid*, Guid*, int> )(lpVtbl[3]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.GetPreferredClsidByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint index, Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged<IAMPluginControl*, uint, Guid*, Guid*, int> )(lpVtbl[4]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, subType, clsid);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.SetPreferredClsid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("const CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged<IAMPluginControl*, Guid*, Guid*, int> )(lpVtbl[5]))((IAMPluginControl*)Unsafe.AsPointer(ref this), subType, clsid);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.IsDisabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsDisabled([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<IAMPluginControl*, Guid*, int> )(lpVtbl[6]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.GetDisabledByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged<IAMPluginControl*, uint, Guid*, int> )(lpVtbl[7]))((IAMPluginControl*)Unsafe.AsPointer(ref this), index, clsid);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.SetDisabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDisabled([NativeTypeName("const IID &")] Guid* clsid, BOOL disabled)
    {
        return ((delegate* unmanaged<IAMPluginControl*, Guid*, BOOL, int> )(lpVtbl[8]))((IAMPluginControl*)Unsafe.AsPointer(ref this), clsid, disabled);
    }

    /// <include file='IAMPluginControl.xml' path='doc/member[@name="IAMPluginControl.IsLegacyDisabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsLegacyDisabled([NativeTypeName("LPCWSTR")] ushort* dllName)
    {
        return ((delegate* unmanaged<IAMPluginControl*, ushort*, int> )(lpVtbl[9]))((IAMPluginControl*)Unsafe.AsPointer(ref this), dllName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid);
        [VtblIndex(4)]
        HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint index, Guid* subType, [NativeTypeName("CLSID *")] Guid* clsid);
        [VtblIndex(5)]
        HRESULT SetPreferredClsid([NativeTypeName("const GUID &")] Guid* subType, [NativeTypeName("const CLSID *")] Guid* clsid);
        [VtblIndex(6)]
        HRESULT IsDisabled([NativeTypeName("const IID &")] Guid* clsid);
        [VtblIndex(7)]
        HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid);
        [VtblIndex(8)]
        HRESULT SetDisabled([NativeTypeName("const IID &")] Guid* clsid, BOOL disabled);
        [VtblIndex(9)]
        HRESULT IsLegacyDisabled([NativeTypeName("LPCWSTR")] ushort* dllName);
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
        [NativeTypeName("HRESULT (const GUID &, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> GetPreferredClsid;
        [NativeTypeName("HRESULT (DWORD, GUID *, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, int> GetPreferredClsidByIndex;
        [NativeTypeName("HRESULT (const GUID &, const CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetPreferredClsid;
        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsDisabled;
        [NativeTypeName("HRESULT (DWORD, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetDisabledByIndex;
        [NativeTypeName("HRESULT (const IID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL, int> SetDisabled;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> IsLegacyDisabled;
    }
}