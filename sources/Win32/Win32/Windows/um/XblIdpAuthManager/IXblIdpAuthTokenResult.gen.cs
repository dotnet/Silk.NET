// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("46CE0225-F267-4D68-B299-B2762552DEC1")]
[NativeTypeName("struct IXblIdpAuthTokenResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXblIdpAuthTokenResult : IXblIdpAuthTokenResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXblIdpAuthTokenResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(XBL_IDP_AUTH_TOKEN_STATUS* status)
    {
        return (
            (delegate* unmanaged<IXblIdpAuthTokenResult, XBL_IDP_AUTH_TOKEN_STATUS*, int>)(
                (*lpVtbl)[3]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetErrorCode(HRESULT* errorCode)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, HRESULT*, int>)((*lpVtbl)[4]))(
            this,
            errorCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetToken([NativeTypeName("LPWSTR *")] ushort** token)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[5]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSignature([NativeTypeName("LPWSTR *")] ushort** signature)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[6]))(
            this,
            signature
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[7]))(
            this,
            sandbox
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[8]))(
            this,
            environment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMsaAccountId([NativeTypeName("LPWSTR *")] ushort** msaAccountId)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[9]))(
            this,
            msaAccountId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetXuid([NativeTypeName("LPWSTR *")] ushort** xuid)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[10]))(
            this,
            xuid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGamertag([NativeTypeName("LPWSTR *")] ushort** gamertag)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[11]))(
            this,
            gamertag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAgeGroup([NativeTypeName("LPWSTR *")] ushort** ageGroup)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[12]))(
            this,
            ageGroup
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPrivileges([NativeTypeName("LPWSTR *")] ushort** privileges)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[13]))(
            this,
            privileges
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMsaTarget([NativeTypeName("LPWSTR *")] ushort** msaTarget)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[14]))(
            this,
            msaTarget
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetMsaPolicy([NativeTypeName("LPWSTR *")] ushort** msaPolicy)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[15]))(
            this,
            msaPolicy
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMsaAppId([NativeTypeName("LPWSTR *")] ushort** msaAppId)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[16]))(
            this,
            msaAppId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetRedirect([NativeTypeName("LPWSTR *")] ushort** redirect)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[17]))(
            this,
            redirect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetMessageW([NativeTypeName("LPWSTR *")] ushort** message)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[18]))(
            this,
            message
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetHelpId([NativeTypeName("LPWSTR *")] ushort** helpId)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[19]))(
            this,
            helpId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEnforcementBans([NativeTypeName("LPWSTR *")] ushort** enforcementBans)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[20]))(
            this,
            enforcementBans
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetRestrictions([NativeTypeName("LPWSTR *")] ushort** restrictions)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[21]))(
            this,
            restrictions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetTitleRestrictions([NativeTypeName("LPWSTR *")] ushort** titleRestrictions)
    {
        return ((delegate* unmanaged<IXblIdpAuthTokenResult, ushort**, int>)((*lpVtbl)[22]))(
            this,
            titleRestrictions
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStatus(XBL_IDP_AUTH_TOKEN_STATUS* status);

        [VtblIndex(4)]
        HRESULT GetErrorCode(HRESULT* errorCode);

        [VtblIndex(5)]
        HRESULT GetToken([NativeTypeName("LPWSTR *")] ushort** token);

        [VtblIndex(6)]
        HRESULT GetSignature([NativeTypeName("LPWSTR *")] ushort** signature);

        [VtblIndex(7)]
        HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox);

        [VtblIndex(8)]
        HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment);

        [VtblIndex(9)]
        HRESULT GetMsaAccountId([NativeTypeName("LPWSTR *")] ushort** msaAccountId);

        [VtblIndex(10)]
        HRESULT GetXuid([NativeTypeName("LPWSTR *")] ushort** xuid);

        [VtblIndex(11)]
        HRESULT GetGamertag([NativeTypeName("LPWSTR *")] ushort** gamertag);

        [VtblIndex(12)]
        HRESULT GetAgeGroup([NativeTypeName("LPWSTR *")] ushort** ageGroup);

        [VtblIndex(13)]
        HRESULT GetPrivileges([NativeTypeName("LPWSTR *")] ushort** privileges);

        [VtblIndex(14)]
        HRESULT GetMsaTarget([NativeTypeName("LPWSTR *")] ushort** msaTarget);

        [VtblIndex(15)]
        HRESULT GetMsaPolicy([NativeTypeName("LPWSTR *")] ushort** msaPolicy);

        [VtblIndex(16)]
        HRESULT GetMsaAppId([NativeTypeName("LPWSTR *")] ushort** msaAppId);

        [VtblIndex(17)]
        HRESULT GetRedirect([NativeTypeName("LPWSTR *")] ushort** redirect);

        [VtblIndex(18)]
        HRESULT GetMessageW([NativeTypeName("LPWSTR *")] ushort** message);

        [VtblIndex(19)]
        HRESULT GetHelpId([NativeTypeName("LPWSTR *")] ushort** helpId);

        [VtblIndex(20)]
        HRESULT GetEnforcementBans([NativeTypeName("LPWSTR *")] ushort** enforcementBans);

        [VtblIndex(21)]
        HRESULT GetRestrictions([NativeTypeName("LPWSTR *")] ushort** restrictions);

        [VtblIndex(22)]
        HRESULT GetTitleRestrictions([NativeTypeName("LPWSTR *")] ushort** titleRestrictions);
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

        [NativeTypeName("HRESULT (XBL_IDP_AUTH_TOKEN_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XBL_IDP_AUTH_TOKEN_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> GetErrorCode;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetToken;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSignature;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSandbox;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEnvironment;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMsaAccountId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetXuid;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetGamertag;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAgeGroup;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPrivileges;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMsaTarget;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMsaPolicy;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMsaAppId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRedirect;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetMessageW;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetHelpId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEnforcementBans;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRestrictions;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTitleRestrictions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXblIdpAuthTokenResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXblIdpAuthTokenResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXblIdpAuthTokenResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXblIdpAuthTokenResult(Silk.NET.Windows.IUnknown value)
    {
        return new IXblIdpAuthTokenResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXblIdpAuthTokenResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXblIdpAuthTokenResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXblIdpAuthTokenResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
