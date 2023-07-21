// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPX_PACKAGING_CONTEXT_CHANGE_TYPE.xml' path='doc/member[@name="APPX_PACKAGING_CONTEXT_CHANGE_TYPE"]/*' />
public enum APPX_PACKAGING_CONTEXT_CHANGE_TYPE
{
    /// <include file='APPX_PACKAGING_CONTEXT_CHANGE_TYPE.xml' path='doc/member[@name="APPX_PACKAGING_CONTEXT_CHANGE_TYPE.APPX_PACKAGING_CONTEXT_CHANGE_TYPE_START"]/*' />
    APPX_PACKAGING_CONTEXT_CHANGE_TYPE_START = 0,

    /// <include file='APPX_PACKAGING_CONTEXT_CHANGE_TYPE.xml' path='doc/member[@name="APPX_PACKAGING_CONTEXT_CHANGE_TYPE.APPX_PACKAGING_CONTEXT_CHANGE_TYPE_CHANGE"]/*' />
    APPX_PACKAGING_CONTEXT_CHANGE_TYPE_CHANGE = 1,

    /// <include file='APPX_PACKAGING_CONTEXT_CHANGE_TYPE.xml' path='doc/member[@name="APPX_PACKAGING_CONTEXT_CHANGE_TYPE.APPX_PACKAGING_CONTEXT_CHANGE_TYPE_DETAILS"]/*' />
    APPX_PACKAGING_CONTEXT_CHANGE_TYPE_DETAILS = 2,

    /// <include file='APPX_PACKAGING_CONTEXT_CHANGE_TYPE.xml' path='doc/member[@name="APPX_PACKAGING_CONTEXT_CHANGE_TYPE.APPX_PACKAGING_CONTEXT_CHANGE_TYPE_END"]/*' />
    APPX_PACKAGING_CONTEXT_CHANGE_TYPE_END = 3,
}
