// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IComputerInfoChangeNotify"/> struct.</summary>
public static unsafe partial class IComputerInfoChangeNotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IComputerInfoChangeNotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IComputerInfoChangeNotify).GUID, Is.EqualTo(IID_IComputerInfoChangeNotify));
    }

    /// <summary>Validates that the <see cref = "IComputerInfoChangeNotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IComputerInfoChangeNotify>(), Is.EqualTo(sizeof(IComputerInfoChangeNotify)));
    }

    /// <summary>Validates that the <see cref = "IComputerInfoChangeNotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IComputerInfoChangeNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IComputerInfoChangeNotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IComputerInfoChangeNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IComputerInfoChangeNotify), Is.EqualTo(4));
        }
    }
}