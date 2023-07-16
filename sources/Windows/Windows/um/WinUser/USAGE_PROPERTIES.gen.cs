// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct USAGE_PROPERTIES
{
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.level"]/*'/>
    public ushort level;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.page"]/*'/>
    public ushort page;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.usage"]/*'/>
    public ushort usage;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.logicalMinimum"]/*'/>
    [NativeTypeName("INT32")]
    public int logicalMinimum;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.logicalMaximum"]/*'/>
    [NativeTypeName("INT32")]
    public int logicalMaximum;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.unit"]/*'/>
    public ushort unit;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.exponent"]/*'/>
    public ushort exponent;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.count"]/*'/>
    public byte count;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.physicalMinimum"]/*'/>
    [NativeTypeName("INT32")]
    public int physicalMinimum;
    /// <include file='USAGE_PROPERTIES.xml' path='doc/member[@name="USAGE_PROPERTIES.physicalMaximum"]/*'/>
    [NativeTypeName("INT32")]
    public int physicalMaximum;
}