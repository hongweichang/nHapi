using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V251.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V251.Group
{
///<summary>
///Represents the RAS_O17_ADMINISTRATION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: RXA (Pharmacy/Treatment Administration) repeating</li>
///<li>1: RXR (Pharmacy/Treatment Route) </li>
///<li>2: RAS_O17_OBSERVATION (a Group object) </li>
///</ol>
///</summary>
[Serializable]
public class RAS_O17_ADMINISTRATION : AbstractGroup {

	///<summary> 
	/// Creates a new RAS_O17_ADMINISTRATION Group.
	///</summary>
	public RAS_O17_ADMINISTRATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXA), true, true);
	      this.add(typeof(RXR), true, false);
	      this.add(typeof(RAS_O17_OBSERVATION), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RAS_O17_ADMINISTRATION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of RXA (Pharmacy/Treatment Administration) - creates it if necessary
	///</summary>
	public RXA GetRXA() {
	   RXA ret = null;
	   try {
	      ret = (RXA)this.GetStructure("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXA
	/// * (Pharmacy/Treatment Administration) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXA GetRXA(int rep) { 
	   return (RXA)this.GetStructure("RXA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXA 
	 */ 
	public int RXARepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns RXR (Pharmacy/Treatment Route) - creates it if necessary
	///</summary>
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RAS_O17_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public RAS_O17_OBSERVATION OBSERVATION { 
get{
	   RAS_O17_OBSERVATION ret = null;
	   try {
	      ret = (RAS_O17_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
