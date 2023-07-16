// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EC_HOST_UI_MODE.xml' path='doc/member[@name="EC_HOST_UI_MODE"]/*'/>
public enum EC_HOST_UI_MODE
{
    /// <include file='EC_HOST_UI_MODE.xml' path='doc/member[@name="EC_HOST_UI_MODE.ECHUIM_DESKTOP"]/*'/>
    ECHUIM_DESKTOP = 0,
    /// <include file='EC_HOST_UI_MODE.xml' path='doc/member[@name="EC_HOST_UI_MODE.ECHUIM_IMMERSIVE"]/*'/>
    ECHUIM_IMMERSIVE = (ECHUIM_DESKTOP + 1),
    /// <include file='EC_HOST_UI_MODE.xml' path='doc/member[@name="EC_HOST_UI_MODE.ECHUIM_SYSTEM_LAUNCHER"]/*'/>
    ECHUIM_SYSTEM_LAUNCHER = (ECHUIM_IMMERSIVE + 1),
}