// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcOpenSubscriptionEnum"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern EC_HANDLE EcOpenSubscriptionEnum([NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcEnumNextSubscription"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcEnumNextSubscription(EC_HANDLE SubscriptionEnum, [NativeTypeName("DWORD")] uint SubscriptionNameBufferSize, [NativeTypeName("LPWSTR")] ushort* SubscriptionNameBuffer, [NativeTypeName("PDWORD")] uint* SubscriptionNameBufferUsed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcOpenSubscription"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern EC_HANDLE EcOpenSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcSetSubscriptionProperty"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcSetSubscriptionProperty(EC_HANDLE Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcGetSubscriptionProperty"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcGetSubscriptionProperty(EC_HANDLE Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcSaveSubscription"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcSaveSubscription(EC_HANDLE Subscription, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcDeleteSubscription"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcDeleteSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcGetObjectArraySize"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcGetObjectArraySize(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("PDWORD")] uint* ObjectArraySize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcSetObjectArrayProperty"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcSetObjectArrayProperty(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcGetObjectArrayProperty"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcGetObjectArrayProperty(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcInsertObjectArrayElement"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcInsertObjectArrayElement(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcRemoveObjectArrayElement"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcRemoveObjectArrayElement(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcGetSubscriptionRunTimeStatus"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcGetSubscriptionRunTimeStatus([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID StatusInfoId, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint StatusValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* StatusValueBuffer, [NativeTypeName("PDWORD")] uint* StatusValueBufferUsed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcRetrySubscription"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcRetrySubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EcClose"]/*' />
    [DllImport("wecapi", ExactSpelling = true)]
    public static extern BOOL EcClose(EC_HANDLE Object);
}
