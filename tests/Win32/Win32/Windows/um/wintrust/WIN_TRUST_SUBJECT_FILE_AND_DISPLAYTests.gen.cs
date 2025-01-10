// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WIN_TRUST_SUBJECT_FILE_AND_DISPLAY"/> struct.</summary>
public static unsafe partial class WIN_TRUST_SUBJECT_FILE_AND_DISPLAYTests
{
    /// <summary>Validates that the <see cref = "WIN_TRUST_SUBJECT_FILE_AND_DISPLAY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WIN_TRUST_SUBJECT_FILE_AND_DISPLAY>(),
            Is.EqualTo(sizeof(WIN_TRUST_SUBJECT_FILE_AND_DISPLAY))
        );
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_SUBJECT_FILE_AND_DISPLAY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN_TRUST_SUBJECT_FILE_AND_DISPLAY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_SUBJECT_FILE_AND_DISPLAY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WIN_TRUST_SUBJECT_FILE_AND_DISPLAY), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(WIN_TRUST_SUBJECT_FILE_AND_DISPLAY), Is.EqualTo(12));
        }
    }
}
