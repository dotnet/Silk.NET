// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GET_FILEEX_INFO_LEVELS.xml' path='doc/member[@name="GET_FILEEX_INFO_LEVELS"]/*'/>
public enum GET_FILEEX_INFO_LEVELS
{
    /// <include file='GET_FILEEX_INFO_LEVELS.xml' path='doc/member[@name="GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard"]/*'/>
    GetFileExInfoStandard,
    /// <include file='GET_FILEEX_INFO_LEVELS.xml' path='doc/member[@name="GET_FILEEX_INFO_LEVELS.GetFileExMaxInfoLevel"]/*'/>
    GetFileExMaxInfoLevel,
}