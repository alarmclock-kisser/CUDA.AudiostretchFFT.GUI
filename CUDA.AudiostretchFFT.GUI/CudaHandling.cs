using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedCuda;
using ManagedCuda.BasicTypes;

namespace CUDA.AudiostretchFFT.GUI
{
	public class CudaHandling
	{
		// Attributes
		public PrimaryContext? Context;

		// Constructor
		public CudaHandling()
		{
			// Default Initialization
			
		}

		// Methods
		public void InitializeContext(PrimaryContext context)
		{
			// Check if the device is valid
			if (context.Equals(null))
			{
				throw new ArgumentNullException("Invalid context");
			}

			// Set the current context and attribute
			this.Context = context;
			context.SetCurrent();
		}

		public void DisposeContext(PrimaryContext context)
		{
			// Check if the device is valid
			if (context.Equals(null))
			{
				throw new ArgumentNullException("Invalid context");
			}

			// Dispose the context and attribute
			context.Dispose();
			this.Context?.Dispose();
			this.Context = null;
		}

		public int GetDeviceCount()
		{
			// Return the number of available CUDA devices
			return CudaContext.GetDeviceCount();
		}

		public CUdevice GetDeviceById(int id)
		{
			// If id == -1, return the strongest device id (by Gflops)
			if (id == -1)
			{
				return PrimaryContext.GetCUdevice(PrimaryContext.GetMaxGflopsDeviceId());
			}

			// Offset correction for index & id
			id -= 1;

			// Check if the device id is valid
			if (id < 0 || id >= GetDeviceCount())
			{
				throw new ArgumentOutOfRangeException("Invalid device id");
			}

			return PrimaryContext.GetCUdevice(id);
		}

		public PrimaryContext GetContextById(int id)
		{
			// Check if the device is valid
			if (id < 0 || id >= GetDeviceCount())
			{
				throw new ArgumentOutOfRangeException("Invalid device id");
			}

			// Return the context of the device
			return new PrimaryContext(id);
		}

		public string GetDeviceName(int id)
		{
			// Check if the device id is valid
			if (id < 0 || id >= GetDeviceCount())
			{
				throw new ArgumentOutOfRangeException("Invalid device id");
			}

			return CudaContext.GetDeviceName(id);
		}


	}
}
