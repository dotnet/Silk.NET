// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting"]/*'/>
public enum MFVideoLighting
{
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_Unknown"]/*'/>
    MFVideoLighting_Unknown = 0,
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_bright"]/*'/>
    MFVideoLighting_bright = 1,
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_office"]/*'/>
    MFVideoLighting_office = 2,
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_dim"]/*'/>
    MFVideoLighting_dim = 3,
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_dark"]/*'/>
    MFVideoLighting_dark = 4,
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_Last"]/*'/>
    MFVideoLighting_Last = (MFVideoLighting_dark + 1),
    /// <include file='MFVideoLighting.xml' path='doc/member[@name="MFVideoLighting.MFVideoLighting_ForceDWORD"]/*'/>
    MFVideoLighting_ForceDWORD = 0x7fffffff,
}