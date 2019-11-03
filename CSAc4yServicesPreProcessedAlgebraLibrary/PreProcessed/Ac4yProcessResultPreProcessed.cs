
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4yService.Class 
{
	            [GUID("e91c58b0-c72c-4827-8553-43c54727d8b7")]
	public class Ac4yProcessResultPreProcessed 

	{
    		public String RequestId { get; set; }
    		public String Code { get; set; }
    		public String Message { get; set; }
    		public String Description { get; set; }
        public string GUID { get; set; }
		
		public Ac4yProcessResultPreProcessed()
		{
			GUID = "e91c58b0-c72c-4827-8553-43c54727d8b7";
		}
	}
}