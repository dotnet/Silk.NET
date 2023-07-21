// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoSrcContentHintFlags.xml' path='doc/member[@name="MFVideoSrcContentHintFlags"]/*' />
public enum MFVideoSrcContentHintFlags
{
    /// <include file='MFVideoSrcContentHintFlags.xml' path='doc/member[@name="MFVideoSrcContentHintFlags.MFVideoSrcContentHintFlag_None"]/*' />
    MFVideoSrcContentHintFlag_None = 0,

    /// <include file='MFVideoSrcContentHintFlags.xml' path='doc/member[@name="MFVideoSrcContentHintFlags.MFVideoSrcContentHintFlag_16x9"]/*' />
    MFVideoSrcContentHintFlag_16x9 = 1,

    /// <include file='MFVideoSrcContentHintFlags.xml' path='doc/member[@name="MFVideoSrcContentHintFlags.MFVideoSrcContentHintFlag_235_1"]/*' />
    MFVideoSrcContentHintFlag_235_1 = 2,
}
