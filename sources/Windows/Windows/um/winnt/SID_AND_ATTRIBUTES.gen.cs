// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SID_AND_ATTRIBUTES.xml' path='doc/member[@name="SID_AND_ATTRIBUTES"]/*' />
public unsafe partial struct SID_AND_ATTRIBUTES
{
    /// <include file='SID_AND_ATTRIBUTES.xml' path='doc/member[@name="SID_AND_ATTRIBUTES.Sid"]/*' />
    [NativeTypeName("PSID")]
    public void* Sid;

    /// <include file='SID_AND_ATTRIBUTES.xml' path='doc/member[@name="SID_AND_ATTRIBUTES.Attributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint Attributes;
}
