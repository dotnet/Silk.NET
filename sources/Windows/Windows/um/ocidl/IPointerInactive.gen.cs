// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPointerInactive.xml' path='doc/member[@name="IPointerInactive"]/*'/>
[Guid("55980BA0-35AA-11CF-B671-00AA004CD6D8")]
[NativeTypeName("struct IPointerInactive : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPointerInactive : IPointerInactive.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerInactive));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPointerInactive*, Guid*, void**, int> )(lpVtbl[0]))((IPointerInactive*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPointerInactive*, uint> )(lpVtbl[1]))((IPointerInactive*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPointerInactive*, uint> )(lpVtbl[2]))((IPointerInactive*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPointerInactive.xml' path='doc/member[@name="IPointerInactive.GetActivationPolicy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetActivationPolicy([NativeTypeName("DWORD *")] uint* pdwPolicy)
    {
        return ((delegate* unmanaged<IPointerInactive*, uint*, int> )(lpVtbl[3]))((IPointerInactive*)Unsafe.AsPointer(ref this), pdwPolicy);
    }

    /// <include file='IPointerInactive.xml' path='doc/member[@name="IPointerInactive.OnInactiveMouseMove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnInactiveMouseMove([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint grfKeyState)
    {
        return ((delegate* unmanaged<IPointerInactive*, RECT*, int, int, uint, int> )(lpVtbl[4]))((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, grfKeyState);
    }

    /// <include file='IPointerInactive.xml' path='doc/member[@name="IPointerInactive.OnInactiveSetCursor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnInactiveSetCursor([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint dwMouseMsg, BOOL fSetAlways)
    {
        return ((delegate* unmanaged<IPointerInactive*, RECT*, int, int, uint, BOOL, int> )(lpVtbl[5]))((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, dwMouseMsg, fSetAlways);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetActivationPolicy([NativeTypeName("DWORD *")] uint* pdwPolicy);
        [VtblIndex(4)]
        HRESULT OnInactiveMouseMove([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint grfKeyState);
        [VtblIndex(5)]
        HRESULT OnInactiveSetCursor([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint dwMouseMsg, BOOL fSetAlways);
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetActivationPolicy;
        [NativeTypeName("HRESULT (LPCRECT, LONG, LONG, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int, int, uint, int> OnInactiveMouseMove;
        [NativeTypeName("HRESULT (LPCRECT, LONG, LONG, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int, int, uint, BOOL, int> OnInactiveSetCursor;
    }
}