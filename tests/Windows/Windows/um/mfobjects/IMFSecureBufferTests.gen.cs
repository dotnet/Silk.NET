// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSecureBuffer"/> struct.</summary>
public static unsafe partial class IMFSecureBufferTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSecureBuffer"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSecureBuffer).GUID, Is.EqualTo(IID_IMFSecureBuffer));
    }

    /// <summary>Validates that the <see cref = "IMFSecureBuffer"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSecureBuffer>(), Is.EqualTo(sizeof(IMFSecureBuffer)));
    }

    /// <summary>Validates that the <see cref = "IMFSecureBuffer"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSecureBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSecureBuffer"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSecureBuffer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSecureBuffer), Is.EqualTo(4));
        }
    }
}