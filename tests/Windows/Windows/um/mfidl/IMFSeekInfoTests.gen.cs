// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSeekInfo"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IMFSeekInfoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSeekInfo"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSeekInfo).GUID, Is.EqualTo(IID_IMFSeekInfo));
    }

    /// <summary>Validates that the <see cref = "IMFSeekInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSeekInfo>(), Is.EqualTo(sizeof(IMFSeekInfo)));
    }

    /// <summary>Validates that the <see cref = "IMFSeekInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSeekInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSeekInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSeekInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSeekInfo), Is.EqualTo(4));
        }
    }
}