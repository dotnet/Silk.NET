// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispWebGeolocation"/> struct.</summary>
public static unsafe partial class DispWebGeolocationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispWebGeolocation"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispWebGeolocation).GUID, Is.EqualTo(IID_DispWebGeolocation));
    }

    /// <summary>Validates that the <see cref = "DispWebGeolocation"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispWebGeolocation>(), Is.EqualTo(sizeof(DispWebGeolocation)));
    }

    /// <summary>Validates that the <see cref = "DispWebGeolocation"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispWebGeolocation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispWebGeolocation"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispWebGeolocation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispWebGeolocation), Is.EqualTo(4));
        }
    }
}