// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WCM_USAGE_DATA"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WCM_USAGE_DATATests
{
    /// <summary>Validates that the <see cref = "WCM_USAGE_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WCM_USAGE_DATA>(), Is.EqualTo(sizeof(WCM_USAGE_DATA)));
    }

    /// <summary>Validates that the <see cref = "WCM_USAGE_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WCM_USAGE_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WCM_USAGE_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WCM_USAGE_DATA), Is.EqualTo(12));
    }
}