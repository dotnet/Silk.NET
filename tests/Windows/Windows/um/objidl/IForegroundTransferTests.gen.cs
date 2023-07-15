// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IForegroundTransfer"/> struct.</summary>
public static unsafe partial class IForegroundTransferTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IForegroundTransfer"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IForegroundTransfer).GUID, Is.EqualTo(IID_IForegroundTransfer));
    }

    /// <summary>Validates that the <see cref = "IForegroundTransfer"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IForegroundTransfer>(), Is.EqualTo(sizeof(IForegroundTransfer)));
    }

    /// <summary>Validates that the <see cref = "IForegroundTransfer"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IForegroundTransfer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IForegroundTransfer"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IForegroundTransfer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IForegroundTransfer), Is.EqualTo(4));
        }
    }
}