// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IObjectArray"/> struct.</summary>
public static unsafe partial class IObjectArrayTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IObjectArray"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IObjectArray).GUID, Is.EqualTo(IID_IObjectArray));
    }

    /// <summary>Validates that the <see cref = "IObjectArray"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IObjectArray>(), Is.EqualTo(sizeof(IObjectArray)));
    }

    /// <summary>Validates that the <see cref = "IObjectArray"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IObjectArray).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IObjectArray"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IObjectArray), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IObjectArray), Is.EqualTo(4));
        }
    }
}