// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SID
{
    [NativeTypeName("#define SID_IBindHost IID_IBindHost")]
    public static ref readonly Guid SID_IBindHost => ref IID_IBindHost;

    [NativeTypeName("#define SID_SBindHost IID_IBindHost")]
    public static ref readonly Guid SID_SBindHost => ref IID_IBindHost;

    [NativeTypeName("#define SID_SInternetSecurityManager IID_IInternetSecurityManager")]
    public static ref readonly Guid SID_SInternetSecurityManager =>
        ref IID_IInternetSecurityManager;

    [NativeTypeName("#define SID_SInternetSecurityManagerEx IID_IInternetSecurityManagerEx")]
    public static ref readonly Guid SID_SInternetSecurityManagerEx =>
        ref IID_IInternetSecurityManagerEx;

    [NativeTypeName("#define SID_SInternetSecurityManagerEx2 IID_IInternetSecurityManagerEx2")]
    public static ref readonly Guid SID_SInternetSecurityManagerEx2 =>
        ref IID_IInternetSecurityManagerEx2;

    [NativeTypeName("#define SID_SInternetHostSecurityManager IID_IInternetHostSecurityManager")]
    public static ref readonly Guid SID_SInternetHostSecurityManager =>
        ref IID_IInternetHostSecurityManager;
}
