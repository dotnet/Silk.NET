// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DPI_HOSTING_BEHAVIOR.xml' path='doc/member[@name="DPI_HOSTING_BEHAVIOR"]/*'/>
public enum DPI_HOSTING_BEHAVIOR
{
    /// <include file='DPI_HOSTING_BEHAVIOR.xml' path='doc/member[@name="DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_INVALID"]/*'/>
    DPI_HOSTING_BEHAVIOR_INVALID = -1,
    /// <include file='DPI_HOSTING_BEHAVIOR.xml' path='doc/member[@name="DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_DEFAULT"]/*'/>
    DPI_HOSTING_BEHAVIOR_DEFAULT = 0,
    /// <include file='DPI_HOSTING_BEHAVIOR.xml' path='doc/member[@name="DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_MIXED"]/*'/>
    DPI_HOSTING_BEHAVIOR_MIXED = 1,
}