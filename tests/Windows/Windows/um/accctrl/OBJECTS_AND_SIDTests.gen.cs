// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OBJECTS_AND_SID"/> struct.</summary>
public static unsafe partial class OBJECTS_AND_SIDTests
{
    /// <summary>Validates that the <see cref = "OBJECTS_AND_SID"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OBJECTS_AND_SID>(), Is.EqualTo(sizeof(OBJECTS_AND_SID)));
    }

    /// <summary>Validates that the <see cref = "OBJECTS_AND_SID"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OBJECTS_AND_SID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OBJECTS_AND_SID"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OBJECTS_AND_SID), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(OBJECTS_AND_SID), Is.EqualTo(40));
        }
    }
}