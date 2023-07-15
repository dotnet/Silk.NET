// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfUIElement.xml' path='doc/member[@name="ITfUIElement"]/*'/>
[Guid("EA1EA137-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfUIElement : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfUIElement : ITfUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfUIElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfUIElement*, Guid*, void**, int> )(lpVtbl[0]))((ITfUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfUIElement*, uint> )(lpVtbl[1]))((ITfUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfUIElement*, uint> )(lpVtbl[2]))((ITfUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfUIElement.xml' path='doc/member[@name="ITfUIElement.GetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfUIElement*, ushort**, int> )(lpVtbl[3]))((ITfUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    /// <include file='ITfUIElement.xml' path='doc/member[@name="ITfUIElement.GetGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfUIElement*, Guid*, int> )(lpVtbl[4]))((ITfUIElement*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='ITfUIElement.xml' path='doc/member[@name="ITfUIElement.Show"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfUIElement*, BOOL, int> )(lpVtbl[5]))((ITfUIElement*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <include file='ITfUIElement.xml' path='doc/member[@name="ITfUIElement.IsShown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfUIElement*, BOOL*, int> )(lpVtbl[6]))((ITfUIElement*)Unsafe.AsPointer(ref this), pbShow);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription);
        [VtblIndex(4)]
        HRESULT GetGUID(Guid* pguid);
        [VtblIndex(5)]
        HRESULT Show(BOOL bShow);
        [VtblIndex(6)]
        HRESULT IsShown(BOOL* pbShow);
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
    }
}