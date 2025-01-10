// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SE_ADT_CLAIMS"/> struct.</summary>
public static unsafe partial class SE_ADT_CLAIMSTests
{
    /// <summary>Validates that the <see cref = "SE_ADT_CLAIMS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_ADT_CLAIMS>(), Is.EqualTo(sizeof(SE_ADT_CLAIMS)));
    }

    /// <summary>Validates that the <see cref = "SE_ADT_CLAIMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_ADT_CLAIMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_ADT_CLAIMS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_ADT_CLAIMS), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SE_ADT_CLAIMS), Is.EqualTo(8));
        }
    }
}
