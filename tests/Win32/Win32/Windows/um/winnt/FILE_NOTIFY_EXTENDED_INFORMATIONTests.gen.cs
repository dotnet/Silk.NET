// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FILE_NOTIFY_EXTENDED_INFORMATION"/> struct.</summary>
[SupportedOSPlatform("windows10.0.16299.0")]
public static unsafe partial class FILE_NOTIFY_EXTENDED_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "FILE_NOTIFY_EXTENDED_INFORMATION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FILE_NOTIFY_EXTENDED_INFORMATION>(),
            Is.EqualTo(sizeof(FILE_NOTIFY_EXTENDED_INFORMATION))
        );
    }

    /// <summary>Validates that the <see cref = "FILE_NOTIFY_EXTENDED_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_NOTIFY_EXTENDED_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_NOTIFY_EXTENDED_INFORMATION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_NOTIFY_EXTENDED_INFORMATION), Is.EqualTo(88));
    }
}
