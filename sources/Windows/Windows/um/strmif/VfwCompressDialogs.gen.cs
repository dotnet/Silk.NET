// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VfwCompressDialogs.xml' path='doc/member[@name="VfwCompressDialogs"]/*'/>
public enum VfwCompressDialogs
{
    /// <include file='VfwCompressDialogs.xml' path='doc/member[@name="VfwCompressDialogs.VfwCompressDialog_Config"]/*'/>
    VfwCompressDialog_Config = 0x1,
    /// <include file='VfwCompressDialogs.xml' path='doc/member[@name="VfwCompressDialogs.VfwCompressDialog_About"]/*'/>
    VfwCompressDialog_About = 0x2,
    /// <include file='VfwCompressDialogs.xml' path='doc/member[@name="VfwCompressDialogs.VfwCompressDialog_QueryConfig"]/*'/>
    VfwCompressDialog_QueryConfig = 0x4,
    /// <include file='VfwCompressDialogs.xml' path='doc/member[@name="VfwCompressDialogs.VfwCompressDialog_QueryAbout"]/*'/>
    VfwCompressDialog_QueryAbout = 0x8,
}