// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTMLCaptionFlag.xml' path='doc/member[@name="HTMLCaptionFlag"]/*' />
public enum HTMLCaptionFlag
{
    /// <include file='HTMLCaptionFlag.xml' path='doc/member[@name="HTMLCaptionFlag.HTMLCaptionFlagNo"]/*' />
    HTMLCaptionFlagNo = 0,

    /// <include file='HTMLCaptionFlag.xml' path='doc/member[@name="HTMLCaptionFlag.HTMLCaptionFlagYes"]/*' />
    HTMLCaptionFlagYes = 0xc00000,

    /// <include file='HTMLCaptionFlag.xml' path='doc/member[@name="HTMLCaptionFlag.HTMLCaptionFlag_Max"]/*' />
    HTMLCaptionFlag_Max = 2147483647,
}
