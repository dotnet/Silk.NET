// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken"]/*'/>
[Guid("C74A3ADC-B727-4500-A84A-B526721C8B8C")]
[NativeTypeName("struct ISpeechObjectToken : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechObjectToken : ISpeechObjectToken.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechObjectToken));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, uint> )(lpVtbl[1]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, uint> )(lpVtbl[2]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, uint*, int> )(lpVtbl[3]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_Id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Id([NativeTypeName("BSTR *")] ushort** ObjectId)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort**, int> )(lpVtbl[7]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectId);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_DataKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DataKey(ISpeechDataKey** DataKey)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ISpeechDataKey**, int> )(lpVtbl[8]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), DataKey);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.get_Category"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Category(ISpeechObjectTokenCategory** Category)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ISpeechObjectTokenCategory**, int> )(lpVtbl[9]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Category);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] ushort** Description)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, int, ushort**, int> )(lpVtbl[10]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Locale, Description);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.SetId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetId([NativeTypeName("BSTR")] ushort* Id, [NativeTypeName("BSTR")] ushort* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, short, int> )(lpVtbl[11]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Id, CategoryID, CreateIfNotExist);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttribute([NativeTypeName("BSTR")] ushort* AttributeName, [NativeTypeName("BSTR *")] ushort** AttributeValue)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort**, int> )(lpVtbl[12]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), AttributeName, AttributeValue);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateInstance(IUnknown* pUnkOuter, SpeechTokenContext ClsContext, IUnknown** Object)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, IUnknown*, SpeechTokenContext, IUnknown**, int> )(lpVtbl[13]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), pUnkOuter, ClsContext, Object);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.Remove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, int> )(lpVtbl[14]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.GetStorageFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("BSTR")] ushort* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] ushort** FilePath)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, ushort*, SpeechTokenShellFolder, ushort**, int> )(lpVtbl[15]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, FileName, Folder, FilePath);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.RemoveStorageFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, ushort*, short, int> )(lpVtbl[16]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), ObjectStorageCLSID, KeyName, DeleteFile);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.IsUISupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, VARIANT*, IUnknown*, short*, int> )(lpVtbl[17]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Object, Supported);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.DisplayUI"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, IUnknown* Object = null)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, int, ushort*, ushort*, VARIANT*, IUnknown*, int> )(lpVtbl[18]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), hWnd, Title, TypeOfUI, ExtraData, Object);
    }

    /// <include file='ISpeechObjectToken.xml' path='doc/member[@name="ISpeechObjectToken.MatchesAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MatchesAttributes([NativeTypeName("BSTR")] ushort* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches)
    {
        return ((delegate* unmanaged<ISpeechObjectToken*, ushort*, short*, int> )(lpVtbl[19]))((ISpeechObjectToken*)Unsafe.AsPointer(ref this), Attributes, Matches);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Id([NativeTypeName("BSTR *")] ushort** ObjectId);
        [VtblIndex(8)]
        HRESULT get_DataKey(ISpeechDataKey** DataKey);
        [VtblIndex(9)]
        HRESULT get_Category(ISpeechObjectTokenCategory** Category);
        [VtblIndex(10)]
        HRESULT GetDescription([NativeTypeName("long")] int Locale, [NativeTypeName("BSTR *")] ushort** Description);
        [VtblIndex(11)]
        HRESULT SetId([NativeTypeName("BSTR")] ushort* Id, [NativeTypeName("BSTR")] ushort* CategoryID = null, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0);
        [VtblIndex(12)]
        HRESULT GetAttribute([NativeTypeName("BSTR")] ushort* AttributeName, [NativeTypeName("BSTR *")] ushort** AttributeValue);
        [VtblIndex(13)]
        HRESULT CreateInstance(IUnknown* pUnkOuter, SpeechTokenContext ClsContext, IUnknown** Object);
        [VtblIndex(14)]
        HRESULT Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID);
        [VtblIndex(15)]
        HRESULT GetStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("BSTR")] ushort* FileName, SpeechTokenShellFolder Folder, [NativeTypeName("BSTR *")] ushort** FilePath);
        [VtblIndex(16)]
        HRESULT RemoveStorageFileName([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID, [NativeTypeName("BSTR")] ushort* KeyName, [NativeTypeName("VARIANT_BOOL")] short DeleteFile);
        [VtblIndex(17)]
        HRESULT IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, IUnknown* Object, [NativeTypeName("VARIANT_BOOL *")] short* Supported);
        [VtblIndex(18)]
        HRESULT DisplayUI([NativeTypeName("long")] int hWnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null, IUnknown* Object = null);
        [VtblIndex(19)]
        HRESULT MatchesAttributes([NativeTypeName("BSTR")] ushort* Attributes, [NativeTypeName("VARIANT_BOOL *")] short* Matches);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_Id;
        [NativeTypeName("HRESULT (ISpeechDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechDataKey**, int> get_DataKey;
        [NativeTypeName("HRESULT (ISpeechObjectTokenCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectTokenCategory**, int> get_Category;
        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetDescription;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, short, int> SetId;
        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetAttribute;
        [NativeTypeName("HRESULT (IUnknown *, SpeechTokenContext, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, SpeechTokenContext, IUnknown**, int> CreateInstance;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Remove;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, SpeechTokenShellFolder, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, SpeechTokenShellFolder, ushort**, int> GetStorageFileName;
        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, short, int> RemoveStorageFileName;
        [NativeTypeName("HRESULT (const BSTR, const VARIANT *, IUnknown *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, IUnknown*, short*, int> IsUISupported;
        [NativeTypeName("HRESULT (long, BSTR, const BSTR, const VARIANT *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, ushort*, VARIANT*, IUnknown*, int> DisplayUI;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> MatchesAttributes;
    }
}