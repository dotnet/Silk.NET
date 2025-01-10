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

[Guid("E6C9647E-9D6A-4C3B-B94C-524B5A6C343D")]
[NativeTypeName("struct IDxcPdbUtils : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcPdbUtils : IDxcPdbUtils.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcPdbUtils));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcPdbUtils, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob pPdbOrDxil)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcBlob, int>)((*lpVtbl)[3]))(this, pPdbOrDxil);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint*, int>)((*lpVtbl)[4]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, IDxcBlobEncoding*, int>)((*lpVtbl)[5]))(
            this,
            uIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceName(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("BSTR *")] ushort** pResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, ushort**, int>)((*lpVtbl)[6]))(
            this,
            uIndex,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint*, int>)((*lpVtbl)[7]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFlag(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("BSTR *")] ushort** pResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, ushort**, int>)((*lpVtbl)[8]))(
            this,
            uIndex,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint*, int>)((*lpVtbl)[9]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetArg(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("BSTR *")] ushort** pResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, ushort**, int>)((*lpVtbl)[10]))(
            this,
            uIndex,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint*, int>)((*lpVtbl)[11]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArgPair(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("BSTR *")] ushort** pName,
        [NativeTypeName("BSTR *")] ushort** pValue
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, ushort**, ushort**, int>)((*lpVtbl)[12]))(
            this,
            uIndex,
            pName,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint*, int>)((*lpVtbl)[13]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDefine(
        [NativeTypeName("UINT32")] uint uIndex,
        [NativeTypeName("BSTR *")] ushort** pResult
    )
    {
        return ((delegate* unmanaged<IDxcPdbUtils, uint, ushort**, int>)((*lpVtbl)[14]))(
            this,
            uIndex,
            pResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, ushort**, int>)((*lpVtbl)[15]))(this, pResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, ushort**, int>)((*lpVtbl)[16]))(this, pResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, ushort**, int>)((*lpVtbl)[17]))(this, pResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetHash(IDxcBlob* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcBlob*, int>)((*lpVtbl)[18]))(this, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, ushort**, int>)((*lpVtbl)[19]))(this, pResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsFullPDB()
    {
        return ((delegate* unmanaged<IDxcPdbUtils, int>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFullPDB(IDxcBlob* ppFullPDB)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcBlob*, int>)((*lpVtbl)[21]))(
            this,
            ppFullPDB
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVersionInfo(IDxcVersionInfo* ppVersionInfo)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcVersionInfo*, int>)((*lpVtbl)[22]))(
            this,
            ppVersionInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetCompiler(IDxcCompiler3 pCompiler)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcCompiler3, int>)((*lpVtbl)[23]))(
            this,
            pCompiler
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CompileForFullPDB(IDxcResult* ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, IDxcResult*, int>)((*lpVtbl)[24]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT OverrideArgs(DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, DxcArgPair*, uint, int>)((*lpVtbl)[25]))(
            this,
            pArgPairs,
            uNumArgPairs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT OverrideRootSignature([NativeTypeName("const WCHAR *")] ushort* pRootSignature)
    {
        return ((delegate* unmanaged<IDxcPdbUtils, ushort*, int>)((*lpVtbl)[26]))(
            this,
            pRootSignature
        );
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
            [NativeTypeName("BSTR *")] ushort** pResult
        );

        [VtblIndex(7)]
        HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(8)]
        HRESULT GetFlag(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("BSTR *")] ushort** pResult
        );

        [VtblIndex(9)]
        HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(10)]
        HRESULT GetArg(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("BSTR *")] ushort** pResult
        );

        [VtblIndex(11)]
        HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(12)]
        HRESULT GetArgPair(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("BSTR *")] ushort** pName,
            [NativeTypeName("BSTR *")] ushort** pValue
        );

        [VtblIndex(13)]
        HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(14)]
        HRESULT GetDefine(
            [NativeTypeName("UINT32")] uint uIndex,
            [NativeTypeName("BSTR *")] ushort** pResult
        );

        [VtblIndex(15)]
        HRESULT GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult);

        [VtblIndex(16)]
        HRESULT GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult);

        [VtblIndex(17)]
        HRESULT GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult);

        [VtblIndex(18)]
        HRESULT GetHash(IDxcBlob* ppResult);

        [VtblIndex(19)]
        HRESULT GetName([NativeTypeName("BSTR *")] ushort** pResult);

        [VtblIndex(20)]
        BOOL IsFullPDB();

        [VtblIndex(21)]
        HRESULT GetFullPDB(IDxcBlob* ppFullPDB);

        [VtblIndex(22)]
        HRESULT GetVersionInfo(IDxcVersionInfo* ppVersionInfo);

        [VtblIndex(23)]
        HRESULT SetCompiler(IDxcCompiler3 pCompiler);

        [VtblIndex(24)]
        HRESULT CompileForFullPDB(IDxcResult* ppResult);

        [VtblIndex(25)]
        HRESULT OverrideArgs(DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs);

        [VtblIndex(26)]
        HRESULT OverrideRootSignature([NativeTypeName("const WCHAR *")] ushort* pRootSignature);
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

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetSourceName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlagCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetFlag;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetArgCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetArg;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetArgPairCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, ushort**, int> GetArgPair;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDefineCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetDefine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTargetProfile;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEntryPoint;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMainFileName;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetHash;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsFullPDB;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> GetFullPDB;

        [NativeTypeName("HRESULT (IDxcVersionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcVersionInfo*, int> GetVersionInfo;

        [NativeTypeName("HRESULT (IDxcCompiler3 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcCompiler3, int> SetCompiler;

        [NativeTypeName("HRESULT (IDxcResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcResult*, int> CompileForFullPDB;

        [NativeTypeName("HRESULT (DxcArgPair *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DxcArgPair*, uint, int> OverrideArgs;

        [NativeTypeName("HRESULT (const WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OverrideRootSignature;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcPdbUtils"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcPdbUtils(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcPdbUtils"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcPdbUtils(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcPdbUtils(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcPdbUtils"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcPdbUtils"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcPdbUtils value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
