// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='API_VERSION.xml' path='doc/member[@name="API_VERSION"]/*' />
public partial struct API_VERSION
{
    /// <include file='API_VERSION.xml' path='doc/member[@name="API_VERSION.MajorVersion"]/*' />
    public ushort MajorVersion;

    /// <include file='API_VERSION.xml' path='doc/member[@name="API_VERSION.MinorVersion"]/*' />
    public ushort MinorVersion;

    /// <include file='API_VERSION.xml' path='doc/member[@name="API_VERSION.Revision"]/*' />
    public ushort Revision;

    /// <include file='API_VERSION.xml' path='doc/member[@name="API_VERSION.Reserved"]/*' />
    public ushort Reserved;
}
