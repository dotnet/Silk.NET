// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='EXTCONN.xml' path='doc/member[@name="EXTCONN"]/*'/>
[Flags]
public enum EXTCONN
{
    /// <include file='EXTCONN.xml' path='doc/member[@name="EXTCONN.EXTCONN_STRONG"]/*'/>
    EXTCONN_STRONG = 0x1,
    /// <include file='EXTCONN.xml' path='doc/member[@name="EXTCONN.EXTCONN_WEAK"]/*'/>
    EXTCONN_WEAK = 0x2,
    /// <include file='EXTCONN.xml' path='doc/member[@name="EXTCONN.EXTCONN_CALLABLE"]/*'/>
    EXTCONN_CALLABLE = 0x4,
}