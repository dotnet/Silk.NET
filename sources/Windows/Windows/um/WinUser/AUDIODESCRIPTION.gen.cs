// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AUDIODESCRIPTION.xml' path='doc/member[@name="AUDIODESCRIPTION"]/*'/>
public partial struct AUDIODESCRIPTION
{
    /// <include file='AUDIODESCRIPTION.xml' path='doc/member[@name="AUDIODESCRIPTION.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='AUDIODESCRIPTION.xml' path='doc/member[@name="AUDIODESCRIPTION.Enabled"]/*'/>
    public BOOL Enabled;
    /// <include file='AUDIODESCRIPTION.xml' path='doc/member[@name="AUDIODESCRIPTION.Locale"]/*'/>
    [NativeTypeName("LCID")]
    public uint Locale;
}