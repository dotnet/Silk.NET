// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MetadataTimeStamps.xml' path='doc/member[@name="MetadataTimeStamps"]/*'/>
public partial struct MetadataTimeStamps
{
    /// <include file='MetadataTimeStamps.xml' path='doc/member[@name="MetadataTimeStamps.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='MetadataTimeStamps.xml' path='doc/member[@name="MetadataTimeStamps.Device"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Device;
    /// <include file='MetadataTimeStamps.xml' path='doc/member[@name="MetadataTimeStamps.Presentation"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Presentation;
}