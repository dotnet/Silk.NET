// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RM_FILTER_ACTION.xml' path='doc/member[@name="RM_FILTER_ACTION"]/*'/>
public enum RM_FILTER_ACTION
{
    /// <include file='RM_FILTER_ACTION.xml' path='doc/member[@name="RM_FILTER_ACTION.RmInvalidFilterAction"]/*'/>
    RmInvalidFilterAction = 0,
    /// <include file='RM_FILTER_ACTION.xml' path='doc/member[@name="RM_FILTER_ACTION.RmNoRestart"]/*'/>
    RmNoRestart = 1,
    /// <include file='RM_FILTER_ACTION.xml' path='doc/member[@name="RM_FILTER_ACTION.RmNoShutdown"]/*'/>
    RmNoShutdown = 2,
}