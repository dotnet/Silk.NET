// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FLOAT128.xml' path='doc/member[@name="FLOAT128"]/*'/>
public partial struct FLOAT128
{
    /// <include file='FLOAT128.xml' path='doc/member[@name="FLOAT128.LowPart"]/*'/>
    [NativeTypeName("long long")]
    public long LowPart;
    /// <include file='FLOAT128.xml' path='doc/member[@name="FLOAT128.HighPart"]/*'/>
    [NativeTypeName("long long")]
    public long HighPart;
}