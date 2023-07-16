// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KCRM_MARSHAL_HEADER.xml' path='doc/member[@name="KCRM_MARSHAL_HEADER"]/*'/>
public partial struct KCRM_MARSHAL_HEADER
{
    /// <include file='KCRM_MARSHAL_HEADER.xml' path='doc/member[@name="KCRM_MARSHAL_HEADER.VersionMajor"]/*'/>
    [NativeTypeName("ULONG")]
    public uint VersionMajor;
    /// <include file='KCRM_MARSHAL_HEADER.xml' path='doc/member[@name="KCRM_MARSHAL_HEADER.VersionMinor"]/*'/>
    [NativeTypeName("ULONG")]
    public uint VersionMinor;
    /// <include file='KCRM_MARSHAL_HEADER.xml' path='doc/member[@name="KCRM_MARSHAL_HEADER.NumProtocols"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NumProtocols;
    /// <include file='KCRM_MARSHAL_HEADER.xml' path='doc/member[@name="KCRM_MARSHAL_HEADER.Unused"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Unused;
}