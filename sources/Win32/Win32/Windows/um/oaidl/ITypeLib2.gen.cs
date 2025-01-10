// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00020411-0000-0000-C000-000000000046")]
[NativeTypeName("struct ITypeLib2 : ITypeLib")]
[NativeInheritance("ITypeLib")]
public unsafe partial struct ITypeLib2 : ITypeLib2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeLib2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeLib2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITypeLib2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeLib2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetTypeInfoCount()
    {
        return ((delegate* unmanaged<ITypeLib2, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint index, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<ITypeLib2, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            index,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTypeInfoType(uint index, TYPEKIND* pTKind)
    {
        return ((delegate* unmanaged<ITypeLib2, uint, TYPEKIND*, int>)((*lpVtbl)[5]))(
            this,
            index,
            pTKind
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTypeInfoOfGuid(
        [NativeTypeName("const GUID &")] Guid* guid,
        ITypeInfo* ppTinfo
    )
    {
        return ((delegate* unmanaged<ITypeLib2, Guid*, ITypeInfo*, int>)((*lpVtbl)[6]))(
            this,
            guid,
            ppTinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLibAttr(TLIBATTR** ppTLibAttr)
    {
        return ((delegate* unmanaged<ITypeLib2, TLIBATTR**, int>)((*lpVtbl)[7]))(this, ppTLibAttr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTypeComp(ITypeComp* ppTComp)
    {
        return ((delegate* unmanaged<ITypeLib2, ITypeComp*, int>)((*lpVtbl)[8]))(this, ppTComp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDocumentation(
        int index,
        [NativeTypeName("BSTR *")] ushort** pBstrName,
        [NativeTypeName("BSTR *")] ushort** pBstrDocString,
        [NativeTypeName("DWORD *")] uint* pdwHelpContext,
        [NativeTypeName("BSTR *")] ushort** pBstrHelpFile
    )
    {
        return (
            (delegate* unmanaged<ITypeLib2, int, ushort**, ushort**, uint*, ushort**, int>)(
                (*lpVtbl)[9]
            )
        )(this, index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsName(
        [NativeTypeName("LPOLESTR")] ushort* szNameBuf,
        [NativeTypeName("ULONG")] uint lHashVal,
        BOOL* pfName
    )
    {
        return ((delegate* unmanaged<ITypeLib2, ushort*, uint, BOOL*, int>)((*lpVtbl)[10]))(
            this,
            szNameBuf,
            lHashVal,
            pfName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindName(
        [NativeTypeName("LPOLESTR")] ushort* szNameBuf,
        [NativeTypeName("ULONG")] uint lHashVal,
        ITypeInfo* ppTInfo,
        [NativeTypeName("MEMBERID *")] int* rgMemId,
        ushort* pcFound
    )
    {
        return (
            (delegate* unmanaged<ITypeLib2, ushort*, uint, ITypeInfo*, int*, ushort*, int>)(
                (*lpVtbl)[11]
            )
        )(this, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseTLibAttr(TLIBATTR* pTLibAttr)
    {
        ((delegate* unmanaged<ITypeLib2, TLIBATTR*, void>)((*lpVtbl)[12]))(this, pTLibAttr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ITypeLib2, Guid*, VARIANT*, int>)((*lpVtbl)[13]))(
            this,
            guid,
            pVarVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetLibStatistics(
        [NativeTypeName("ULONG *")] uint* pcUniqueNames,
        [NativeTypeName("ULONG *")] uint* pcchUniqueNames
    )
    {
        return ((delegate* unmanaged<ITypeLib2, uint*, uint*, int>)((*lpVtbl)[14]))(
            this,
            pcUniqueNames,
            pcchUniqueNames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDocumentation2(
        int index,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("BSTR *")] ushort** pbstrHelpString,
        [NativeTypeName("DWORD *")] uint* pdwHelpStringContext,
        [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll
    )
    {
        return (
            (delegate* unmanaged<ITypeLib2, int, uint, ushort**, uint*, ushort**, int>)(
                (*lpVtbl)[15]
            )
        )(this, index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllCustData(CUSTDATA* pCustData)
    {
        return ((delegate* unmanaged<ITypeLib2, CUSTDATA*, int>)((*lpVtbl)[16]))(this, pCustData);
    }

    public interface Interface : ITypeLib.Interface
    {
        [VtblIndex(13)]
        HRESULT GetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);

        [VtblIndex(14)]
        HRESULT GetLibStatistics(
            [NativeTypeName("ULONG *")] uint* pcUniqueNames,
            [NativeTypeName("ULONG *")] uint* pcchUniqueNames
        );

        [VtblIndex(15)]
        HRESULT GetDocumentation2(
            int index,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("BSTR *")] ushort** pbstrHelpString,
            [NativeTypeName("DWORD *")] uint* pdwHelpStringContext,
            [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll
        );

        [VtblIndex(16)]
        HRESULT GetAllCustData(CUSTDATA* pCustData);
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName("HRESULT (UINT, TYPEKIND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TYPEKIND*, int> GetTypeInfoType;

        [NativeTypeName("HRESULT (const GUID &, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITypeInfo*, int> GetTypeInfoOfGuid;

        [NativeTypeName("HRESULT (TLIBATTR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TLIBATTR**, int> GetLibAttr;

        [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeComp*, int> GetTypeComp;

        [NativeTypeName("HRESULT (INT, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            int,
            ushort**,
            ushort**,
            uint*,
            ushort**,
            int> GetDocumentation;

        [NativeTypeName("HRESULT (LPOLESTR, ULONG, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL*, int> IsName;

        [NativeTypeName(
            "HRESULT (LPOLESTR, ULONG, ITypeInfo **, MEMBERID *, USHORT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, ITypeInfo*, int*, ushort*, int> FindName;

        [NativeTypeName("void (TLIBATTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TLIBATTR*, void> ReleaseTLibAttr;

        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> GetCustData;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetLibStatistics;

        [NativeTypeName("HRESULT (INT, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            int,
            uint,
            ushort**,
            uint*,
            ushort**,
            int> GetDocumentation2;

        [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CUSTDATA*, int> GetAllCustData;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITypeLib2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITypeLib2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITypeLib"/> to <see cref = "ITypeLib2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITypeLib"/> instance to be converted </param>
    public static explicit operator ITypeLib2(Silk.NET.Windows.ITypeLib value)
    {
        return new ITypeLib2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITypeLib2"/> to <see cref = "Silk.NET.Windows.ITypeLib"/>.</summary>
    /// <param name = "value">The <see cref = "ITypeLib2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITypeLib(ITypeLib2 value)
    {
        return new Silk.NET.Windows.ITypeLib(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITypeLib2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITypeLib2(Silk.NET.Windows.IUnknown value)
    {
        return new ITypeLib2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITypeLib2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITypeLib2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITypeLib2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
