/**************************************************************************
* Source File	:  Formation.cs
* Author                   :  Lycée BONAPARTE
* Project name         :  CasFormations* Created                 :  13/10/2016
* Modified   	:  13/10/2016
* Description	:  Definition of the class Formation
**************************************************************************/

using System;

namespace Cas formations
{
	public  class Formation  				
	{
		//Inners Classifiers
		
		
		//Attributes
			
		  
		 
		 	private
		  string code; 
		 	private
		  string libelle; 
		 	private
		  int nbJours; 
		
		//Attributes Association
		
				public Cas formations.Participant[] lesInscrits;
				public Cas formations.Session[] mesSessions;
	
		
	
		

				
		//Operations
		
		
			///<return>void</return>
		
			public  void affecteParticipants(); 	
		 
		

	} // End Class Formation
} // End Namespace Cas formations

