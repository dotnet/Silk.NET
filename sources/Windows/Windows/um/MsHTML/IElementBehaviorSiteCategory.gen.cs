// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IElementBehaviorSiteCategory.xml' path='doc/member[@name="IElementBehaviorSiteCategory"]/*'/>
[Guid("3050F4EE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteCategory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSiteCategory : IElementBehaviorSiteCategory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteCategory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteCategory*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorSiteCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteCategory*, uint> )(lpVtbl[1]))((IElementBehaviorSiteCategory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteCategory*, uint> )(lpVtbl[2]))((IElementBehaviorSiteCategory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteCategory.xml' path='doc/member[@name="IElementBehaviorSiteCategory.GetRelatedBehaviors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRelatedBehaviors([NativeTypeName("LONG")] int lDirection, [NativeTypeName("LPOLESTR")] ushort* pchCategory, IEnumUnknown** ppEnumerator)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteCategory*, int, ushort*, IEnumUnknown**, int> )(lpVtbl[3]))((IElementBehaviorSiteCategory*)Unsafe.AsPointer(ref this), lDirection, pchCategory, ppEnumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRelatedBehaviors([NativeTypeName("LONG")] int lDirection, [NativeTypeName("LPOLESTR")] ushort* pchCategory, IEnumUnknown** ppEnumerator);
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
        [NativeTypeName("HRESULT (LONG, LPOLESTR, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, IEnumUnknown**, int> GetRelatedBehaviors;
    }
}