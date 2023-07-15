// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NOTIFY_USER_POWER_SETTING"/> struct.</summary>
public static unsafe partial class NOTIFY_USER_POWER_SETTINGTests
{
    /// <summary>Validates that the <see cref = "NOTIFY_USER_POWER_SETTING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NOTIFY_USER_POWER_SETTING>(), Is.EqualTo(sizeof(NOTIFY_USER_POWER_SETTING)));
    }

    /// <summary>Validates that the <see cref = "NOTIFY_USER_POWER_SETTING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NOTIFY_USER_POWER_SETTING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NOTIFY_USER_POWER_SETTING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NOTIFY_USER_POWER_SETTING), Is.EqualTo(16));
    }
}