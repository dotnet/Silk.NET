// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INPUT_MESSAGE_SOURCE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class INPUT_MESSAGE_SOURCETests
{
    /// <summary>Validates that the <see cref = "INPUT_MESSAGE_SOURCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INPUT_MESSAGE_SOURCE>(), Is.EqualTo(sizeof(INPUT_MESSAGE_SOURCE)));
    }

    /// <summary>Validates that the <see cref = "INPUT_MESSAGE_SOURCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INPUT_MESSAGE_SOURCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INPUT_MESSAGE_SOURCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INPUT_MESSAGE_SOURCE), Is.EqualTo(8));
    }
}