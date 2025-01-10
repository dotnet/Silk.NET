// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354133-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscRecorder2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDiscRecorder2 : IDiscRecorder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscRecorder2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscRecorder2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscRecorder2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscRecorder2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscRecorder2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IDiscRecorder2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
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
            (delegate* unmanaged<IDiscRecorder2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IDiscRecorder2,
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
    public HRESULT EjectMedia()
    {
        return ((delegate* unmanaged<IDiscRecorder2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CloseTray()
    {
        return ((delegate* unmanaged<IDiscRecorder2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AcquireExclusiveAccess(
        [NativeTypeName("VARIANT_BOOL")] short force,
        [NativeTypeName("BSTR")] ushort* __MIDL__IDiscRecorder20000
    )
    {
        return ((delegate* unmanaged<IDiscRecorder2, short, ushort*, int>)((*lpVtbl)[9]))(
            this,
            force,
            __MIDL__IDiscRecorder20000
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReleaseExclusiveAccess()
    {
        return ((delegate* unmanaged<IDiscRecorder2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DisableMcn()
    {
        return ((delegate* unmanaged<IDiscRecorder2, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnableMcn()
    {
        return ((delegate* unmanaged<IDiscRecorder2, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT InitializeDiscRecorder([NativeTypeName("BSTR")] ushort* recorderUniqueId)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort*, int>)((*lpVtbl)[13]))(
            this,
            recorderUniqueId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ActiveDiscRecorder([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_VendorId([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ProductId([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ProductRevision([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_VolumePathNames(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DeviceCanLoadMedia([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, short*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_LegacyDeviceNumber([NativeTypeName("LONG *")] int* legacyDeviceNumber)
    {
        return ((delegate* unmanaged<IDiscRecorder2, int*, int>)((*lpVtbl)[21]))(
            this,
            legacyDeviceNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SupportedFeaturePages(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CurrentFeaturePages(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_SupportedProfiles(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_CurrentProfiles(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_SupportedModePages(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, SAFEARRAY**, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ExclusiveAccessOwner([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscRecorder2, ushort**, int>)((*lpVtbl)[27]))(this, value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT EjectMedia();

        [VtblIndex(8)]
        HRESULT CloseTray();

        [VtblIndex(9)]
        HRESULT AcquireExclusiveAccess(
            [NativeTypeName("VARIANT_BOOL")] short force,
            [NativeTypeName("BSTR")] ushort* __MIDL__IDiscRecorder20000
        );

        [VtblIndex(10)]
        HRESULT ReleaseExclusiveAccess();

        [VtblIndex(11)]
        HRESULT DisableMcn();

        [VtblIndex(12)]
        HRESULT EnableMcn();

        [VtblIndex(13)]
        HRESULT InitializeDiscRecorder([NativeTypeName("BSTR")] ushort* recorderUniqueId);

        [VtblIndex(14)]
        HRESULT get_ActiveDiscRecorder([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(15)]
        HRESULT get_VendorId([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(16)]
        HRESULT get_ProductId([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(17)]
        HRESULT get_ProductRevision([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(18)]
        HRESULT get_VolumeName([NativeTypeName("BSTR *")] ushort** value);

        [VtblIndex(19)]
        HRESULT get_VolumePathNames(SAFEARRAY** value);

        [VtblIndex(20)]
        HRESULT get_DeviceCanLoadMedia([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(21)]
        HRESULT get_LegacyDeviceNumber([NativeTypeName("LONG *")] int* legacyDeviceNumber);

        [VtblIndex(22)]
        HRESULT get_SupportedFeaturePages(SAFEARRAY** value);

        [VtblIndex(23)]
        HRESULT get_CurrentFeaturePages(SAFEARRAY** value);

        [VtblIndex(24)]
        HRESULT get_SupportedProfiles(SAFEARRAY** value);

        [VtblIndex(25)]
        HRESULT get_CurrentProfiles(SAFEARRAY** value);

        [VtblIndex(26)]
        HRESULT get_SupportedModePages(SAFEARRAY** value);

        [VtblIndex(27)]
        HRESULT get_ExclusiveAccessOwner([NativeTypeName("BSTR *")] ushort** value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EjectMedia;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CloseTray;

        [NativeTypeName("HRESULT (VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, ushort*, int> AcquireExclusiveAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseExclusiveAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisableMcn;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnableMcn;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> InitializeDiscRecorder;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ActiveDiscRecorder;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VendorId;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ProductId;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ProductRevision;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_VolumeName;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_VolumePathNames;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DeviceCanLoadMedia;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LegacyDeviceNumber;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedFeaturePages;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_CurrentFeaturePages;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedProfiles;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_CurrentProfiles;

        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedModePages;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ExclusiveAccessOwner;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscRecorder2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscRecorder2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IDiscRecorder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IDiscRecorder2(Silk.NET.Windows.IDispatch value)
    {
        return new IDiscRecorder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscRecorder2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscRecorder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IDiscRecorder2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscRecorder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscRecorder2(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscRecorder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscRecorder2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscRecorder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscRecorder2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
