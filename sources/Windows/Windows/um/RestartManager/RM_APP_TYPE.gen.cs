// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE"]/*' />
public enum RM_APP_TYPE
{
    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmUnknownApp"]/*' />
    RmUnknownApp = 0,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmMainWindow"]/*' />
    RmMainWindow = 1,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmOtherWindow"]/*' />
    RmOtherWindow = 2,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmService"]/*' />
    RmService = 3,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmExplorer"]/*' />
    RmExplorer = 4,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmConsole"]/*' />
    RmConsole = 5,

    /// <include file='RM_APP_TYPE.xml' path='doc/member[@name="RM_APP_TYPE.RmCritical"]/*' />
    RmCritical = 1000,
}
