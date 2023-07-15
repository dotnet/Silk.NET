// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IElementBehaviorSiteLayout2.xml' path='doc/member[@name="IElementBehaviorSiteLayout2"]/*'/>
[Guid("3050F847-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteLayout2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSiteLayout2 : IElementBehaviorSiteLayout2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteLayout2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, uint> )(lpVtbl[1]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, uint> )(lpVtbl[2]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteLayout2.xml' path='doc/member[@name="IElementBehaviorSiteLayout2.GetFontInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontInfo(LOGFONTW* plf)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteLayout2*, LOGFONTW*, int> )(lpVtbl[3]))((IElementBehaviorSiteLayout2*)Unsafe.AsPointer(ref this), plf);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFontInfo(LOGFONTW* plf);
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
        [NativeTypeName("HRESULT (LOGFONTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, int> GetFontInfo;
    }
}