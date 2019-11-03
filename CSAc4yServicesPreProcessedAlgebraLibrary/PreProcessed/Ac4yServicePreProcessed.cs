
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4yService.Class 
{
	            [GUID("11bcedb0-2a64-4987-bca4-f5f2703fddcd")]
	public class Ac4yServicePreProcessed

	{
    		public Ac4yServiceRequest Request { get; set; }
    		public Ac4yServiceResponse Response { get; set; }
        public string GUID { get; set; }
		
		public Ac4yServicePreProcessed()
		{
			GUID = "11bcedb0-2a64-4987-bca4-f5f2703fddcd";
		}
	}
}