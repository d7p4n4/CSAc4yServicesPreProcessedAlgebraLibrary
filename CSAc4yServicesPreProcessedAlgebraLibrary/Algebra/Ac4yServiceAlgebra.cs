using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4yService.Class
{
	public class Ac4yServiceAlgebra : Ac4yServicePreProcessed
	{

		public Ac4yServiceRequest getRequest() {
        		return Request;
        }

		public Ac4yServiceResponse getResponse() {
        		return Response;
        }


    		public void setRequest(Ac4yServiceRequest newValue) {
        		Request = newValue;
        }

    		public void setResponse(Ac4yServiceResponse newValue) {
        		Response = newValue;
        }
	
		public Boolean hasRequest(){
			if(this.getRequest() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasResponse(){
			if(this.getResponse() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
