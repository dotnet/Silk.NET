// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFQualityAdvise"/> struct.</summary>
public static unsafe partial class IMFQualityAdviseTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFQualityAdvise"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFQualityAdvise).GUID, Is.EqualTo(IID_IMFQualityAdvise));
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdvise"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFQualityAdvise>(), Is.EqualTo(sizeof(IMFQualityAdvise)));
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdvise"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFQualityAdvise).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFQualityAdvise"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFQualityAdvise), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFQualityAdvise), Is.EqualTo(4));
        }
    }
}