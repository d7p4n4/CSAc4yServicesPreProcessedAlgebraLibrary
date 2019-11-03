using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4yService.Class
{
	public class Ac4yProcessResultAlgebra : Ac4yProcessResultPreProcessed
	{

		public String getRequestId() {
        		return RequestId;
        }

		public String getCode() {
        		return Code;
        }

		public String getMessage() {
        		return Message;
        }

		public String getDescription() {
        		return Description;
        }


    		public void setRequestId(String newValue) {
        		RequestId = newValue;
        }

    		public void setCode(String newValue) {
        		Code = newValue;
        }

    		public void setMessage(String newValue) {
        		Message = newValue;
        }

    		public void setDescription(String newValue) {
        		Description = newValue;
        }
	
		public Boolean hasRequestId(){
			if(this.getRequestId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasCode(){
			if(this.getCode() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasMessage(){
			if(this.getMessage() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasDescription(){
			if(this.getDescription() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
