// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIBICMPINFO.xml' path='doc/member[@name="MIBICMPINFO"]/*'/>
public partial struct MIBICMPINFO
{
    /// <include file='MIBICMPINFO.xml' path='doc/member[@name="MIBICMPINFO.icmpInStats"]/*'/>
    public MIBICMPSTATS icmpInStats;
    /// <include file='MIBICMPINFO.xml' path='doc/member[@name="MIBICMPINFO.icmpOutStats"]/*'/>
    public MIBICMPSTATS icmpOutStats;
}