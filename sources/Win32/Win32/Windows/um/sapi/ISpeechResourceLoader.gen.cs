// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B9AC5783-FCD0-4B21-B119-B4F8DA8FD2C3")]
[NativeTypeName("struct ISpeechResourceLoader : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechResourceLoader : ISpeechResourceLoader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechResourceLoader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechResourceLoader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechResourceLoader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechResourceLoader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechResourceLoader, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechResourceLoader, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<ISpeechResourceLoader, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechResourceLoader,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadResource(
        [NativeTypeName("BSTR")] ushort* bstrResourceUri,
        [NativeTypeName("VARIANT_BOOL")] short fAlwaysReload,
        IUnknown* pStream,
        [NativeTypeName("BSTR *")] ushort** pbstrMIMEType,
        [NativeTypeName("VARIANT_BOOL *")] short* pfModified,
        [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechResourceLoader,
                ushort*,
                short,
                IUnknown*,
                ushort**,
                short*,
                ushort**,
                int>)((*lpVtbl)[7])
        )(
            this,
            bstrResourceUri,
            fAlwaysReload,
            pStream,
            pbstrMIMEType,
            pfModified,
            pbstrRedirectUrl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLocalCopy(
        [NativeTypeName("BSTR")] ushort* bstrResourceUri,
        [NativeTypeName("BSTR *")] ushort** pbstrLocalPath,
        [NativeTypeName("BSTR *")] ushort** pbstrMIMEType,
        [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechResourceLoader,
                ushort*,
                ushort**,
                ushort**,
                ushort**,
                int>)((*lpVtbl)[8])
        )(this, bstrResourceUri, pbstrLocalPath, pbstrMIMEType, pbstrRedirectUrl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReleaseLocalCopy([NativeTypeName("BSTR")] ushort* pbstrLocalPath)
    {
        return ((delegate* unmanaged<ISpeechResourceLoader, ushort*, int>)((*lpVtbl)[9]))(
            this,
            pbstrLocalPath
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT LoadResource(
            [NativeTypeName("BSTR")] ushort* bstrResourceUri,
            [NativeTypeName("VARIANT_BOOL")] short fAlwaysReload,
            IUnknown* pStream,
            [NativeTypeName("BSTR *")] ushort** pbstrMIMEType,
            [NativeTypeName("VARIANT_BOOL *")] short* pfModified,
            [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl
        );

        [VtblIndex(8)]
        HRESULT GetLocalCopy(
            [NativeTypeName("BSTR")] ushort* bstrResourceUri,
            [NativeTypeName("BSTR *")] ushort** pbstrLocalPath,
            [NativeTypeName("BSTR *")] ushort** pbstrMIMEType,
            [NativeTypeName("BSTR *")] ushort** pbstrRedirectUrl
        );

        [VtblIndex(9)]
        HRESULT ReleaseLocalCopy([NativeTypeName("BSTR")] ushort* pbstrLocalPath);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT_BOOL, IUnknown **, BSTR *, VARIANT_BOOL *, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            short,
            IUnknown*,
            ushort**,
            short*,
            ushort**,
            int> LoadResource;

        [NativeTypeName("HRESULT (BSTR, BSTR *, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, ushort**, ushort**, int> GetLocalCopy;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ReleaseLocalCopy;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechResourceLoader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechResourceLoader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechResourceLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechResourceLoader(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechResourceLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechResourceLoader"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechResourceLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechResourceLoader value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechResourceLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechResourceLoader(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechResourceLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechResourceLoader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechResourceLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechResourceLoader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
