// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RATE_QUOTA_LIMIT"/> struct.</summary>
public static unsafe partial class RATE_QUOTA_LIMITTests
{
    /// <summary>Validates that the <see cref = "RATE_QUOTA_LIMIT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RATE_QUOTA_LIMIT>(), Is.EqualTo(sizeof(RATE_QUOTA_LIMIT)));
    }

    /// <summary>Validates that the <see cref = "RATE_QUOTA_LIMIT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(RATE_QUOTA_LIMIT).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "RATE_QUOTA_LIMIT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RATE_QUOTA_LIMIT), Is.EqualTo(4));
    }
}