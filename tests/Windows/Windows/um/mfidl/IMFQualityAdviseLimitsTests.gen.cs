// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFQualityAdviseLimits"/> struct.</summary>
public static unsafe partial class IMFQualityAdviseLimitsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFQualityAdviseLimits"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFQualityAdviseLimits).GUID, Is.EqualTo(IID_IMFQualityAdviseLimits));
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdviseLimits"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFQualityAdviseLimits>(), Is.EqualTo(sizeof(IMFQualityAdviseLimits)));
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdviseLimits"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFQualityAdviseLimits).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdviseLimits"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFQualityAdviseLimits), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFQualityAdviseLimits), Is.EqualTo(4));
        }
    }
}