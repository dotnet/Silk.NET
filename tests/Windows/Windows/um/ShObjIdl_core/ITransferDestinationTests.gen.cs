// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITransferDestination"/> struct.</summary>
public static unsafe partial class ITransferDestinationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITransferDestination"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITransferDestination).GUID, Is.EqualTo(IID_ITransferDestination));
    }

    /// <summary>Validates that the <see cref = "ITransferDestination"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITransferDestination>(), Is.EqualTo(sizeof(ITransferDestination)));
    }

    /// <summary>Validates that the <see cref = "ITransferDestination"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITransferDestination).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITransferDestination"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITransferDestination), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITransferDestination), Is.EqualTo(4));
        }
    }
}