// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils"]/*'/>
[Guid("E6C9647E-9D6A-4C3B-B94C-524B5A6C343D")]
[NativeTypeName("struct IDxcPdbUtils : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcPdbUtils : IDxcPdbUtils.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcPdbUtils));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, Guid*, void**, int> )(lpVtbl[0]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint> )(lpVtbl[1]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint> )(lpVtbl[2]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.Load"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pPdbOrDxil)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob*, int> )(lpVtbl[3]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pPdbOrDxil);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint*, int> )(lpVtbl[4]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int> )(lpVtbl[5]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, ushort**, int> )(lpVtbl[6]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlagCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint*, int> )(lpVtbl[7]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, ushort**, int> )(lpVtbl[8]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint*, int> )(lpVtbl[9]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArg"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, ushort**, int> )(lpVtbl[10]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPairCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint*, int> )(lpVtbl[11]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPair"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pName, [NativeTypeName("BSTR *")] ushort** pValue)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, ushort**, ushort**, int> )(lpVtbl[12]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pName, pValue);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefineCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint*, int> )(lpVtbl[13]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, uint, ushort**, int> )(lpVtbl[14]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetTargetProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, ushort**, int> )(lpVtbl[15]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetEntryPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, ushort**, int> )(lpVtbl[16]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetMainFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, ushort**, int> )(lpVtbl[17]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetHash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetHash(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int> )(lpVtbl[18]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, ushort**, int> )(lpVtbl[19]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.IsFullPDB"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsFullPDB()
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, int> )(lpVtbl[20]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFullPDB"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFullPDB(IDxcBlob** ppFullPDB)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int> )(lpVtbl[21]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppFullPDB);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetVersionInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcVersionInfo**, int> )(lpVtbl[22]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppVersionInfo);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.SetCompiler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetCompiler(IDxcCompiler3* pCompiler)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcCompiler3*, int> )(lpVtbl[23]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCompiler);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.CompileForFullPDB"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CompileForFullPDB(IDxcResult** ppResult)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, IDxcResult**, int> )(lpVtbl[24]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideArgs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT OverrideArgs(DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, DxcArgPair*, uint, int> )(lpVtbl[25]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pArgPairs, uNumArgPairs);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT OverrideRootSignature([NativeTypeName("const WCHAR *")] ushort* pRootSignature)
    {
        return ((delegate* unmanaged<IDxcPdbUtils*, ushort*, int> )(lpVtbl[26]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pRootSignature);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IDxcBlob* pPdbOrDxil);
        [VtblIndex(4)]
        HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount);
        [VtblIndex(5)]
        HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult);
        [VtblIndex(6)]
        HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(7)]
        HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount);
        [VtblIndex(8)]
        HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(9)]
        HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount);
        [VtblIndex(10)]
        HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(11)]
        HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount);
        [VtblIndex(12)]
        HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pName, [NativeTypeName("BSTR *")] ushort** pValue);
        [VtblIndex(13)]
        HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount);
        [VtblIndex(14)]
        HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(15)]
        HRESULT GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(16)]
        HRESULT GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(17)]
        HRESULT GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(18)]
        HRESULT GetHash(IDxcBlob** ppResult);
        [VtblIndex(19)]
        HRESULT GetName([NativeTypeName("BSTR *")] ushort** pResult);
        [VtblIndex(20)]
        BOOL IsFullPDB();
        [VtblIndex(21)]
        HRESULT GetFullPDB(IDxcBlob** ppFullPDB);
        [VtblIndex(22)]
        HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo);
        [VtblIndex(23)]
        HRESULT SetCompiler(IDxcCompiler3* pCompiler);
        [VtblIndex(24)]
        HRESULT CompileForFullPDB(IDxcResult** ppResult);
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
        public delegate* unmanaged<TSelf*, IDxcBlob*, int> Load;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSourceCount;
        [NativeTypeName("HRESULT (UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDxcBlobEncoding**, int> GetSource;
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
        public delegate* unmanaged<TSelf*, IDxcBlob**, int> GetHash;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsFullPDB;
        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob**, int> GetFullPDB;
        [NativeTypeName("HRESULT (IDxcVersionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcVersionInfo**, int> GetVersionInfo;
        [NativeTypeName("HRESULT (IDxcCompiler3 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcCompiler3*, int> SetCompiler;
        [NativeTypeName("HRESULT (IDxcResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcResult**, int> CompileForFullPDB;
        [NativeTypeName("HRESULT (DxcArgPair *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DxcArgPair*, uint, int> OverrideArgs;
        [NativeTypeName("HRESULT (const WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OverrideRootSignature;
    }
}