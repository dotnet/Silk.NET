// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CM_SET_WIDTH_VALUE.xml' path='doc/member[@name="CM_SET_WIDTH_VALUE"]/*' />
public enum CM_SET_WIDTH_VALUE
{
    /// <include file='CM_SET_WIDTH_VALUE.xml' path='doc/member[@name="CM_SET_WIDTH_VALUE.CM_WIDTH_USEDEFAULT"]/*' />
    CM_WIDTH_USEDEFAULT = -1,

    /// <include file='CM_SET_WIDTH_VALUE.xml' path='doc/member[@name="CM_SET_WIDTH_VALUE.CM_WIDTH_AUTOSIZE"]/*' />
    CM_WIDTH_AUTOSIZE = -2,
}
