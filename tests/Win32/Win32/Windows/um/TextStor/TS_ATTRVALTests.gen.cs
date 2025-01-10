// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TS_ATTRVAL"/> struct.</summary>
public static unsafe partial class TS_ATTRVALTests
{
    /// <summary>Validates that the <see cref = "TS_ATTRVAL"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TS_ATTRVAL>(), Is.EqualTo(sizeof(TS_ATTRVAL)));
    }

    /// <summary>Validates that the <see cref = "TS_ATTRVAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TS_ATTRVAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TS_ATTRVAL"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TS_ATTRVAL), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(TS_ATTRVAL), Is.EqualTo(40));
        }
    }
}
