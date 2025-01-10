// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WCM_POLICY_VALUE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WCM_POLICY_VALUETests
{
    /// <summary>Validates that the <see cref = "WCM_POLICY_VALUE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WCM_POLICY_VALUE>(), Is.EqualTo(sizeof(WCM_POLICY_VALUE)));
    }

    /// <summary>Validates that the <see cref = "WCM_POLICY_VALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WCM_POLICY_VALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WCM_POLICY_VALUE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WCM_POLICY_VALUE), Is.EqualTo(8));
    }
}
