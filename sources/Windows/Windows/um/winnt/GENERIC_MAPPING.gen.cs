// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GENERIC_MAPPING.xml' path='doc/member[@name="GENERIC_MAPPING"]/*'/>
public partial struct GENERIC_MAPPING
{
    /// <include file='GENERIC_MAPPING.xml' path='doc/member[@name="GENERIC_MAPPING.GenericRead"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint GenericRead;
    /// <include file='GENERIC_MAPPING.xml' path='doc/member[@name="GENERIC_MAPPING.GenericWrite"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint GenericWrite;
    /// <include file='GENERIC_MAPPING.xml' path='doc/member[@name="GENERIC_MAPPING.GenericExecute"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint GenericExecute;
    /// <include file='GENERIC_MAPPING.xml' path='doc/member[@name="GENERIC_MAPPING.GenericAll"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint GenericAll;
}