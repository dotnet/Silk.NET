// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSETMAPPERFLAGS.xml' path='doc/member[@name="EMRSETMAPPERFLAGS"]/*'/>
public partial struct EMRSETMAPPERFLAGS
{
    /// <include file='EMRSETMAPPERFLAGS.xml' path='doc/member[@name="EMRSETMAPPERFLAGS.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETMAPPERFLAGS.xml' path='doc/member[@name="EMRSETMAPPERFLAGS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}