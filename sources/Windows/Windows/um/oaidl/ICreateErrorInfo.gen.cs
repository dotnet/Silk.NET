// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo"]/*'/>
[Guid("22F03340-547D-101B-8E65-08002B2BD119")]
[NativeTypeName("struct ICreateErrorInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreateErrorInfo : ICreateErrorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateErrorInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, Guid*, void**, int> )(lpVtbl[0]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, uint> )(lpVtbl[1]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, uint> )(lpVtbl[2]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo.SetGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, Guid*, int> )(lpVtbl[3]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
    }

    /// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo.SetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int> )(lpVtbl[4]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
    }

    /// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo.SetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int> )(lpVtbl[5]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
    }

    /// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo.SetHelpFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, ushort*, int> )(lpVtbl[6]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
    }

    /// <include file='ICreateErrorInfo.xml' path='doc/member[@name="ICreateErrorInfo.SetHelpContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateErrorInfo*, uint, int> )(lpVtbl[7]))((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* rguid);
        [VtblIndex(4)]
        HRESULT SetSource([NativeTypeName("LPOLESTR")] ushort* szSource);
        [VtblIndex(5)]
        HRESULT SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription);
        [VtblIndex(6)]
        HRESULT SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile);
        [VtblIndex(7)]
        HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext);
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
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetGUID;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSource;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDescription;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetHelpFile;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpContext;
    }
}