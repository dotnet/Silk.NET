// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2"]/*'/>
[Guid("0002040E-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICreateTypeInfo2 : ICreateTypeInfo")]
[NativeInheritance("ICreateTypeInfo")]
public unsafe partial struct ICreateTypeInfo2 : ICreateTypeInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateTypeInfo2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, void**, int> )(lpVtbl[0]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint> )(lpVtbl[1]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint> )(lpVtbl[2]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetGuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, int> )(lpVtbl[3]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetTypeFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTypeFlags(uint uTypeFlags)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[4]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), uTypeFlags);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetDocString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int> )(lpVtbl[5]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrDoc);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetHelpContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[6]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpContext);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ushort, ushort, int> )(lpVtbl[7]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.AddRefTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ITypeInfo*, uint*, int> )(lpVtbl[8]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.AddFuncDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddFuncDesc(uint index, FUNCDESC* pFuncDesc)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, FUNCDESC*, int> )(lpVtbl[9]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pFuncDesc);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.AddImplType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddImplType(uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int> )(lpVtbl[10]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, hRefType);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetImplTypeFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetImplTypeFlags(uint index, int implTypeFlags)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int, int> )(lpVtbl[11]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, implTypeFlags);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ushort, int> )(lpVtbl[12]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), cbAlignment);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetSchema"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int> )(lpVtbl[13]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrSchema);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.AddVarDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddVarDesc(uint index, VARDESC* pVarDesc)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, VARDESC*, int> )(lpVtbl[14]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pVarDesc);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetFuncAndParamNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFuncAndParamNames(uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort**, uint, int> )(lpVtbl[15]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetVarName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetVarName(uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int> )(lpVtbl[16]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szName);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetTypeDescAlias"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTypeDescAlias(TYPEDESC* pTDescAlias)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, TYPEDESC*, int> )(lpVtbl[17]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTDescAlias);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.DefineFuncAsDllEntry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DefineFuncAsDllEntry(uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, ushort*, int> )(lpVtbl[18]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetFuncDocString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFuncDocString(uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int> )(lpVtbl[19]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetVarDocString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetVarDocString(uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int> )(lpVtbl[20]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetFuncHelpContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetFuncHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int> )(lpVtbl[21]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetVarHelpContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetVarHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int> )(lpVtbl[22]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetMops"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetMops(uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int> )(lpVtbl[23]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, bstrMops);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.SetTypeIdldesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTypeIdldesc(IDLDESC* pIdlDesc)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, IDLDESC*, int> )(lpVtbl[24]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pIdlDesc);
    }

    /// <inheritdoc cref = "ICreateTypeInfo.LayOut"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT LayOut()
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, int> )(lpVtbl[25]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.DeleteFuncDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT DeleteFuncDesc(uint index)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[26]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.DeleteFuncDescByMemId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, int, INVOKEKIND, int> )(lpVtbl[27]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.DeleteVarDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DeleteVarDesc(uint index)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[28]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.DeleteVarDescByMemId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, int, int> )(lpVtbl[29]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.DeleteImplType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DeleteImplType(uint index)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[30]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, VARIANT*, int> )(lpVtbl[31]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetFuncCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetFuncCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> )(lpVtbl[32]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetParamCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetParamCustData(uint indexFunc, uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, Guid*, VARIANT*, int> )(lpVtbl[33]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetVarCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetVarCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> )(lpVtbl[34]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetImplTypeCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetImplTypeCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> )(lpVtbl[35]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetHelpStringContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int> )(lpVtbl[36]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetFuncHelpStringContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetFuncHelpStringContext(uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int> )(lpVtbl[37]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetVarHelpStringContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetVarHelpStringContext(uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int> )(lpVtbl[38]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.Invalidate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT Invalidate()
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, int> )(lpVtbl[39]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateTypeInfo2.xml' path='doc/member[@name="ICreateTypeInfo2.SetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName)
    {
        return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int> )(lpVtbl[40]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), szName);
    }

    public interface Interface : ICreateTypeInfo.Interface
    {
        [VtblIndex(26)]
        HRESULT DeleteFuncDesc(uint index);
        [VtblIndex(27)]
        HRESULT DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind);
        [VtblIndex(28)]
        HRESULT DeleteVarDesc(uint index);
        [VtblIndex(29)]
        HRESULT DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid);
        [VtblIndex(30)]
        HRESULT DeleteImplType(uint index);
        [VtblIndex(31)]
        HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(32)]
        HRESULT SetFuncCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(33)]
        HRESULT SetParamCustData(uint indexFunc, uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(34)]
        HRESULT SetVarCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(35)]
        HRESULT SetImplTypeCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(36)]
        HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext);
        [VtblIndex(37)]
        HRESULT SetFuncHelpStringContext(uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext);
        [VtblIndex(38)]
        HRESULT SetVarHelpStringContext(uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext);
        [VtblIndex(39)]
        HRESULT Invalidate();
        [VtblIndex(40)]
        HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName);
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
        public delegate* unmanaged<TSelf*, Guid*, int> SetGuid;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetTypeFlags;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDocString;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpContext;
        [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, ushort, int> SetVersion;
        [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeInfo*, uint*, int> AddRefTypeInfo;
        [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, FUNCDESC*, int> AddFuncDesc;
        [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> AddImplType;
        [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int> SetImplTypeFlags;
        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetAlignment;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSchema;
        [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, VARDESC*, int> AddVarDesc;
        [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, uint, int> SetFuncAndParamNames;
        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetVarName;
        [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TYPEDESC*, int> SetTypeDescAlias;
        [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, int> DefineFuncAsDllEntry;
        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetFuncDocString;
        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetVarDocString;
        [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetFuncHelpContext;
        [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetVarHelpContext;
        [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetMops;
        [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDLDESC*, int> SetTypeIdldesc;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LayOut;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeleteFuncDesc;
        [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, INVOKEKIND, int> DeleteFuncDescByMemId;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeleteVarDesc;
        [NativeTypeName("HRESULT (MEMBERID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> DeleteVarDescByMemId;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeleteImplType;
        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> SetCustData;
        [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, VARIANT*, int> SetFuncCustData;
        [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, VARIANT*, int> SetParamCustData;
        [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, VARIANT*, int> SetVarCustData;
        [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, VARIANT*, int> SetImplTypeCustData;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpStringContext;
        [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetFuncHelpStringContext;
        [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetVarHelpStringContext;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Invalidate;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
    }
}