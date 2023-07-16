// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IGamutMapModelPlugIn.xml' path='doc/member[@name="IGamutMapModelPlugIn"]/*'/>
[Guid("2DD80115-AD1E-41F6-A219-A4F4B583D1F9")]
[NativeTypeName("struct IGamutMapModelPlugIn : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGamutMapModelPlugIn : IGamutMapModelPlugIn.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGamutMapModelPlugIn));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGamutMapModelPlugIn*, Guid*, void**, int> )(lpVtbl[0]))((IGamutMapModelPlugIn*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGamutMapModelPlugIn*, uint> )(lpVtbl[1]))((IGamutMapModelPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGamutMapModelPlugIn*, uint> )(lpVtbl[2]))((IGamutMapModelPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGamutMapModelPlugIn.xml' path='doc/member[@name="IGamutMapModelPlugIn.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("BSTR")] ushort* bstrXml, IDeviceModelPlugIn* pSrcPlugIn, IDeviceModelPlugIn* pDestPlugIn, GamutBoundaryDescription* pSrcGBD, GamutBoundaryDescription* pDestGBD)
    {
        return ((delegate* unmanaged<IGamutMapModelPlugIn*, ushort*, IDeviceModelPlugIn*, IDeviceModelPlugIn*, GamutBoundaryDescription*, GamutBoundaryDescription*, int> )(lpVtbl[3]))((IGamutMapModelPlugIn*)Unsafe.AsPointer(ref this), bstrXml, pSrcPlugIn, pDestPlugIn, pSrcGBD, pDestGBD);
    }

    /// <include file='IGamutMapModelPlugIn.xml' path='doc/member[@name="IGamutMapModelPlugIn.SourceToDestinationAppearanceColors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SourceToDestinationAppearanceColors(uint cColors, [NativeTypeName("const JChColorF *")] JChColorF* pInputColors, JChColorF* pOutputColors)
    {
        return ((delegate* unmanaged<IGamutMapModelPlugIn*, uint, JChColorF*, JChColorF*, int> )(lpVtbl[4]))((IGamutMapModelPlugIn*)Unsafe.AsPointer(ref this), cColors, pInputColors, pOutputColors);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("BSTR")] ushort* bstrXml, IDeviceModelPlugIn* pSrcPlugIn, IDeviceModelPlugIn* pDestPlugIn, GamutBoundaryDescription* pSrcGBD, GamutBoundaryDescription* pDestGBD);
        [VtblIndex(4)]
        HRESULT SourceToDestinationAppearanceColors(uint cColors, [NativeTypeName("const JChColorF *")] JChColorF* pInputColors, JChColorF* pOutputColors);
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
        [NativeTypeName("HRESULT (BSTR, IDeviceModelPlugIn *, IDeviceModelPlugIn *, GamutBoundaryDescription *, GamutBoundaryDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDeviceModelPlugIn*, IDeviceModelPlugIn*, GamutBoundaryDescription*, GamutBoundaryDescription*, int> Initialize;
        [NativeTypeName("HRESULT (UINT, const JChColorF *, JChColorF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, JChColorF*, JChColorF*, int> SourceToDestinationAppearanceColors;
    }
}