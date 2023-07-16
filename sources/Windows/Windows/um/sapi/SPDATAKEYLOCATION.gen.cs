// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPDATAKEYLOCATION.xml' path='doc/member[@name="SPDATAKEYLOCATION"]/*'/>
public enum SPDATAKEYLOCATION
{
    /// <include file='SPDATAKEYLOCATION.xml' path='doc/member[@name="SPDATAKEYLOCATION.SPDKL_DefaultLocation"]/*'/>
    SPDKL_DefaultLocation = 0,
    /// <include file='SPDATAKEYLOCATION.xml' path='doc/member[@name="SPDATAKEYLOCATION.SPDKL_CurrentUser"]/*'/>
    SPDKL_CurrentUser = 1,
    /// <include file='SPDATAKEYLOCATION.xml' path='doc/member[@name="SPDATAKEYLOCATION.SPDKL_LocalMachine"]/*'/>
    SPDKL_LocalMachine = 2,
    /// <include file='SPDATAKEYLOCATION.xml' path='doc/member[@name="SPDATAKEYLOCATION.SPDKL_CurrentConfig"]/*'/>
    SPDKL_CurrentConfig = 5,
}