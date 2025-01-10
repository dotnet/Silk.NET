// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ITfInputProcessorProfiles"/> struct.</summary>
public static unsafe partial class ITfInputProcessorProfilesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfInputProcessorProfiles"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ITfInputProcessorProfiles).GUID,
            Is.EqualTo(IID_ITfInputProcessorProfiles)
        );
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfiles"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ITfInputProcessorProfiles>(),
            Is.EqualTo(sizeof(ITfInputProcessorProfiles))
        );
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfiles"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfInputProcessorProfiles).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfiles"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfInputProcessorProfiles), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfInputProcessorProfiles), Is.EqualTo(4));
        }
    }
}
