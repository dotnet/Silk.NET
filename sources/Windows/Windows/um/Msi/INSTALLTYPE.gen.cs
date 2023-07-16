// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INSTALLTYPE.xml' path='doc/member[@name="INSTALLTYPE"]/*'/>
public enum INSTALLTYPE
{
    /// <include file='INSTALLTYPE.xml' path='doc/member[@name="INSTALLTYPE.INSTALLTYPE_DEFAULT"]/*'/>
    INSTALLTYPE_DEFAULT = 0,
    /// <include file='INSTALLTYPE.xml' path='doc/member[@name="INSTALLTYPE.INSTALLTYPE_NETWORK_IMAGE"]/*'/>
    INSTALLTYPE_NETWORK_IMAGE = 1,
    /// <include file='INSTALLTYPE.xml' path='doc/member[@name="INSTALLTYPE.INSTALLTYPE_SINGLE_INSTANCE"]/*'/>
    INSTALLTYPE_SINGLE_INSTANCE = 2,
}