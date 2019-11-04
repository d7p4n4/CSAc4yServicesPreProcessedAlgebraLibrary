using CSAc4y.Class;
using CSAc4yAlmostEmpty.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4yService.Class
{
	public class Ac4yServiceRequestAlgebra : Ac4yServiceRequestPreProcessed
	{

		public Ac4yServiceEnvelope getEnvelope() {
        		return Envelope;
        }

		public Ac4yIdentification getAc4yIdentification() {
        		return Ac4yIdentification;
        }

		public Int32 getId() {
        		return id;
        }

		public String getGUID() {
        		return GUID;
        }


    		public void setEnvelope(Ac4yServiceEnvelope newValue) {
        		Envelope = newValue;
        }

    		public void setAc4yIdentification(Ac4yIdentification newValue) {
        		Ac4yIdentification = newValue;
        }

    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setGUID(String newValue) {
        		GUID = newValue;
        }
	
		public Boolean hasEnvelope(){
			if(this.getEnvelope() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasAc4yIdentification(){
			if(this.getAc4yIdentification() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasGUID(){
			if(this.getGUID() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
