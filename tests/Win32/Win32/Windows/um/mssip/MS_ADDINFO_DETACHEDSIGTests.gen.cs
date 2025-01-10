// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MS_ADDINFO_DETACHEDSIG"/> struct.</summary>
public static unsafe partial class MS_ADDINFO_DETACHEDSIGTests
{
    /// <summary>Validates that the <see cref = "MS_ADDINFO_DETACHEDSIG"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MS_ADDINFO_DETACHEDSIG>(),
            Is.EqualTo(sizeof(MS_ADDINFO_DETACHEDSIG))
        );
    }

    /// <summary>Validates that the <see cref = "MS_ADDINFO_DETACHEDSIG"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MS_ADDINFO_DETACHEDSIG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MS_ADDINFO_DETACHEDSIG"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MS_ADDINFO_DETACHEDSIG), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(MS_ADDINFO_DETACHEDSIG), Is.EqualTo(16));
        }
    }
}
