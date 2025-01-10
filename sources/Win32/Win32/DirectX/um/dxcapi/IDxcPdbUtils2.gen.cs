// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("4315D938-F369-4F93-95A2-252017CC3807")]
[NativeTypeName("struct IDxcPdbUtils2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcPdbUtils2 : IDxcPdbUtils2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcPdbUtils2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcPdbUtils2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob pPdbOrDxil)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlob, int>)((*lpVtbl)[3]))(
            this,
            pPdbOrDxil
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[4]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobEncoding*, int>)((*lpVtbl)[5]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceName(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobUtf16*, int>)((*lpVtbl)[6]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLibraryPDBCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[7]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLibraryPDB(
        [NativeTypeName("UINT32")] uint uIndex,
        IDxcPdbUtils2* ppOutPdbUtils,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppLibraryName
    )
    {
        return (
            (delegate* unmanaged<IDxcPdbUtils2, uint, IDxcPdbUtils2*, IDxcBlobUtf16*, int>)(
                (*lpVtbl)[8]
            )
        )(this, uIndex, ppOutPdbUtils, ppLibraryName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[9]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFlag(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobUtf16*, int>)((*lpVtbl)[10]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[11]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArg(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobUtf16*, int>)((*lpVtbl)[12]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[13]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetArgPair(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppName,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppValue
    )
    {
        return (
            (delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobUtf16*, IDxcBlobUtf16*, int>)(
                (*lpVtbl)[14]
            )
        )(this, uIndex, ppName, ppValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[15]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDefine(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint, IDxcBlobUtf16*, int>)((*lpVtbl)[16]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTargetProfile([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlobUtf16*, int>)((*lpVtbl)[17]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetEntryPoint([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlobUtf16*, int>)((*lpVtbl)[18]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMainFileName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlobUtf16*, int>)((*lpVtbl)[19]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetHash(IDxcBlob* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlob*, int>)((*lpVtbl)[20]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlobUtf16*, int>)((*lpVtbl)[21]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVersionInfo(IDxcVersionInfo* ppVersionInfo)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcVersionInfo*, int>)((*lpVtbl)[22]))(
            this,
            ppVersionInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetCustomToolchainID([NativeTypeName("UINT32 *")] uint* pID)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, uint*, int>)((*lpVtbl)[23]))(this, pID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetCustomToolchainData(IDxcBlob* ppBlob)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlob*, int>)((*lpVtbl)[24]))(this, ppBlob);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetWholeDxil(IDxcBlob* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, IDxcBlob*, int>)((*lpVtbl)[25]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL IsFullPDB()
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public BOOL IsPDBRef()
    {
        return ((delegate* unmanaged<IDxcPdbUtils2, int>)((*lpVtbl)[27]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IDxcBlob pPdbOrDxil);

        [VtblIndex(4)]
        HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(5)]
        HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding* ppResult);

        [VtblIndex(6)]
        HRESULT GetSourceName(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
        );

        [VtblIndex(7)]
        HRESULT GetLibraryPDBCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(8)]
        HRESULT GetLibraryPDB(
            [NativeTypeName("UINT32")] uint uIndex,
            IDxcPdbUtils2* ppOutPdbUtils,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppLibraryName
        );

        [VtblIndex(9)]
        HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(10)]
        HRESULT GetFlag(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
        );

        [VtblIndex(11)]
        HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(12)]
        HRESULT GetArg(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
        );

        [VtblIndex(13)]
        HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(14)]
        HRESULT GetArgPair(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppName,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppValue
        );

        [VtblIndex(15)]
        HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(16)]
        HRESULT GetDefine(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult
        );

        [VtblIndex(17)]
        HRESULT GetTargetProfile([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult);

        [VtblIndex(18)]
        HRESULT GetEntryPoint([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult);

        [VtblIndex(19)]
        HRESULT GetMainFileName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult);

        [VtblIndex(20)]
        HRESULT GetHash(IDxcBlob* ppResult);

        [VtblIndex(21)]
        HRESULT GetName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16* ppResult);

        [VtblIndex(22)]
        HRESULT GetVersionInfo(IDxcVersionInfo* ppVersionInfo);

        [VtblIndex(23)]
        HRESULT GetCustomToolchainID([NativeTypeName("UINT32 *")] uint* pID);

        [VtblIndex(24)]
        HRESULT GetCustomToolchainData(IDxcBlob* ppBlob);

        [VtblIndex(25)]
        HRESULT GetWholeDxil(IDxcBlob* ppResult);

        [VtblIndex(26)]
        BOOL IsFullPDB();

        [VtblIndex(27)]
        BOOL IsPDBRef();
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

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, int> Load;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSourceCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobEncoding*, int> GetSource;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobUtf16*, int> GetSourceName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLibraryPDBCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDxcPdbUtils2 **, IDxcBlobWide **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDxcPdbUtils2*, IDxcBlobUtf16*, int> GetLibraryPDB;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlagCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobUtf16*, int> GetFlag;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetArgCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobUtf16*, int> GetArg;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetArgPairCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDxcBlobWide **, IDxcBlobWide **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobUtf16*, IDxcBlobUtf16*, int> GetArgPair;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDefineCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobUtf16*, int> GetDefine;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobUtf16*, int> GetTargetProfile;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobUtf16*, int> GetEntryPoint;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobUtf16*, int> GetMainFileName;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetHash;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobUtf16*, int> GetName;

        [NativeTypeName("HRESULT (IDxcVersionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcVersionInfo*, int> GetVersionInfo;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCustomToolchainID;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetCustomToolchainData;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetWholeDxil;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsFullPDB;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPDBRef;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcPdbUtils2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcPdbUtils2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcPdbUtils2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcPdbUtils2(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcPdbUtils2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcPdbUtils2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcPdbUtils2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcPdbUtils2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
