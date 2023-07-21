// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_Plugin_Type.xml' path='doc/member[@name="MF_Plugin_Type"]/*' />
public enum MF_Plugin_Type
{
    /// <include file='MF_Plugin_Type.xml' path='doc/member[@name="MF_Plugin_Type.MF_Plugin_Type_MFT"]/*' />
    MF_Plugin_Type_MFT = 0,

    /// <include file='MF_Plugin_Type.xml' path='doc/member[@name="MF_Plugin_Type.MF_Plugin_Type_MediaSource"]/*' />
    MF_Plugin_Type_MediaSource = 1,

    /// <include file='MF_Plugin_Type.xml' path='doc/member[@name="MF_Plugin_Type.MF_Plugin_Type_MFT_MatchOutputType"]/*' />
    MF_Plugin_Type_MFT_MatchOutputType = 2,

    /// <include file='MF_Plugin_Type.xml' path='doc/member[@name="MF_Plugin_Type.MF_Plugin_Type_Other"]/*' />
    MF_Plugin_Type_Other = unchecked((uint)(-1)),
}
