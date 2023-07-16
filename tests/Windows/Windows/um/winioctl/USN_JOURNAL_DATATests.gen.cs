// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "USN_JOURNAL_DATA"/> struct.</summary>
public static unsafe partial class USN_JOURNAL_DATATests
{
    /// <summary>Validates that the <see cref = "USN_JOURNAL_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USN_JOURNAL_DATA>(), Is.EqualTo(sizeof(USN_JOURNAL_DATA)));
    }

    /// <summary>Validates that the <see cref = "USN_JOURNAL_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USN_JOURNAL_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "USN_JOURNAL_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USN_JOURNAL_DATA), Is.EqualTo(64));
    }
}