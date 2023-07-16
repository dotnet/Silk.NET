// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='IsolatedAppLauncherTelemetryParameters.xml' path='doc/member[@name="IsolatedAppLauncherTelemetryParameters"]/*'/>
public partial struct IsolatedAppLauncherTelemetryParameters
{
    /// <include file='IsolatedAppLauncherTelemetryParameters.xml' path='doc/member[@name="IsolatedAppLauncherTelemetryParameters.EnableForLaunch"]/*'/>
    public BOOL EnableForLaunch;
    /// <include file='IsolatedAppLauncherTelemetryParameters.xml' path='doc/member[@name="IsolatedAppLauncherTelemetryParameters.CorrelationGUID"]/*'/>
    public Guid CorrelationGUID;
}