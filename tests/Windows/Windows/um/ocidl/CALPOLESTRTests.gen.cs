// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CALPOLESTR"/> struct.</summary>
public static unsafe partial class CALPOLESTRTests
{
    /// <summary>Validates that the <see cref = "CALPOLESTR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CALPOLESTR>(), Is.EqualTo(sizeof(CALPOLESTR)));
    }

    /// <summary>Validates that the <see cref = "CALPOLESTR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CALPOLESTR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CALPOLESTR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CALPOLESTR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CALPOLESTR), Is.EqualTo(8));
        }
    }
}