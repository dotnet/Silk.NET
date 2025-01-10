// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "RID_DEVICE_INFO"/> struct.</summary>
public static unsafe partial class RID_DEVICE_INFOTests
{
    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RID_DEVICE_INFO>(), Is.EqualTo(sizeof(RID_DEVICE_INFO)));
    }

    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RID_DEVICE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RID_DEVICE_INFO), Is.EqualTo(32));
    }
}
