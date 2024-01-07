// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Guid("d2959bf7-b31b-4a3d-9600-712eb1335ba4")]
    [NativeName("Name", "IPrintDocumentPackageTargetFactory")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory : IComVtbl<IPrintDocumentPackageTargetFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d2959bf7-b31b-4a3d-9600-712eb1335ba4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPrintDocumentPackageTargetFactory val)
            => Unsafe.As<IPrintDocumentPackageTargetFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPrintDocumentPackageTargetFactory
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                    {
                        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
                fixed (char* jobNamePtr = &jobName)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                    {
                        fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                        {
                            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* printerNamePtr = &printerName)
            {
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)jobNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobName, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                    }
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            fixed (char* jobNamePtr = &jobName)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                    {
                        fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStream, docPackageTargetPtr);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTarget);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStream, jobPrintTicketStreamPtr, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTarget);
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStream, docPackageTargetPtr);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTarget);
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var printerNamePtr = (byte*) SilkMarshal.StringToPtr(printerName, NativeStringEncoding.LPWStr);
            var jobNamePtr = (byte*) SilkMarshal.StringToPtr(jobName, NativeStringEncoding.LPWStr);
            fixed (Silk.NET.Core.Win32Extras.IStream* jobOutputStreamPtr = &jobOutputStream)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStreamPtr = &jobPrintTicketStream)
                {
                    fixed (IPrintDocumentPackageTarget** docPackageTargetPtr = &docPackageTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, byte*, byte*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerNamePtr, jobNamePtr, jobOutputStreamPtr, jobPrintTicketStreamPtr, docPackageTargetPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)jobNamePtr);
            SilkMarshal.Free((nint)printerNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(in printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, in jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1, TI2>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref ComPtr<TI2> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI2>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ComPtr<TI1> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ComPtr<TI0> jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, (Silk.NET.Core.Win32Extras.IStream*) jobOutputStream.Handle, ref jobPrintTicketStream, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref ComPtr<TI1> docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI1>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ComPtr<TI0> jobPrintTicketStream, ref IPrintDocumentPackageTarget* docPackageTarget) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, (Silk.NET.Core.Win32Extras.IStream*) jobPrintTicketStream.Handle, ref docPackageTarget);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDocumentPackageTargetForPrintJob<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string jobName, ref Silk.NET.Core.Win32Extras.IStream jobOutputStream, ref Silk.NET.Core.Win32Extras.IStream jobPrintTicketStream, ref ComPtr<TI0> docPackageTarget) where TI0 : unmanaged, IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDocumentPackageTargetForPrintJob(printerName, jobName, ref jobOutputStream, ref jobPrintTicketStream, (IPrintDocumentPackageTarget**) docPackageTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
