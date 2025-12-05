// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Defines the order for SilkTouch's <see cref="INameTrimmer"/> implementations.
/// </summary>
internal enum TrimmerOrder
{
    NameTrimmer = 100,
    NameTrimmer217 = 110,
    NameTrimmer218 = 120,

    NameAffixerEarlyTrimmer = 200,

    MixKhronosData = 300,

    NameAffixerLateTrimmer = 400,

    PrettifyNamesTrimmer = 500,
}
