// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STREAM_INFO_LEVELS.xml' path='doc/member[@name="STREAM_INFO_LEVELS"]/*'/>
public enum STREAM_INFO_LEVELS
{
    /// <include file='STREAM_INFO_LEVELS.xml' path='doc/member[@name="STREAM_INFO_LEVELS.FindStreamInfoStandard"]/*'/>
    FindStreamInfoStandard,
    /// <include file='STREAM_INFO_LEVELS.xml' path='doc/member[@name="STREAM_INFO_LEVELS.FindStreamInfoMaxInfoLevel"]/*'/>
    FindStreamInfoMaxInfoLevel,
}