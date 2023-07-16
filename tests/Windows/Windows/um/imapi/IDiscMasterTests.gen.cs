// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDiscMaster"/> struct.</summary>
public static unsafe partial class IDiscMasterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiscMaster"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiscMaster).GUID, Is.EqualTo(IID_IDiscMaster));
    }

    /// <summary>Validates that the <see cref = "IDiscMaster"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiscMaster>(), Is.EqualTo(sizeof(IDiscMaster)));
    }

    /// <summary>Validates that the <see cref = "IDiscMaster"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiscMaster).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiscMaster"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiscMaster), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiscMaster), Is.EqualTo(4));
        }
    }
}