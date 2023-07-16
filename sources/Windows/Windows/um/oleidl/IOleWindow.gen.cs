// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IOleWindow.xml' path='doc/member[@name="IOleWindow"]/*'/>
[Guid("00000114-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleWindow : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleWindow : IOleWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleWindow));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleWindow*, Guid*, void**, int> )(lpVtbl[0]))((IOleWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleWindow*, uint> )(lpVtbl[1]))((IOleWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleWindow*, uint> )(lpVtbl[2]))((IOleWindow*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleWindow.xml' path='doc/member[@name="IOleWindow.GetWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleWindow*, HWND*, int> )(lpVtbl[3]))((IOleWindow*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='IOleWindow.xml' path='doc/member[@name="IOleWindow.ContextSensitiveHelp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleWindow*, BOOL, int> )(lpVtbl[4]))((IOleWindow*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow(HWND* phwnd);
        [VtblIndex(4)]
        HRESULT ContextSensitiveHelp(BOOL fEnterMode);
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
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;
    }
}