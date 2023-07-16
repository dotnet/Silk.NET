// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HISTOGRAM_BUCKET.xml' path='doc/member[@name="HISTOGRAM_BUCKET"]/*'/>
public partial struct HISTOGRAM_BUCKET
{
    /// <include file='HISTOGRAM_BUCKET.xml' path='doc/member[@name="HISTOGRAM_BUCKET.Reads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reads;
    /// <include file='HISTOGRAM_BUCKET.xml' path='doc/member[@name="HISTOGRAM_BUCKET.Writes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Writes;
}