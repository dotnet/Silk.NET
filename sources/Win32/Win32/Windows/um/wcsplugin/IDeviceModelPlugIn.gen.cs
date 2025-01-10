// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1CD63475-07C4-46FE-A903-D655316D11FD")]
[NativeTypeName("struct IDeviceModelPlugIn : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeviceModelPlugIn : IDeviceModelPlugIn.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceModelPlugIn));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        [NativeTypeName("BSTR")] ushort* bstrXml,
        uint cNumModels,
        uint iModelPosition
    )
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, ushort*, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            bstrXml,
            cNumModels,
            iModelPosition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNumChannels(uint* pNumChannels)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint*, int>)((*lpVtbl)[4]))(
            this,
            pNumChannels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeviceToColorimetricColors(
        uint cColors,
        uint cChannels,
        [NativeTypeName("const FLOAT *")] float* pDeviceValues,
        XYZColorF* pXYZColors
    )
    {
        return (
            (delegate* unmanaged<IDeviceModelPlugIn, uint, uint, float*, XYZColorF*, int>)(
                (*lpVtbl)[5]
            )
        )(this, cColors, cChannels, pDeviceValues, pXYZColors);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ColorimetricToDeviceColors(
        uint cColors,
        uint cChannels,
        [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors,
        float* pDeviceValues
    )
    {
        return (
            (delegate* unmanaged<IDeviceModelPlugIn, uint, uint, XYZColorF*, float*, int>)(
                (*lpVtbl)[6]
            )
        )(this, cColors, cChannels, pXYZColors, pDeviceValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ColorimetricToDeviceColorsWithBlack(
        uint cColors,
        uint cChannels,
        [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors,
        [NativeTypeName("const BlackInformation *")] BlackInformation* pBlackInformation,
        float* pDeviceValues
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceModelPlugIn,
                uint,
                uint,
                XYZColorF*,
                BlackInformation*,
                float*,
                int>)((*lpVtbl)[7])
        )(this, cColors, cChannels, pXYZColors, pBlackInformation, pDeviceValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransformDeviceModelInfo(
        uint iModelPosition,
        IDeviceModelPlugIn pIDeviceModelOther
    )
    {
        return (
            (delegate* unmanaged<IDeviceModelPlugIn, uint, IDeviceModelPlugIn, int>)((*lpVtbl)[8])
        )(this, iModelPosition, pIDeviceModelOther);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrimarySamples(PrimaryXYZColors* pPrimaryColor)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, PrimaryXYZColors*, int>)((*lpVtbl)[9]))(
            this,
            pPrimaryColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGamutBoundaryMeshSize(uint* pNumVertices, uint* pNumTriangles)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint*, uint*, int>)((*lpVtbl)[10]))(
            this,
            pNumVertices,
            pNumTriangles
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGamutBoundaryMesh(
        uint cChannels,
        uint cVertices,
        uint cTriangles,
        float* pVertices,
        GamutShellTriangle* pTriangles
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceModelPlugIn,
                uint,
                uint,
                uint,
                float*,
                GamutShellTriangle*,
                int>)((*lpVtbl)[11])
        )(this, cChannels, cVertices, cTriangles, pVertices, pTriangles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNeutralAxisSize(uint* pcColors)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint*, int>)((*lpVtbl)[12]))(
            this,
            pcColors
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNeutralAxis(uint cColors, XYZColorF* pXYZColors)
    {
        return ((delegate* unmanaged<IDeviceModelPlugIn, uint, XYZColorF*, int>)((*lpVtbl)[13]))(
            this,
            cColors,
            pXYZColors
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            [NativeTypeName("BSTR")] ushort* bstrXml,
            uint cNumModels,
            uint iModelPosition
        );

        [VtblIndex(4)]
        HRESULT GetNumChannels(uint* pNumChannels);

        [VtblIndex(5)]
        HRESULT DeviceToColorimetricColors(
            uint cColors,
            uint cChannels,
            [NativeTypeName("const FLOAT *")] float* pDeviceValues,
            XYZColorF* pXYZColors
        );

        [VtblIndex(6)]
        HRESULT ColorimetricToDeviceColors(
            uint cColors,
            uint cChannels,
            [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors,
            float* pDeviceValues
        );

        [VtblIndex(7)]
        HRESULT ColorimetricToDeviceColorsWithBlack(
            uint cColors,
            uint cChannels,
            [NativeTypeName("const XYZColorF *")] XYZColorF* pXYZColors,
            [NativeTypeName("const BlackInformation *")] BlackInformation* pBlackInformation,
            float* pDeviceValues
        );

        [VtblIndex(8)]
        HRESULT SetTransformDeviceModelInfo(
            uint iModelPosition,
            IDeviceModelPlugIn pIDeviceModelOther
        );

        [VtblIndex(9)]
        HRESULT GetPrimarySamples(PrimaryXYZColors* pPrimaryColor);

        [VtblIndex(10)]
        HRESULT GetGamutBoundaryMeshSize(uint* pNumVertices, uint* pNumTriangles);

        [VtblIndex(11)]
        HRESULT GetGamutBoundaryMesh(
            uint cChannels,
            uint cVertices,
            uint cTriangles,
            float* pVertices,
            GamutShellTriangle* pTriangles
        );

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

        [NativeTypeName(
            "HRESULT (UINT, UINT, const FLOAT *, XYZColorF *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            float*,
            XYZColorF*,
            int> DeviceToColorimetricColors;

        [NativeTypeName(
            "HRESULT (UINT, UINT, const XYZColorF *, FLOAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            XYZColorF*,
            float*,
            int> ColorimetricToDeviceColors;

        [NativeTypeName(
            "HRESULT (UINT, UINT, const XYZColorF *, const BlackInformation *, FLOAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            XYZColorF*,
            BlackInformation*,
            float*,
            int> ColorimetricToDeviceColorsWithBlack;

        [NativeTypeName("HRESULT (UINT, IDeviceModelPlugIn *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDeviceModelPlugIn,
            int> SetTransformDeviceModelInfo;

        [NativeTypeName("HRESULT (PrimaryXYZColors *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PrimaryXYZColors*, int> GetPrimarySamples;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetGamutBoundaryMeshSize;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT, FLOAT *, GamutShellTriangle *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            float*,
            GamutShellTriangle*,
            int> GetGamutBoundaryMesh;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNeutralAxisSize;

        [NativeTypeName("HRESULT (UINT, XYZColorF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, XYZColorF*, int> GetNeutralAxis;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceModelPlugIn"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceModelPlugIn(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceModelPlugIn"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceModelPlugIn(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceModelPlugIn(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceModelPlugIn"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceModelPlugIn"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceModelPlugIn value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
