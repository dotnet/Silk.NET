// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn"]/*'/>
[Guid("1CD63475-07C4-46FE-A903-D655316D11FD")]
[NativeTypeName("struct IDeviceModelPlugIn : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceModelPlugIn : IDeviceModelPlugIn.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceModelPlugIn));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, Guid*, void**, int> )(lpVtbl[0]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint> )(lpVtbl[1]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint> )(lpVtbl[2]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("BSTR")] ushort* bstrXml, uint cNumModels, uint iModelPosition)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, ushort*, uint, uint, int> )(lpVtbl[3]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), bstrXml, cNumModels, iModelPosition);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetNumChannels"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNumChannels(uint* pNumChannels)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint*, int> )(lpVtbl[4]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), pNumChannels);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.DeviceToColorimetricColors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeviceToColorimetricColors(uint cColors, uint cChannels, [NativeTypeName("const FLOAT *")] float* pDeviceValues, XYZColorF* pXYZColors)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, uint, float*, XYZColorF*, int> )(lpVtbl[5]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), cColors, cChannels, pDeviceValues, pXYZColors);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.ColorimetricToDeviceColors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ColorimetricToDeviceColors(uint cColors, uint cChannels, [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors, float* pDeviceValues)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, uint, XYZColorF*, float*, int> )(lpVtbl[6]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), cColors, cChannels, pXYZColors, pDeviceValues);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.ColorimetricToDeviceColorsWithBlack"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ColorimetricToDeviceColorsWithBlack(uint cColors, uint cChannels, [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors, [NativeTypeName("const BlackInformation *")] BlackInformation* pBlackInformation, float* pDeviceValues)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, uint, XYZColorF*, BlackInformation*, float*, int> )(lpVtbl[7]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), cColors, cChannels, pXYZColors, pBlackInformation, pDeviceValues);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.SetTransformDeviceModelInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransformDeviceModelInfo(uint iModelPosition, IDeviceModelPlugIn* pIDeviceModelOther)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, IDeviceModelPlugIn*, int> )(lpVtbl[8]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), iModelPosition, pIDeviceModelOther);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetPrimarySamples"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrimarySamples(PrimaryXYZColors* pPrimaryColor)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, PrimaryXYZColors*, int> )(lpVtbl[9]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), pPrimaryColor);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetGamutBoundaryMeshSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGamutBoundaryMeshSize(uint* pNumVertices, uint* pNumTriangles)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint*, uint*, int> )(lpVtbl[10]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), pNumVertices, pNumTriangles);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetGamutBoundaryMesh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGamutBoundaryMesh(uint cChannels, uint cVertices, uint cTriangles, float* pVertices, GamutShellTriangle* pTriangles)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, uint, uint, float*, GamutShellTriangle*, int> )(lpVtbl[11]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), cChannels, cVertices, cTriangles, pVertices, pTriangles);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetNeutralAxisSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNeutralAxisSize(uint* pcColors)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint*, int> )(lpVtbl[12]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), pcColors);
    }

    /// <include file='IDeviceModelPlugIn.xml' path='doc/member[@name="IDeviceModelPlugIn.GetNeutralAxis"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNeutralAxis(uint cColors, XYZColorF* pXYZColors)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn*, uint, XYZColorF*, int> )(lpVtbl[13]))((IDeviceModelPlugIn*)Unsafe.AsPointer(ref this), cColors, pXYZColors);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("BSTR")] ushort* bstrXml, uint cNumModels, uint iModelPosition);
        [VtblIndex(4)]
        HRESULT GetNumChannels(uint* pNumChannels);
        [VtblIndex(5)]
        HRESULT DeviceToColorimetricColors(uint cColors, uint cChannels, [NativeTypeName("const FLOAT *")] float* pDeviceValues, XYZColorF* pXYZColors);
        [VtblIndex(6)]
        HRESULT ColorimetricToDeviceColors(uint cColors, uint cChannels, [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors, float* pDeviceValues);
        [VtblIndex(7)]
        HRESULT ColorimetricToDeviceColorsWithBlack(uint cColors, uint cChannels, [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors, [NativeTypeName("const BlackInformation *")] BlackInformation* pBlackInformation, float* pDeviceValues);
        [VtblIndex(8)]
        HRESULT SetTransformDeviceModelInfo(uint iModelPosition, IDeviceModelPlugIn* pIDeviceModelOther);
        [VtblIndex(9)]
        HRESULT GetPrimarySamples(PrimaryXYZColors* pPrimaryColor);
        [VtblIndex(10)]
        HRESULT GetGamutBoundaryMeshSize(uint* pNumVertices, uint* pNumTriangles);
        [VtblIndex(11)]
        HRESULT GetGamutBoundaryMesh(uint cChannels, uint cVertices, uint cTriangles, float* pVertices, GamutShellTriangle* pTriangles);
        [VtblIndex(12)]
        HRESULT GetNeutralAxisSize(uint* pcColors);
        [VtblIndex(13)]
        HRESULT GetNeutralAxis(uint cColors, XYZColorF* pXYZColors);
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
        [NativeTypeName("HRESULT (BSTR, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, int> Initialize;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumChannels;
        [NativeTypeName("HRESULT (UINT, UINT, const FLOAT *, XYZColorF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, float*, XYZColorF*, int> DeviceToColorimetricColors;
        [NativeTypeName("HRESULT (UINT, UINT, const XYZColorF *, FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, XYZColorF*, float*, int> ColorimetricToDeviceColors;
        [NativeTypeName("HRESULT (UINT, UINT, const XYZColorF *, const BlackInformation *, FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, XYZColorF*, BlackInformation*, float*, int> ColorimetricToDeviceColorsWithBlack;
        [NativeTypeName("HRESULT (UINT, IDeviceModelPlugIn *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDeviceModelPlugIn*, int> SetTransformDeviceModelInfo;
        [NativeTypeName("HRESULT (PrimaryXYZColors *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PrimaryXYZColors*, int> GetPrimarySamples;
        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetGamutBoundaryMeshSize;
        [NativeTypeName("HRESULT (UINT, UINT, UINT, FLOAT *, GamutShellTriangle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, float*, GamutShellTriangle*, int> GetGamutBoundaryMesh;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNeutralAxisSize;
        [NativeTypeName("HRESULT (UINT, XYZColorF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, XYZColorF*, int> GetNeutralAxis;
    }
}