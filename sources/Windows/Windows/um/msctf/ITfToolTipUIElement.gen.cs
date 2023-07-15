// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfToolTipUIElement.xml' path='doc/member[@name="ITfToolTipUIElement"]/*'/>
[Guid("52B18B5C-555D-46B2-B00A-FA680144FBDB")]
[NativeTypeName("struct ITfToolTipUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfToolTipUIElement : ITfToolTipUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfToolTipUIElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, Guid*, void**, int> )(lpVtbl[0]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, uint> )(lpVtbl[1]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, uint> )(lpVtbl[2]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfUIElement.GetDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, ushort**, int> )(lpVtbl[3]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    /// <inheritdoc cref = "ITfUIElement.GetGUID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, Guid*, int> )(lpVtbl[4]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <inheritdoc cref = "ITfUIElement.Show"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, BOOL, int> )(lpVtbl[5]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <inheritdoc cref = "ITfUIElement.IsShown"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, BOOL*, int> )(lpVtbl[6]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pbShow);
    }

    /// <include file='ITfToolTipUIElement.xml' path='doc/member[@name="ITfToolTipUIElement.GetString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfToolTipUIElement*, ushort**, int> )(lpVtbl[7]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pstr);
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr);
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
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsShown;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetString;
    }
}