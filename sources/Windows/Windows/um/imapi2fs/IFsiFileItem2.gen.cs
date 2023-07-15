// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2"]/*'/>
[Guid("199D0C19-11E1-40EB-8EC2-C8C822A07792")]
[NativeTypeName("struct IFsiFileItem2 : IFsiFileItem")]
[NativeInheritance("IFsiFileItem")]
public unsafe partial struct IFsiFileItem2 : IFsiFileItem2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFsiFileItem2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, Guid*, void**, int> )(lpVtbl[0]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFsiFileItem2*, uint> )(lpVtbl[1]))((IFsiFileItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFsiFileItem2*, uint> )(lpVtbl[2]))((IFsiFileItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, uint*, int> )(lpVtbl[3]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IFsiItem.get_Name"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, ushort**, int> )(lpVtbl[7]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_FullPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, ushort**, int> )(lpVtbl[8]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_CreationTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CreationTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double*, int> )(lpVtbl[9]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_CreationTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CreationTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double, int> )(lpVtbl[10]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_LastAccessedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double*, int> )(lpVtbl[11]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_LastAccessedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double, int> )(lpVtbl[12]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_LastModifiedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double*, int> )(lpVtbl[13]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_LastModifiedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, double, int> )(lpVtbl[14]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_IsHidden"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, short*, int> )(lpVtbl[15]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_IsHidden"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, short, int> )(lpVtbl[16]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.FileSystemName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, FsiFileSystems, ushort**, int> )(lpVtbl[17]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <inheritdoc cref = "IFsiItem.FileSystemPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, FsiFileSystems, ushort**, int> )(lpVtbl[18]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <inheritdoc cref = "IFsiFileItem.get_DataSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DataSize([NativeTypeName("LONGLONG *")] long* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, long*, int> )(lpVtbl[19]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiFileItem.get_DataSize32BitLow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DataSize32BitLow([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, int*, int> )(lpVtbl[20]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiFileItem.get_DataSize32BitHigh"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DataSize32BitHigh([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, int*, int> )(lpVtbl[21]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiFileItem.get_Data"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Data(IStream** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, IStream**, int> )(lpVtbl[22]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiFileItem.put_Data"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Data(IStream* newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, IStream*, int> )(lpVtbl[23]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.get_FsiNamedStreams"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_FsiNamedStreams(IFsiNamedStreams** streams)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, IFsiNamedStreams**, int> )(lpVtbl[24]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), streams);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.get_IsNamedStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IsNamedStream([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, short*, int> )(lpVtbl[25]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.AddStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT AddStream([NativeTypeName("BSTR")] ushort* name, IStream* streamData)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, ushort*, IStream*, int> )(lpVtbl[26]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), name, streamData);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.RemoveStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT RemoveStream([NativeTypeName("BSTR")] ushort* name)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, ushort*, int> )(lpVtbl[27]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.get_IsRealTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_IsRealTime([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, short*, int> )(lpVtbl[28]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem2.xml' path='doc/member[@name="IFsiFileItem2.put_IsRealTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_IsRealTime([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem2*, short, int> )(lpVtbl[29]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    public interface Interface : IFsiFileItem.Interface
    {
        [VtblIndex(24)]
        HRESULT get_FsiNamedStreams(IFsiNamedStreams** streams);
        [VtblIndex(25)]
        HRESULT get_IsNamedStream([NativeTypeName("VARIANT_BOOL *")] short* pVal);
        [VtblIndex(26)]
        HRESULT AddStream([NativeTypeName("BSTR")] ushort* name, IStream* streamData);
        [VtblIndex(27)]
        HRESULT RemoveStream([NativeTypeName("BSTR")] ushort* name);
        [VtblIndex(28)]
        HRESULT get_IsRealTime([NativeTypeName("VARIANT_BOOL *")] short* pVal);
        [VtblIndex(29)]
        HRESULT put_IsRealTime([NativeTypeName("VARIANT_BOOL")] short newVal);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FullPath;
        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_CreationTime;
        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_CreationTime;
        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastAccessedTime;
        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastAccessedTime;
        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastModifiedTime;
        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastModifiedTime;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsHidden;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_IsHidden;
        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemName;
        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemPath;
        [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> get_DataSize;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataSize32BitLow;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataSize32BitHigh;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> get_Data;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> put_Data;
        [NativeTypeName("HRESULT (IFsiNamedStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFsiNamedStreams**, int> get_FsiNamedStreams;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsNamedStream;
        [NativeTypeName("HRESULT (BSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, int> AddStream;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveStream;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsRealTime;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_IsRealTime;
    }
}