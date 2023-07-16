// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SUPPORTED_OS_INFO"/> struct.</summary>
public static unsafe partial class SUPPORTED_OS_INFOTests
{
    /// <summary>Validates that the <see cref = "SUPPORTED_OS_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SUPPORTED_OS_INFO>(), Is.EqualTo(sizeof(SUPPORTED_OS_INFO)));
    }

    /// <summary>Validates that the <see cref = "SUPPORTED_OS_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SUPPORTED_OS_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SUPPORTED_OS_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SUPPORTED_OS_INFO), Is.EqualTo(4));
    }
}