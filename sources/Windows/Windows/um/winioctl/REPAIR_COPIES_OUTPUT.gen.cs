// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='REPAIR_COPIES_OUTPUT.xml' path='doc/member[@name="REPAIR_COPIES_OUTPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct REPAIR_COPIES_OUTPUT
{
    /// <include file='REPAIR_COPIES_OUTPUT.xml' path='doc/member[@name="REPAIR_COPIES_OUTPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='REPAIR_COPIES_OUTPUT.xml' path='doc/member[@name="REPAIR_COPIES_OUTPUT.Status"]/*' />
    [NativeTypeName("DWORD")]
    public uint Status;

    /// <include file='REPAIR_COPIES_OUTPUT.xml' path='doc/member[@name="REPAIR_COPIES_OUTPUT.ResumeFileOffset"]/*' />
    public LARGE_INTEGER ResumeFileOffset;
}
