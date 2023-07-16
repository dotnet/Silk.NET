// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess"]/*'/>
[Guid("49353C9A-516B-11D1-AEA6-00C04FB68820")]
[NativeTypeName("struct IWbemObjectAccess : IWbemClassObject")]
[NativeInheritance("IWbemClassObject")]
public unsafe partial struct IWbemObjectAccess : IWbemObjectAccess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemObjectAccess));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, Guid*, void**, int> )(lpVtbl[0]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, uint> )(lpVtbl[1]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, uint> )(lpVtbl[2]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWbemClassObject.GetQualifierSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetQualifierSet(IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, IWbemQualifierSet**, int> )(lpVtbl[3]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), ppQualSet);
    }

    /// <inheritdoc cref = "IWbemClassObject.Get"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int, VARIANT*, int*, int*, int> )(lpVtbl[4]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, pType, plFlavor);
    }

    /// <inheritdoc cref = "IWbemClassObject.Put"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Put([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("CIMTYPE")] int Type)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int, VARIANT*, int, int> )(lpVtbl[5]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, Type);
    }

    /// <inheritdoc cref = "IWbemClassObject.Delete"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Delete([NativeTypeName("LPCWSTR")] ushort* wszName)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int> )(lpVtbl[6]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName);
    }

    /// <inheritdoc cref = "IWbemClassObject.GetNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNames([NativeTypeName("LPCWSTR")] ushort* wszQualifierName, [NativeTypeName("long")] int lFlags, VARIANT* pQualifierVal, SAFEARRAY** pNames)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int, VARIANT*, SAFEARRAY**, int> )(lpVtbl[7]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszQualifierName, lFlags, pQualifierVal, pNames);
    }

    /// <inheritdoc cref = "IWbemClassObject.BeginEnumeration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeginEnumeration([NativeTypeName("long")] int lEnumFlags)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int> )(lpVtbl[8]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lEnumFlags);
    }

    /// <inheritdoc cref = "IWbemClassObject.Next"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** strName, VARIANT* pVal, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plFlavor)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ushort**, VARIANT*, int*, int*, int> )(lpVtbl[9]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, strName, pVal, pType, plFlavor);
    }

    /// <inheritdoc cref = "IWbemClassObject.EndEnumeration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EndEnumeration()
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int> )(lpVtbl[10]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWbemClassObject.GetPropertyQualifierSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPropertyQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszProperty, IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, IWbemQualifierSet**, int> )(lpVtbl[11]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszProperty, ppQualSet);
    }

    /// <inheritdoc cref = "IWbemClassObject.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clone(IWbemClassObject** ppCopy)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, IWbemClassObject**, int> )(lpVtbl[12]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), ppCopy);
    }

    /// <inheritdoc cref = "IWbemClassObject.GetObjectText"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetObjectText([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrObjectText)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ushort**, int> )(lpVtbl[13]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, pstrObjectText);
    }

    /// <inheritdoc cref = "IWbemClassObject.SpawnDerivedClass"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SpawnDerivedClass([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewClass)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, IWbemClassObject**, int> )(lpVtbl[14]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, ppNewClass);
    }

    /// <inheritdoc cref = "IWbemClassObject.SpawnInstance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SpawnInstance([NativeTypeName("long")] int lFlags, IWbemClassObject** ppNewInstance)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, IWbemClassObject**, int> )(lpVtbl[15]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, ppNewInstance);
    }

    /// <inheritdoc cref = "IWbemClassObject.CompareTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CompareTo([NativeTypeName("long")] int lFlags, IWbemClassObject* pCompareTo)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, IWbemClassObject*, int> )(lpVtbl[16]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, pCompareTo);
    }

    /// <inheritdoc cref = "IWbemClassObject.GetPropertyOrigin"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPropertyOrigin([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, ushort**, int> )(lpVtbl[17]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName, pstrClassName);
    }

    /// <inheritdoc cref = "IWbemClassObject.InheritsFrom"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT InheritsFrom([NativeTypeName("LPCWSTR")] ushort* strAncestor)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int> )(lpVtbl[18]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), strAncestor);
    }

    /// <inheritdoc cref = "IWbemClassObject.GetMethod"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int, IWbemClassObject**, IWbemClassObject**, int> )(lpVtbl[19]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName, lFlags, ppInSignature, ppOutSignature);
    }

    /// <inheritdoc cref = "IWbemClassObject.PutMethod"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT PutMethod([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, IWbemClassObject* pInSignature, IWbemClassObject* pOutSignature)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int, IWbemClassObject*, IWbemClassObject*, int> )(lpVtbl[20]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName, lFlags, pInSignature, pOutSignature);
    }

    /// <inheritdoc cref = "IWbemClassObject.DeleteMethod"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DeleteMethod([NativeTypeName("LPCWSTR")] ushort* wszName)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int> )(lpVtbl[21]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszName);
    }

    /// <inheritdoc cref = "IWbemClassObject.BeginMethodEnumeration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT BeginMethodEnumeration([NativeTypeName("long")] int lEnumFlags)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int> )(lpVtbl[22]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lEnumFlags);
    }

    /// <inheritdoc cref = "IWbemClassObject.NextMethod"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT NextMethod([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, IWbemClassObject** ppInSignature, IWbemClassObject** ppOutSignature)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ushort**, IWbemClassObject**, IWbemClassObject**, int> )(lpVtbl[23]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags, pstrName, ppInSignature, ppOutSignature);
    }

    /// <inheritdoc cref = "IWbemClassObject.EndMethodEnumeration"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT EndMethodEnumeration()
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int> )(lpVtbl[24]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWbemClassObject.GetMethodQualifierSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMethodQualifierSet([NativeTypeName("LPCWSTR")] ushort* wszMethod, IWbemQualifierSet** ppQualSet)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, IWbemQualifierSet**, int> )(lpVtbl[25]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszMethod, ppQualSet);
    }

    /// <inheritdoc cref = "IWbemClassObject.GetMethodOrigin"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMethodOrigin([NativeTypeName("LPCWSTR")] ushort* wszMethodName, [NativeTypeName("BSTR *")] ushort** pstrClassName)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, ushort**, int> )(lpVtbl[26]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszMethodName, pstrClassName);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.GetPropertyHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetPropertyHandle([NativeTypeName("LPCWSTR")] ushort* wszPropertyName, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plHandle)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, ushort*, int*, int*, int> )(lpVtbl[27]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), wszPropertyName, pType, plHandle);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.WritePropertyValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WritePropertyValue([NativeTypeName("long")] int lHandle, [NativeTypeName("long")] int lNumBytes, [NativeTypeName("const byte *")] byte* aData)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int, byte*, int> )(lpVtbl[28]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, lNumBytes, aData);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.ReadPropertyValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT ReadPropertyValue([NativeTypeName("long")] int lHandle, [NativeTypeName("long")] int lBufferSize, [NativeTypeName("long *")] int* plNumBytes, byte* aData)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int, int*, byte*, int> )(lpVtbl[29]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, lBufferSize, plNumBytes, aData);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.ReadDWORD"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT ReadDWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("DWORD *")] uint* pdw)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, uint*, int> )(lpVtbl[30]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, pdw);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.WriteDWORD"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT WriteDWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("DWORD")] uint dw)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, uint, int> )(lpVtbl[31]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, dw);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.ReadQWORD"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT ReadQWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("unsigned long long *")] ulong* pqw)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ulong*, int> )(lpVtbl[32]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, pqw);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.WriteQWORD"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT WriteQWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("unsigned long long")] ulong pw)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ulong, int> )(lpVtbl[33]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, pw);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.GetPropertyInfoByHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetPropertyInfoByHandle([NativeTypeName("long")] int lHandle, [NativeTypeName("BSTR *")] ushort** pstrName, [NativeTypeName("CIMTYPE *")] int* pType)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, ushort**, int*, int> )(lpVtbl[34]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lHandle, pstrName, pType);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.Lock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT Lock([NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int> )(lpVtbl[35]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWbemObjectAccess.xml' path='doc/member[@name="IWbemObjectAccess.Unlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT Unlock([NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemObjectAccess*, int, int> )(lpVtbl[36]))((IWbemObjectAccess*)Unsafe.AsPointer(ref this), lFlags);
    }

    public interface Interface : IWbemClassObject.Interface
    {
        [VtblIndex(27)]
        HRESULT GetPropertyHandle([NativeTypeName("LPCWSTR")] ushort* wszPropertyName, [NativeTypeName("CIMTYPE *")] int* pType, [NativeTypeName("long *")] int* plHandle);
        [VtblIndex(28)]
        HRESULT WritePropertyValue([NativeTypeName("long")] int lHandle, [NativeTypeName("long")] int lNumBytes, [NativeTypeName("const byte *")] byte* aData);
        [VtblIndex(29)]
        HRESULT ReadPropertyValue([NativeTypeName("long")] int lHandle, [NativeTypeName("long")] int lBufferSize, [NativeTypeName("long *")] int* plNumBytes, byte* aData);
        [VtblIndex(30)]
        HRESULT ReadDWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("DWORD *")] uint* pdw);
        [VtblIndex(31)]
        HRESULT WriteDWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("DWORD")] uint dw);
        [VtblIndex(32)]
        HRESULT ReadQWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("unsigned long long *")] ulong* pqw);
        [VtblIndex(33)]
        HRESULT WriteQWORD([NativeTypeName("long")] int lHandle, [NativeTypeName("unsigned long long")] ulong pw);
        [VtblIndex(34)]
        HRESULT GetPropertyInfoByHandle([NativeTypeName("long")] int lHandle, [NativeTypeName("BSTR *")] ushort** pstrName, [NativeTypeName("CIMTYPE *")] int* pType);
        [VtblIndex(35)]
        HRESULT Lock([NativeTypeName("long")] int lFlags);
        [VtblIndex(36)]
        HRESULT Unlock([NativeTypeName("long")] int lFlags);
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
        [NativeTypeName("HRESULT (IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemQualifierSet**, int> GetQualifierSet;
        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, CIMTYPE *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int*, int*, int> Get;
        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, CIMTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int, int> Put;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Delete;
        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, SAFEARRAY**, int> GetNames;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> BeginEnumeration;
        [NativeTypeName("HRESULT (long, BSTR *, VARIANT *, CIMTYPE *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, VARIANT*, int*, int*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndEnumeration;
        [NativeTypeName("HRESULT (LPCWSTR, IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IWbemQualifierSet**, int> GetPropertyQualifierSet;
        [NativeTypeName("HRESULT (IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemClassObject**, int> Clone;
        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetObjectText;
        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemClassObject**, int> SpawnDerivedClass;
        [NativeTypeName("HRESULT (long, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemClassObject**, int> SpawnInstance;
        [NativeTypeName("HRESULT (long, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IWbemClassObject*, int> CompareTo;
        [NativeTypeName("HRESULT (LPCWSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetPropertyOrigin;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> InheritsFrom;
        [NativeTypeName("HRESULT (LPCWSTR, long, IWbemClassObject **, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, IWbemClassObject**, IWbemClassObject**, int> GetMethod;
        [NativeTypeName("HRESULT (LPCWSTR, long, IWbemClassObject *, IWbemClassObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, IWbemClassObject*, IWbemClassObject*, int> PutMethod;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteMethod;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> BeginMethodEnumeration;
        [NativeTypeName("HRESULT (long, BSTR *, IWbemClassObject **, IWbemClassObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, IWbemClassObject**, IWbemClassObject**, int> NextMethod;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndMethodEnumeration;
        [NativeTypeName("HRESULT (LPCWSTR, IWbemQualifierSet **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IWbemQualifierSet**, int> GetMethodQualifierSet;
        [NativeTypeName("HRESULT (LPCWSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetMethodOrigin;
        [NativeTypeName("HRESULT (LPCWSTR, CIMTYPE *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int*, int> GetPropertyHandle;
        [NativeTypeName("HRESULT (long, long, const byte *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, byte*, int> WritePropertyValue;
        [NativeTypeName("HRESULT (long, long, long *, byte *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int*, byte*, int> ReadPropertyValue;
        [NativeTypeName("HRESULT (long, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint*, int> ReadDWORD;
        [NativeTypeName("HRESULT (long, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, int> WriteDWORD;
        [NativeTypeName("HRESULT (long, unsigned long long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ulong*, int> ReadQWORD;
        [NativeTypeName("HRESULT (long, unsigned long long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ulong, int> WriteQWORD;
        [NativeTypeName("HRESULT (long, BSTR *, CIMTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int*, int> GetPropertyInfoByHandle;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Lock;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Unlock;
    }
}