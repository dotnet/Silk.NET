// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SIP_SUBJECTINFO"/> struct.</summary>
public static unsafe partial class SIP_SUBJECTINFOTests
{
    /// <summary>Validates that the <see cref = "SIP_SUBJECTINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SIP_SUBJECTINFO>(), Is.EqualTo(sizeof(SIP_SUBJECTINFO)));
    }

    /// <summary>Validates that the <see cref = "SIP_SUBJECTINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIP_SUBJECTINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIP_SUBJECTINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SIP_SUBJECTINFO), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(SIP_SUBJECTINFO), Is.EqualTo(80));
        }
    }
}
