// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLSelectElementEx.xml' path='doc/member[@name="IHTMLSelectElementEx"]/*'/>
[Guid("3050F2D1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLSelectElementEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLSelectElementEx : IHTMLSelectElementEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLSelectElementEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, uint> )(lpVtbl[1]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, uint> )(lpVtbl[2]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLSelectElementEx.xml' path='doc/member[@name="IHTMLSelectElementEx.ShowDropdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowDropdown(BOOL fShow)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, BOOL, int> )(lpVtbl[3]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <include file='IHTMLSelectElementEx.xml' path='doc/member[@name="IHTMLSelectElementEx.SetSelectExFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSelectExFlags([NativeTypeName("DWORD")] uint lFlags)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, uint, int> )(lpVtbl[4]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IHTMLSelectElementEx.xml' path='doc/member[@name="IHTMLSelectElementEx.GetSelectExFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSelectExFlags([NativeTypeName("DWORD *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, uint*, int> )(lpVtbl[5]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), pFlags);
    }

    /// <include file='IHTMLSelectElementEx.xml' path='doc/member[@name="IHTMLSelectElementEx.GetDropdownOpen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDropdownOpen(BOOL* pfOpen)
    {
        return ((delegate* unmanaged<IHTMLSelectElementEx*, BOOL*, int> )(lpVtbl[6]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), pfOpen);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowDropdown(BOOL fShow);
        [VtblIndex(4)]
        HRESULT SetSelectExFlags([NativeTypeName("DWORD")] uint lFlags);
        [VtblIndex(5)]
        HRESULT GetSelectExFlags([NativeTypeName("DWORD *")] uint* pFlags);
        [VtblIndex(6)]
        HRESULT GetDropdownOpen(BOOL* pfOpen);
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
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowDropdown;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSelectExFlags;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSelectExFlags;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetDropdownOpen;
    }
}