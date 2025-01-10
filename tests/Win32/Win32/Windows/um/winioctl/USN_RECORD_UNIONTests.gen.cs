// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "USN_RECORD_UNION"/> struct.</summary>
public static unsafe partial class USN_RECORD_UNIONTests
{
    /// <summary>Validates that the <see cref = "USN_RECORD_UNION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USN_RECORD_UNION>(), Is.EqualTo(sizeof(USN_RECORD_UNION)));
    }

    /// <summary>Validates that the <see cref = "USN_RECORD_UNION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(USN_RECORD_UNION).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "USN_RECORD_UNION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USN_RECORD_UNION), Is.EqualTo(80));
    }
}
