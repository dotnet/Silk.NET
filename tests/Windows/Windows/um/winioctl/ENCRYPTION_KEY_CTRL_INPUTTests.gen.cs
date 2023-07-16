// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ENCRYPTION_KEY_CTRL_INPUT"/> struct.</summary>
public static unsafe partial class ENCRYPTION_KEY_CTRL_INPUTTests
{
    /// <summary>Validates that the <see cref = "ENCRYPTION_KEY_CTRL_INPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ENCRYPTION_KEY_CTRL_INPUT>(), Is.EqualTo(sizeof(ENCRYPTION_KEY_CTRL_INPUT)));
    }

    /// <summary>Validates that the <see cref = "ENCRYPTION_KEY_CTRL_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ENCRYPTION_KEY_CTRL_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ENCRYPTION_KEY_CTRL_INPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ENCRYPTION_KEY_CTRL_INPUT), Is.EqualTo(32));
    }
}